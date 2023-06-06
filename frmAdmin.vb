Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAdmin

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

        ' Center Title Panel
        xCenter = (tabData.Size.Width / 2) - (panTitle.Size.Width / 2)
        yCenter = (tabData.Size.Height * 0.1) - (panTitle.Size.Height / 2)
        panTitle.Location = New Point(xCenter, yCenter)

        resetValues()

        ' End of code about Export

        ' Start of code about Control

        ' Control Panel
        xCenter = (tabControl.Size.Width / 2) - (panControl.Size.Width / 2)
        yCenter = (tabControl.Size.Height * 0.1) - (panControl.Size.Height / 2)
        panControl.Location = New Point(xCenter, yCenter)

        ' Settings
        xCenter = (tabControl.Size.Width / 2) - (panSettings.Size.Width / 2)
        yCenter = (tabControl.Size.Height / 2) - (panSettings.Size.Height / 2)
        panSettings.Location = New Point(xCenter, yCenter)

        resetSettings()

        ' End of code about Control
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
        Dim query As String = $"select idtblattendance as 'Attendance ID', ttimein as 'Time In', ttimeout as 'Time Out', tblstudent.dstudentid as 'Student ID', 
        dfullname as 'Full Name', dcourse as 'Course', dyearlevel as 'Year Level'
        from tblattendance natural join tblstudent where tblattendance.ttimein between '{dtpFrom.Value.Date:yyyy-MM-dd} 00:00:00' and '{dtpTo.Value.Date:yyyy-MM-dd} 23:59:59'"
        'and tblattendance.ttimeout between '{dtpFrom.Value.Date:yyyy-MM-dd} 00:00:00' and '{dtpTo.Value.Date:yyyy-MM-dd} 23:59:59'"

        ' If not all student org
        If cboOrg.SelectedIndex > 0 Then

            Dim org As String = ""

            Select Case cboOrg.Text
                Case "CPS"
                    org = "('BSCS', 'BSIT')"
                Case "IECEP"
                    org = "('BSECE')"
                Case "IIEE"
                    org = "('BSEE')"
                Case "LPIES"
                    org = "('BSIE')"
                Case "LYCO-CpE"
                    org = "('BSCpE')"
                Case "PICE"
                    org = "('BSCE')"
            End Select

            query += $" and tblstudent.dcourse in {org}"
        End If

        ' if not all year
        If cboYear.SelectedIndex > 0 Then
            query += $" and tblstudent.dyearlevel = '{cboYear.Text}'"
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
        cboOrg.SelectedIndex = 0
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
            Directory.CreateDirectory(path & "\COECS WEEK ATTENDANCE LOGS")
            path += "\COECS WEEK ATTENDANCE LOGS"
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
                    If i = table.Columns.IndexOf("dfullname") Then
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
            where ttimein between '{DateTime.Now:yyyy-MM-dd} 00:00:00' and '{DateTime.Now:yyyy-MM-dd} 23:59:59' and ttimeout is null;", conn)
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
            frmAttendance.TabControl1.SelectedIndex = 0
            frmAttendance.txtPassword.Text = ""
            frmAttendance.txtUsername.Text = ""
            frmAttendance.Show()
            Me.Close()
        End If
    End Sub
End Class