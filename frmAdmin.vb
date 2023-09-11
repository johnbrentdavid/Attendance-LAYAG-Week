Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Partial Public Class frmAdmin

    Private fromValue As DateTime
    Private ToValue As DateTime

    Private isLoaded As Boolean = False

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Start of code about Export
        isLoaded = True

        ' Center the Filter Panel
        Dim xCenter As Double = (tabData.Size.Width * 0.2) - (panFilter.Size.Width / 2)
        Dim yCenter As Double = (tabData.Size.Height / 2) - (panFilter.Size.Height / 2)
        panFilter.Location = New Point(xCenter, yCenter)

        ' Center the Grid Panel
        Dim temp As Double = tabData.Size.Width * 0.4
        xCenter = (temp + (tabData.Size.Width - temp) / 2) - (panGrid.Size.Width / 2)
        yCenter = (tabData.Size.Height / 2) - (panGrid.Size.Height / 2)
        panGrid.Location = New Point(xCenter, yCenter)

        '' Center Title Panel
        xCenter = (tabData.Size.Width / 2) - (panTitle.Size.Width / 2)
        yCenter = panTitle.Location.Y
        panTitle.Location = New Point(xCenter, yCenter)

        resetValues()

        ' End of code about Export

        ' Start of code about Control

        ' Control Panel
        xCenter = (tabControl.Size.Width / 2) - (panControl.Size.Width / 2)
        yCenter = panControl.Location.Y
        panControl.Location = New Point(xCenter, yCenter)

        ' Settings
        xCenter = (tabControl.Size.Width / 2) - (panSettings.Size.Width / 2)
        yCenter = (tabControl.Size.Height / 2) - (panSettings.Size.Height / 2)
        panSettings.Location = New Point(xCenter, yCenter)

        resetSettings()

        ' End of code about Control

        'Start of code about Add User
        xCenter = (tabAddUser.Size.Width / 2) - (panAddUser.Size.Width / 2)
        yCenter = (tabAddUser.Size.Height / 2) - (panAddUser.Size.Height / 2)
        panAddUser.Location = New Point(xCenter, yCenter)

        getDepartment(cboStudentDepartment)
        getDepartment(cboDepartment)
        getDepartment(cboViewDept)
        'End of code about Add User

    End Sub

    'Private Sub cboOrg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrg.SelectedIndexChanged
    '    If cboOrg.SelectedIndex > 0 Then
    '        cboYear.Enabled = True
    '        checkCboYear()
    '    Else
    '        cboYear.Enabled = False
    '        dtpFrom.Enabled = False
    '        dtpTo.Enabled = False
    '        btnSearch.Enabled = False
    '        btnSearch.BackColor = grayColor
    '    End If
    'End Sub

    'Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
    '    checkCboYear()
    'End Sub

    'Private Sub checkCboYear()
    '    If cboYear.SelectedIndex > 0 Then
    '        dtpFrom.Enabled = True
    '        dtpTo.Enabled = True
    '        btnSearch.Enabled = True
    '        btnSearch.BackColor = blueColor
    '    Else
    '        dtpFrom.Enabled = False
    '        dtpTo.Enabled = False
    '        btnSearch.Enabled = False
    '        btnSearch.BackColor = grayColor
    '    End If
    'End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        checkDate(fromValue, dtpFrom)
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        checkDate(ToValue, dtpTo)
    End Sub

    Private Sub checkDate(ByRef placeholder As DateTime, dtp As DateTimePicker)
        If dtpFrom.Value <= dtpTo.Value Then
            placeholder = dtp.Value
        Else
            If isLoaded Then
                dtp.Value = placeholder
            Else
                dtp.Value = dtp.MinDate
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        ' Build the query string
        Dim query As String = $"Select idtblattendance as 'Attendance ID', ttimein as 'Time In', ttimeout as 'Time Out', tblstudent.dstudentid as 'Student ID', 
                                dfullname as 'Full Name', dcourse as 'Course',ddepartment as 'Department', dyearlevel as 'Year Level' 
                                from tblattendance inner join tblstudent on tblattendance.dstudentid = tblstudent.dstudentid
                                where ttimein between '{dtpFrom.Value.Date:yyyy-MM-dd} 00:00:00' and '{dtpTo.Value.Date:yyyy-MM-dd} 23:59:59'"

        ' If not all student org
        If cboDepartment.SelectedIndex > 0 Then
            query += $" and ddepartment = '{cboDepartment.Text}'"
        End If

        ' if not all year
        If cboYear.SelectedIndex > 0 Then
            query += $" and dyearlevel = '{cboYear.Text}' "
        End If

        query += ";"

        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()

            Dim command As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter
            Dim dataset As New DataSet

            adapter.SelectCommand = command
            adapter.Fill(dataset, "Attendance")

            grdAttendance.DataSource = dataset.Tables("Attendance")

            If grdAttendance.RowCount > 1 Then
                btnExport.Enabled = True
                btnExport.BackColor = blueColor
            Else
                btnExport.Enabled = False
                btnExport.BackColor = grayColor
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetValues()
    End Sub

    Private Sub resetValues()
        cboDepartment.SelectedIndex = 0
        cboYear.SelectedIndex = 0

        If DateTime.Now.Date < dtpFrom.Value Then
            dtpFrom.Value = DateTime.Now.Date
            dtpTo.Value = DateTime.Now.Date
        Else
            dtpTo.Value = DateTime.Now.Date
            dtpFrom.Value = DateTime.Now.Date
        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        btnExport.Enabled = False

        Dim stTitle As String = "Export"

        ' File path to user desktop
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim filename As String = "\Attendance Logs as of " & Year(Now()) & Month(Now()) & Second(Now()) & ".csv"
        Dim table As DataTable = grdAttendance.DataSource

        ' Create the folder if not existing
        Try
            Directory.CreateDirectory(path & "\ATTENDANCE LOGS")
            path += "\ATTENDANCE LOGS"
        Catch ex As Exception
            MessageBox.Show(ex.Message, stTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Create csv file
        Using writer As New System.IO.StreamWriter(path + filename)

            For Each column As DataColumn In table.Columns
                writer.Write(column.ColumnName)
                writer.Write(",")
            Next

            writer.WriteLine()

            For Each row As DataRow In table.Rows
                For i As Integer = 0 To table.Columns.Count - 1

                    ' If column dfullname
                    If i = table.Columns.IndexOf("Full Name") Then
                        writer.Write($"""{row(i)}""")
                    Else
                        writer.Write(row(i).ToString())
                    End If

                    writer.Write(",")
                Next

                writer.WriteLine()
            Next
        End Using

        ' Open folder
        Process.Start("explorer.exe", path)

        ' Success Message
        MessageBox.Show($"File has been saved.{vbCrLf}File name {filename}", stTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnExport.Enabled = True
    End Sub

    Private Sub chkTimeIn_CheckedChanged(sender As Object, e As EventArgs) Handles chkTimeIn.CheckedChanged
        changeBtnSave()
    End Sub

    Private Sub rtfMessage_TextChanged(sender As Object, e As EventArgs) Handles rtfMessage.TextChanged
        changeBtnSave()

        ' Update message length
        lblMessage.Text = $"{rtfMessage.Text.Length} / {rtfMessage.MaxLength}"
    End Sub

    Private Sub changeBtnSave()
        If frmAttendance.txtStudentID.Enabled = chkTimeIn.Checked And frmAttendance.lblMessage.Text = rtfMessage.Text Then
            btnSave.Enabled = False
            btnSave.BackColor = grayColor
        Else
            btnSave.Enabled = True
            btnSave.BackColor = blueColor
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim result = MessageBox.Show("Are you sure you want to save changes?", "Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then Exit Sub

        ' Enable / Disable student id text box
        frmAttendance.txtStudentID.Enabled = chkTimeIn.Checked
        frmAttendance.lblMessage.Visible = Not chkTimeIn.Checked

        ' Update message
        frmAttendance.lblMessage.Text = rtfMessage.Text

        If Not chkTimeIn.Checked Then
            frmAttendance.txtStudentID.Text = String.Empty
        End If

        changeBtnSave()
    End Sub

    Private Sub btnResetSettings_Click(sender As Object, e As EventArgs) Handles btnResetSettings.Click
        resetSettings()
    End Sub

    Private Sub resetSettings()
        ' Check if can time in
        chkTimeIn.Checked = frmAttendance.txtStudentID.Enabled

        ' Update message text
        rtfMessage.Text = frmAttendance.lblMessage.Text
    End Sub

    Private Sub btnForce_Click(sender As Object, e As EventArgs) Handles btnForce.Click

        ' Prompt if they really want to close
        Dim stTitle As String = "Force Timeout"
        Dim result = MessageBox.Show("Are you sure you want to force time out all attendance?", stTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Close if yes
        If result = DialogResult.No Then Exit Sub

        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()

            Dim command As New MySqlCommand($"update tblattendance set ttimeout = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}' 
            where ttimeout is null;", conn)
            command.ExecuteNonQuery()

            ' Either reset the txtbox which is easier or reload the query which is better
            frmAttendance.checkStudentAttendance()
        Catch ex As Exception
            MessageBox.Show(ex.Message, stTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Prompt if they really want to close
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Close if yes
        If result = DialogResult.Yes Then

            Me.Close()
        End If
    End Sub

    'CODE FOR ADD STUDENT
    Private Sub getDepartment(cboBox As ComboBox)
        Dim conn As New MySqlConnection(stConnection)
        Try
            conn.Open()
            Dim command As New MySqlCommand($"SELECT distinct(ddepartment) FROM tblstudent;", conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                cboBox.Items.Add(reader(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub getCourse()
        Dim conn As New MySqlConnection(stConnection)
        Dim query As String
        If cboStudentDepartment.SelectedIndex = 0 Then
            query = $"Select dcourse from tblprogram;"
        Else
            query = $"Select dcourse from tblprogram where ddepartment='{cboStudentDepartment.Text}';"
        End If
        Try
            conn.Open()
            Dim command As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                cboStudentCourse.Items.Add(reader(0)).ToString()
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub insertUser()
        Dim conn As New MySqlConnection(stConnection)
        If Not isExisting() Then
            Try
                conn.Open()
                Dim command As New MySqlCommand($"insert into tblstudent (dstudentid,dfullname,dcourse,dyearlevel) values (@ID ,@FULLNAME ,'{cboStudentCourse.Text}','{cboStudentYear.Text}');", conn)
                command.Parameters.AddWithValue("@ID", txtStudentID.Text)
                command.Parameters.AddWithValue("@FULLNAME", txtFullName.Text)
                command.ExecuteNonQuery()

                timeInUser()
                MessageBox.Show("Succesfully Added and Timed In the User!")
                resetAddUser()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        Else
            Exit Sub
        End If

    End Sub

    Private Function isExisting()
        Dim conn As New MySqlConnection(stConnection)
        Try
            conn.Open()
            Dim command As New MySqlCommand($"Select dstudentid,dfullname from tblstudent where dstudentid = @ID or dfullname= @FULLNAME", conn)
            command.Parameters.AddWithValue("@ID", txtStudentID.Text)
            command.Parameters.AddWithValue("@FULLNAME", txtFullName.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.HasRows() Then
                While reader.Read()
                    MessageBox.Show($"Existing Data Found: ID={reader(0)} Name={reader(1)}")
                End While
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Existing Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            conn.Close()
        End Try

    End Function

    Private Sub timeInUser()
        Dim conn As New MySqlConnection(stConnection)
        Dim currentTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Try
            conn.Open()
            Dim command As New MySqlCommand($"Insert into tblattendance values (null, '{txtStudentID.Text}','{currentTime}',null);", conn)
            command.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub resetAddUser()
        txtStudentID.Text = ""
        txtFullName.Text = ""
        cboStudentDepartment.SelectedIndex = -1
        cboStudentYear.SelectedIndex = -1
        cboStudentCourse.SelectedIndex = -1
        cboStudentDepartment.SelectedIndex = -1
        cboStudentDepartment.Enabled = False
        cboStudentCourse.Enabled = False
        cboStudentYear.Enabled = False
    End Sub

    Private Sub cboStudentDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentDepartment.SelectedIndexChanged
        If Not cboStudentDepartment.SelectedIndex = -1 Then
            cboStudentCourse.Enabled = True
            cboStudentCourse.SelectedIndex = -1
            cboStudentCourse.Items.Clear()
            getCourse()
        End If
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        Dim regexPattern As String = "^\d{4}-\d{5}$"
        If txtStudentID.TextLength = 10 And Regex.IsMatch(txtStudentID.Text.ToString(), regexPattern) Then
            txtFullName.Enabled = True
        Else
            txtFullName.Enabled = False
            cboStudentDepartment.Enabled = False
            cboStudentCourse.Enabled = False
            cboStudentYear.Enabled = False
            btnAddUser.Enabled = False
            btnAddUser.BackColor = Color.FromName("Gray")
        End If
    End Sub

    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        Dim regexPattern As String = "\w+,\s\w+"
        If Regex.IsMatch(txtFullName.Text.ToString(), regexPattern) Then
            cboStudentDepartment.Enabled = True
        Else
            cboStudentDepartment.Enabled = False
            cboStudentCourse.Enabled = False
            cboStudentYear.Enabled = False
            btnAddUser.Enabled = False
            btnAddUser.BackColor = Color.FromName("Gray")
        End If
    End Sub

    Private Sub textBox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFullName.KeyDown, txtStudentID.KeyDown
        'There is a a sound beep though when this event is handled
        If e.Control AndAlso e.KeyCode = Keys.A Then
            e.Handled = True
            DirectCast(sender, TextBox).SelectAll()
        End If
    End Sub

    Private Sub cboStudentCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentCourse.SelectedIndexChanged
        If Not cboStudentCourse.SelectedIndex = -1 Then
            cboStudentYear.Enabled = True
        Else
            cboStudentYear.Enabled = False
            cboStudentYear.SelectedIndex = -1
            btnAddUser.Enabled = False
            btnAddUser.BackColor = Color.FromName("Gray")
        End If
    End Sub

    Private Sub cboStudentYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentYear.SelectedIndexChanged
        If Not cboStudentYear.SelectedIndex = -1 Then
            btnAddUser.Enabled = True
            btnAddUser.BackColor = Color.FromName("Goldenrod")
        End If

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If cboStudentYear.Enabled = True And Not cboStudentYear.SelectedIndex = -1 Then
            insertUser()
        End If
    End Sub

    '
    ' View Attendance
    '
    Private Sub cboDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboViewDept.SelectedIndexChanged
        GetCurrentAttendance()
    End Sub

    Private Sub RefreshView_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetCurrentAttendance()
    End Sub

    Private Sub GetCurrentAttendance()
        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()
            ' TODO - Update the sql query
            Dim stDate As String = Date.Now.ToString("yyyy-MM-dd")
            Dim command As New MySqlCommand($"SELECT idtblattendance AS 'Attendance ID', ttimein AS 'Time In', tblstudent.dstudentid AS 'Student ID', dfullname AS 'Full Name', dcourse AS 'Course', dyearlevel AS 'Year Level'
                                            FROM tblattendance inner join tblstudent on tblattendance.dstudentid = tblstudent.dstudentid
                                            WHERE ddepartment = '{cboViewDept.SelectedItem}' and ttimein between '{stDate} 00:00:00' and '{stDate} 23:59:59' and ttimeout is null;", conn)
            Dim dataset As New DataSet
            Dim adapter As New MySqlDataAdapter With {
                .SelectCommand = command
            }
            adapter.Fill(dataset, "Attendees")

            grdCurrentAttendance.DataSource = dataset.Tables("Attendees")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Organization Attendees", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub frmAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmAttendance.TabControl1.SelectedIndex = 0
        frmAttendance.txtPassword.Text = ""
        frmAttendance.txtUsername.Text = ""
        frmAttendance.Show()
    End Sub
End Class