Imports MySql.Data.MySqlClient

Partial Public Class frmAdmin
    Private Sub cboDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboViewDept.SelectedIndexChanged
        Dim conn As New MySqlConnection(stConnection)

        Try
            conn.Open()
            ' TODO - Update the sql query
            Dim stDate As String = Date.Now.ToString("yyyy-MM-dd")
            Dim command As New MySqlCommand($"SELECT DISTINCT dstudentid AS 'Student ID', dfullname AS 'Full Name', dcourse AS 'Course', dyearlevel AS 'Year Level'
            FROM tblstudent WHERE dstudentid IN (SELECT dstudentid FROM tblattendance WHERE ttimein BETWEEN '{stDate} 00:00:00' and '{stDate} 23:59:59' and ttimeout is null)
            AND dstudentid IN (SELECT dstudentid FROM tblstudent WHERE ddepartment = '{cboViewDept.SelectedItem}');", conn)
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
End Class
