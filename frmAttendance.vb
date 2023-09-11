Imports MySql.Data.MySqlClient

Public Class frmAttendance

    ' Place Holders
    Private stStudentID As String

    ' Flag
    Private counter As Integer = 1
    Private bTimeInState As Boolean = True
    Private bUpdate = True

    ' Too easily pass data between functions
    Private Structure AttendanceData
        Public id As String
        Public timeIn As DateTime
    End Structure

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Center the Student ID Panel
        Dim xCenter As Double = panStudentID.Location.X
        Dim yCenter As Double = (tabAttendance.Size.Height / 2) - (panStudentID.Size.Height / 2)
        panStudentID.Location = New Point(xCenter, yCenter)

        '' Center the Logo Panel
        Dim temp As Double = tabAttendance.Size.Width * 0.4
        xCenter = panLogos.Location.X
        yCenter = (tabAttendance.Size.Height / 2) - (panLogos.Size.Height / 2)
        panLogos.Location = New Point(xCenter, yCenter)

        ' Center Login Panel
        xCenter = (tabView.Size.Width / 2) - (panLogin.Size.Width / 2)
        yCenter = (tabView.Size.Height / 2) - (panLogin.Size.Height / 2)
        panLogin.Location = New Point(xCenter, yCenter)

        ' Update Time
        updateTime()

        ' Center Time Panel
        xCenter = (tabAttendance.Size.Width / 2) - (lblTime.Size.Width / 2)
        yCenter = (tabAttendance.Size.Height * 0.1) - (lblTime.Size.Height / 2)
        lblTime.Location = New Point(xCenter, yCenter)

        CenterMessage()

        ' Check Connection
        TestConnection()
    End Sub

    Private Function TestConnection() As Boolean
        Dim conn As New MySqlConnection(stConnection)
        Try
            conn.Open()
            bUpdate = True
        Catch ex As Exception
            btnReconnect.Enabled = True
            btnReconnect.BackColor = redColor
            If bUpdate Then
                bUpdate = False
                MessageBox.Show("Failed to connect.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        Finally
            conn.Close()
        End Try

        Return True
    End Function

    Private Sub lblMessage_SizeChanged(sender As Object, e As EventArgs) Handles lblMessage.SizeChanged
        CenterMessage()
    End Sub

    Public Sub CenterMessage()
        Dim xCenter = (tabAttendance.Size.Width / 2) - (lblMessage.Size.Width / 2)
        Dim yCenter = (tabAttendance.Size.Height * 0.9) - (lblMessage.Size.Height / 2)
        lblMessage.Location = New Point(xCenter, yCenter)
    End Sub

    ' Every 1/10 of a second
    Private Sub tmrFast_Tick(sender As Object, e As EventArgs) Handles tmrFast.Tick
        If Not bUpdate Then Exit Sub

        ' Establish Reconnect if needed
        If Not TestConnection() Then Exit Sub

        checkStudentAttendance()
        updateOrgAttendees()
    End Sub

    ' Every Second Update
    Private Sub tmeSlow_Tick(sender As Object, e As EventArgs) Handles tmrSlow.Tick
        updateTime()

        'If Not bUpdate Then
        '    If Not counter Mod 20 = 0 Then
        '        counter += 1
        '        Exit Sub
        '    End If

        '    counter = 1

        '    Reconnect()
        'End If
    End Sub

    Private Sub updateTime()
        ' Update Label
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        ' Student ID Validation
        If Not txtStudentID.Text.Length = txtStudentID.MaxLength Then Exit Sub

        checkStudentAttendance()
    End Sub

    Public Function checkStudentAttendance() As Boolean
        ' Connect to database
        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()

            Dim command As New MySqlCommand("SELECT dstudentid,dfullname,dcourse,dyearlevel,ddepartment
                                            FROM tblstudent WHERE dstudentid = @ID;", conn)
            command.Parameters.AddWithValue("@ID", txtStudentID.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Student not found
            If Not reader.Read() Then
                lblFullName.Text = String.Empty
                lblCourse.Text = String.Empty
                lblDepartment.Text = String.Empty
                lblTimeIn.Text = String.Empty
                btnSubmit.Enabled = False

                ' Button Appearance
                btnChange(2)
                Return Nothing
            End If

            btnSubmit.Enabled = True

            stStudentID = reader(0).ToString()
            lblFullName.Text = reader(1).ToString()
            lblCourse.Text = reader(2).ToString() & " - " & reader(3).ToString()
            lblDepartment.Text = reader(4).ToString()
            reader.Close()

            ' Get latest Time In
            command.CommandText = $"select max(ttimein) from tblattendance where dstudentid = '{stStudentID}' and ttimeout is null;"
            reader = command.ExecuteReader()

            Dim timeIn As DateTime = Nothing

            If reader.Read() And Not IsDBNull(reader(0)) Then
                timeIn = reader(0)
            End If

            If timeIn = DateTime.MinValue Then
                ' Button Appearance
                btnChange(0)
                lblTimeIn.Text = String.Empty

                bTimeInState = False
            Else
                ' Button Appearance
                btnChange(1)

                lblTimeIn.Text = timeIn.ToString("hh:mm:ss tt")

                bTimeInState = True
            End If

            Return bTimeInState
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Return Nothing
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Submit()
    End Sub
    Private Sub Submit()
        Const stTitle As String = "Time In/Out"

        ' Lock Button
        btnSubmit.Enabled = False

        ' Check if na update yung attendance ni student
        Threading.Thread.Sleep(tmrSlow.Interval / 2)
        Dim temp = bTimeInState
        If Not temp = checkStudentAttendance() Then
            MessageBox.Show($"Looks like something changed to your time in/out.{vbCrLf}Please press the button again if you want to proceed.",
                            stTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Connect to the database
        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()

            Dim command As New MySqlCommand("", conn)
            Dim currentTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            If btnSubmit.Text = "Time Out" Then
                command.CommandText = $"update tblattendance set ttimeout = '{currentTime}' where dstudentid = '{stStudentID}' and ttimeout is null;"

            Else
                ' Create new time in
                command.CommandText = $"insert into tblattendance values(null, '{stStudentID}', '{currentTime}', null);"
            End If

            ' Execute
            command.ExecuteNonQuery()

            ' Update Org Attendees
            updateOrgAttendees()

            ' Reload student data
            checkStudentAttendance()

            txtStudentID.Text = ""
            txtStudentID.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message, stTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        ' Unlock Button
        btnSubmit.Enabled = True
    End Sub
    Private Sub updateOrgAttendees()
        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()
            Dim currentDate As String = DateTime.Now.Date.ToString("yyyy-MM-dd")
            Dim command As New MySqlCommand($"select tblstudent.ddepartment from tblattendance inner join tblstudent on tblattendance.dstudentid = tblstudent.dstudentid
                                            where ttimein between '{currentDate} 00:00:00' and '{currentDate} 23:59:59' and ttimeout is null;", conn)
            Dim reader As MySqlDataReader
            reader = command.ExecuteReader()

            Dim cas, cba, cithm, coecs, lpusc, total As Integer

            While reader.Read()
                ' Iterate through each course
                Select Case reader(0)
                    Case "College of International Tourism and Hospitality Management"
                        cithm += 1
                    Case "College of Engineering and Computer Studies"
                        coecs += 1
                    Case "'College of Business and Accountancy'"
                        cba += 1
                    Case "'College of Arts and Sciences'"
                        cas += 1
                    Case "LPU - ST. CABRINI"
                        lpusc += 1
                End Select

                total += 1
            End While

            ' Update labels
            lblCAS.Text = cas
            lblCBA.Text = cba
            lblCITHM.Text = cithm
            lblCOECS.Text = coecs
            lblLPUSC.Text = lpusc
            lblTotal.Text = $"Total Current Attendees: {total}"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Organization Attendees", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnChange(iState As Integer)
        If iState = 0 Then
            btnSubmit.Text = "Time In"
            btnSubmit.BackColor = greenColor
        ElseIf iState = 1 Then
            btnSubmit.Text = "Time Out"
            btnSubmit.BackColor = redColor
        Else
            btnSubmit.Text = "Time In/Out"
            btnSubmit.BackColor = grayColor
        End If
    End Sub

    'Private Sub picCE_Click(sender As Object, e As EventArgs) Handles picCAS.Click
    '    openOrgForm("CE", "BSCE", "")
    'End Sub

    'Private Sub picCPS_Click(sender As Object, e As EventArgs) Handles picCBA.Click
    '    openOrgForm("CPS", "BSCS", "BSIT")
    'End Sub

    'Private Sub picIECEP_Click(sender As Object, e As EventArgs) Handles picCITHM.Click
    '    openOrgForm("IECEP", "BSECE", "")
    'End Sub

    'Private Sub picIIEE_Click(sender As Object, e As EventArgs) Handles picCOECS.Click
    '    openOrgForm("IIEE", "BSEE", "")
    'End Sub

    'Private Sub picLPIES_Click(sender As Object, e As EventArgs) Handles picLPUSC.Click
    '    openOrgForm("LPIES", "BSIE", "")
    'End Sub

    'Private Sub openOrgForm(org As String, course1 As String, course2 As String)
    '    frmOrganization.stOrg = org
    '    frmOrganization.stCourse1 = course1
    '    frmOrganization.stCourse2 = course2
    '    frmOrganization.Show(Me)
    '    Me.Hide()
    'End Sub

    ' ADMIN LOGIN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub Login()
        Dim conn As New MySqlConnection(stConnection)
        Dim stTitle As String = "Login"

        Try
            conn.Open()

            Dim command As New MySqlCommand("select * from tbladmin where dusername = @USERNAME and dpassword = sha2(@PASSWORD, 256);", conn)
            command.Parameters.AddWithValue("@USERNAME", txtUsername.Text)
            command.Parameters.AddWithValue("@PASSWORD", txtPassword.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Open the admin control panel form
                frmAdmin.Show(Me)
                Me.Hide()
            Else
                MessageBox.Show("Invalid Credentials.", stTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, stTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnReconnect_Click(sender As Object, e As EventArgs) Handles btnReconnect.Click
        Reconnect()
    End Sub

    Private Sub Reconnect()
        btnReconnect.Text = "Reconn"
        Dim conn As New MySqlConnection(stConnection)
        Try
            conn.Open()
            bUpdate = True
            btnReconnect.Enabled = False
            btnReconnect.BackColor = greenColor
            'MessageBox.Show("Reconnected.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

            'MessageBox.Show("Failed to Reconnect.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        btnReconnect.Text = "Status"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Prompt if they really want to close
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Close if yes
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAttendance_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            tmrSlow.Start()
            tmrFast.Start()
        Else
            tmrSlow.Stop()
            tmrFast.Stop()
        End If
    End Sub

    'UX CODES
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Login()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            If txtStudentID.Enabled = True Then
                txtStudentID.Select()
            End If
        ElseIf TabControl1.SelectedIndex = 1 Then
            txtUsername.Select()
        End If
    End Sub

    Private Sub txtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentID.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If btnSubmit.Enabled = True Then
                Submit()
            End If
        End If
    End Sub


End Class
