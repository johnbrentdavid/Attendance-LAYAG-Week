Imports MySql.Data.MySqlClient

Public Class frmAttendance

    ' Place Holders
    Private stStudentID As String

    ' Flag
    Private iTimer As Integer = 0
    Private dPerSecond As Double
    Private bTimeInState As Boolean = True
    Private bUpdate = True

    ' Too easily pass data between functions
    Private Structure AttendanceData
        Public id As String
        Public timeIn As DateTime
    End Structure

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Center the Student ID Panel
        Dim xCenter As Double = (tabAttendance.Size.Width * 0.2) - (panStudentID.Size.Width / 2)
        Dim yCenter As Double = (tabAttendance.Size.Height / 2) - (panStudentID.Size.Height / 2)
        panStudentID.Location = New Point(xCenter, yCenter)

        ' Center the Logo Panel
        Dim temp As Double = tabAttendance.Size.Width * 0.4
        xCenter = (temp + (tabAttendance.Size.Width - temp) / 2) - (panLogos.Size.Width / 2)
        yCenter = (tabAttendance.Size.Height / 2) - (panLogos.Size.Height / 2)
        panLogos.Location = New Point(xCenter, yCenter)

        ' Center Login Panel
        xCenter = (tabView.Size.Width / 2) - (panLogin.Size.Width / 2)
        yCenter = (tabView.Size.Height / 2) - (panLogin.Size.Height / 2)
        panLogin.Location = New Point(xCenter, yCenter)

        ' Update Attendees Per Org
        'updateOrgAttendees()

        ' Update Time
        updateTime()

        ' Center Time Panel
        xCenter = (tabAttendance.Size.Width / 2) - (panTime.Size.Width / 2)
        yCenter = (tabAttendance.Size.Height * 0.1) - (panTime.Size.Height / 2)
        panTime.Location = New Point(xCenter, yCenter)

        ' Center Time Label in Time Panel
        xCenter = (panTime.Size.Width / 2) - (lblTime.Size.Width / 2)
        yCenter = (panTime.Size.Height / 2) - (lblTime.Size.Height / 2)
        lblTime.Location = New Point(xCenter, yCenter)

        ' Relocate message
        xCenter = (tabAttendance.Size.Width / 2) - (lblMessage.Size.Width / 2)
        yCenter = (tabAttendance.Size.Height * 0.9) - (lblMessage.Size.Height / 2)
        lblMessage.Location = New Point(xCenter, yCenter)

        ' Frequency of tick to a second
        dPerSecond = 1000 / Timer1.Interval

        ' Check Connection
        TestConnection()
    End Sub

    Private Function TestConnection() As Boolean
        Dim conn As New MySqlConnection(stConnection)
        Try
            conn.Open()

        Catch ex As Exception
            bUpdate = False
            btnReconnect.Enabled = True
            btnReconnect.BackColor = redColor
            MessageBox.Show("Failed to connect.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try

        Return True
    End Function

    Private Sub lblMessage_TextChanged(sender As Object, e As EventArgs) Handles lblMessage.TextChanged
        Dim x As Double = (tabAttendance.Size.Width / 2) - (lblMessage.Size.Width / 2)
        lblMessage.Location = New Point(x, lblMessage.Location.Y)
    End Sub

    ' Every Second Update
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Updated every second
        If iTimer Mod dPerSecond = 0 Then
            updateTime()
            iTimer = 0
        Else
            iTimer += 1
        End If

        If Not bUpdate Then Exit Sub

        ' Establish Reconnect if needed
        If Not TestConnection() Then Exit Sub

        checkStudentAttendance()
        updateOrgAttendees()
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

            Dim command As New MySqlCommand("select * from tblstudent where dstudentid = @ID;", conn)
            command.Parameters.AddWithValue("@ID", txtStudentID.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Student not found
            If Not reader.Read() Then
                lblFullName.Text = String.Empty
                lblCourse.Text = String.Empty
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

        Const stTitle As String = "Time In/Out"

        ' Lock Button
        btnSubmit.Enabled = False

        ' Check if na update yung attendance ni student
        Threading.Thread.Sleep(Timer1.Interval / 2)
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
            Dim command As New MySqlCommand($"SELECT dcourse FROM tblstudent WHERE dstudentid IN (SELECT DISTINCT dstudentid FROM tblattendance 
            WHERE ttimein BETWEEN '{currentDate} 00:00:00' AND '{currentDate} 23:59:59' AND ttimeout IS NULL)
            ;", conn)
            Dim reader As MySqlDataReader
            reader = command.ExecuteReader()

            Dim ce, cps, iecep, iiee, lpies, lyco As Integer

            While reader.Read()
                ' Iterate through each course
                Select Case reader(0)
                    Case "BSCS"
                        cps += 1
                    Case "BSIT"
                        cps += 1
                    Case "BSIE"
                        lpies += 1
                    Case "BSEE"
                        iiee += 1
                    Case "BSCpE"
                        lyco += 1
                    Case "BSCE"
                        ce += 1
                    Case "BSECE"
                        iecep += 1
                End Select
            End While

            ' Update labels
            lblCE.Text = ce
            lblCPS.Text = cps
            lblIECEP.Text = iecep
            lblIIEE.Text = iiee
            lblLPIES.Text = lpies
            lblLYCO.Text = lyco
            lblTotal.Text = $"Total Current Attendees: {ce + cps + iecep + iiee + lpies + lyco}"
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

    Private Function getAttendanceID() As String
        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()

            Dim command As New MySqlCommand($"select max(ttimein) from tblattendance where dstudentid = '{stStudentID}' and ttimeout is null;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                Dim timeIn As DateTime = reader(0)
                Return timeIn.ToString("hh:mm:ss tt")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Return Nothing
    End Function

    Private Sub picCE_Click(sender As Object, e As EventArgs) Handles picCE.Click
        openOrgForm("CE")
    End Sub

    Private Sub picCPS_Click(sender As Object, e As EventArgs) Handles picCPS.Click
        openOrgForm("CPS")
    End Sub

    Private Sub picIECEP_Click(sender As Object, e As EventArgs) Handles picIECEP.Click
        openOrgForm("IECEP")
    End Sub

    Private Sub picIIEE_Click(sender As Object, e As EventArgs) Handles picIIEE.Click
        openOrgForm("IIEE")
    End Sub

    Private Sub picLPIES_Click(sender As Object, e As EventArgs) Handles picLPIES.Click
        openOrgForm("LPIES")
    End Sub

    Private Sub picLYCO_Click(sender As Object, e As EventArgs) Handles picLYCO.Click
        openOrgForm("LYCO")
    End Sub

    Private Sub openOrgForm(org As String)
        frmOrganization.stOrg = org
        frmOrganization.Show(Me)
        Me.Hide()
    End Sub

    ' ADMIN LOGIN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

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
        Dim conn As New MySqlConnection(stConnection)
        Try
            conn.Open()
            bUpdate = True
            btnReconnect.Enabled = False
            btnReconnect.BackColor = greenColor
            MessageBox.Show("Reconnected.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to Reconnect.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
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
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub
End Class
