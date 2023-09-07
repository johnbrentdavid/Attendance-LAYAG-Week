Imports MySql.Data.MySqlClient

Public Class frmOrganization
    Public stOrg As String
    Public stCourse1 As String
    Public stCourse2 As String

    Private Sub frmOrganization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim logo As Image = Nothing
        Dim stFullName As String = "LPU"

        Select Case stOrg
            Case "CPS"
                logo = frmAttendance.picCPS.Image
                stFullName = "College of Arts and Sciences"
            Case "IECEP"
                logo = frmAttendance.picIECEP.Image
                stFullName = "College of Business and Accountancy"
            Case "IIEE"
                logo = frmAttendance.picIIEE.Image
                stFullName = "College of International Tourism and Hospitality Management"
            Case "LPIES"
                logo = frmAttendance.picLPIES.Image
                stFullName = "College of Engineering and Computer Studies"
            Case "CE"
                logo = frmAttendance.picCE.Image
                stFullName = "LPU St. Cabrini"
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
            Dim command As New MySqlCommand($"SELECT DISTINCT dstudentid AS 'Student ID', dfullname AS 'Full Name', dcourse AS 'Course', dyearlevel AS 'Year Level'
            FROM tblstudent WHERE dstudentid IN (SELECT dstudentid FROM tblattendance WHERE ttimein BETWEEN '{stDate} 00:00:00' and '{stDate} 23:59:59' and ttimeout is null)
            AND dstudentid IN (SELECT dstudentid FROM tblstudent WHERE dcourse = '{stCourse1}' OR dcourse = '{stCourse2}');", conn)
            Dim dataset As New DataSet
            Dim adapter As New MySqlDataAdapter With {
                .SelectCommand = command
            }
            adapter.Fill(dataset, "Attendees")

            grdAttendance.DataSource = dataset.Tables("Attendees")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Organization Attendees", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Prompt if they really want to close
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Organization Attendees", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Close if yes
        If result = DialogResult.Yes Then
            frmAttendance.Show()
            Me.Close()
        End If
    End Sub
End Class