Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmOrganization
    Public stOrg As String

    Private Sub frmOrganization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim logo As Image = Nothing
        Dim stFullName As String = "LPU"

        Select Case stOrg
            Case "CPS"
                logo = frmAttendance.picCPS.Image
                stFullName = "Computer Programming Society"
            Case "IECEP"
                logo = frmAttendance.picIECEP.Image
                stFullName = "Institute of Electronics Engineers of the Philippines"
            Case "IIEE"
                logo = frmAttendance.picIIEE.Image
                stFullName = "Institute of Integrated Electrical Engineers"
            Case "LPIES"
                logo = frmAttendance.picLPIES.Image
                stFullName = "Lyceum of the Philippines - Laguna Industrial Engineering Society"
            Case "LYCO-CpE"
                logo = frmAttendance.picLYCO.Image
                stFullName = "Lycean’s Coalition of Computer Engineers"
            Case "CE"
                logo = frmAttendance.picCE.Image
                stFullName = "Philippine Institute of Civil Engineers"
        End Select

        ' Place proper Logo and Org name
        picOrg.Image = logo
        lblOrg.Text = stFullName

        ' Re allign Title
        Dim x, y As Double
        x = (frmAttendance.Size.Width / 2) - (panOrg.Size.Width / 2)
        y = (frmAttendance.Size.Height * 0.2) - (panOrg.Size.Height / 2)
        panOrg.Location = New Point(x, y)

        y = (panOrg.Size.Height / 2) - (lblOrg.Size.Height / 2)
        lblOrg.Location = New Point(lblOrg.Location.X, y)

        ' Center Datagrid Panel
        x = (frmAttendance.Size.Width / 2) - (panAttendees.Size.Width / 2)
        y = (frmAttendance.Size.Height * 0.6) - (panAttendees.Size.Height / 2)
        panAttendees.Location = New Point(x, y)

        ' Update Attendees
        refreshAttendees()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshAttendees()
    End Sub

    Private Sub refreshAttendees()
        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()

            Dim stDate As String = Date.Now.ToString("yyyy-MM-dd")
            Dim command As New MySqlCommand($"SELECT dstudentid AS 'Student ID', dfullname AS 'Full Name', dcourse AS 'Course', dyearlevel AS 'Year Level'
            FROM tblstudent WHERE dstudentid IN (SELECT dstudentid FROM tblattendance WHERE ttimein BETWEEN '{stDate} 00:00:00' and '{stDate} 23:59:59' and ttimeout is null);", conn)
            Dim dataset As New DataSet
            Dim adapter As New MySqlDataAdapter With {
                .SelectCommand = command
            }
            adapter.Fill(dataset, "Attendees")

            grdAttendance.DataSource = dataset.Tables("Attendees")
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Prompt if they really want to close
        Dim result = MsgBox("Are you sure you want to exit?", vbYesNo, "Attendance")

        ' Close if yes
        If result = vbYes Then
            frmAttendance.Show()
            Me.Close()
        End If
    End Sub
End Class