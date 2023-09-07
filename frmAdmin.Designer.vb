<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        TabControl1 = New TabControl()
        tabControl = New TabPage()
        panControl = New Panel()
        Label3 = New Label()
        panSettings = New Panel()
        GroupBox1 = New GroupBox()
        btnResetSettings = New Button()
        btnSave = New Button()
        lblMessage = New Label()
        rtfMessage = New RichTextBox()
        Label4 = New Label()
        chkTimeIn = New CheckBox()
        btnForce = New Button()
        tabData = New TabPage()
        panTitle = New Panel()
        Label2 = New Label()
        panGrid = New Panel()
        grdAttendance = New DataGridView()
        panFilter = New Panel()
        cboYear = New ComboBox()
        btnReset = New Button()
        btnExport = New Button()
        btnSearch = New Button()
        Label1 = New Label()
        dtpTo = New DateTimePicker()
        dtpFrom = New DateTimePicker()
        cboDepartment = New ComboBox()
        PictureBox7 = New PictureBox()
        tabAddUser = New TabPage()
        panAddUser = New Panel()
        Label9 = New Label()
        cboStudentCourse = New ComboBox()
        cboStudentYear = New ComboBox()
        txtFullName = New TextBox()
        cboStudentDepartment = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        lblDepartment = New Label()
        lblTimeIn = New Label()
        lblCourse = New Label()
        lblFullName = New Label()
        Label8 = New Label()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        btnAddUser = New Button()
        lblStudent = New Label()
        txtStudentID = New TextBox()
        btnClose = New Button()
        TabControl1.SuspendLayout()
        tabControl.SuspendLayout()
        panControl.SuspendLayout()
        panSettings.SuspendLayout()
        GroupBox1.SuspendLayout()
        tabData.SuspendLayout()
        panTitle.SuspendLayout()
        panGrid.SuspendLayout()
        CType(grdAttendance, ComponentModel.ISupportInitialize).BeginInit()
        panFilter.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        tabAddUser.SuspendLayout()
        panAddUser.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabControl)
        TabControl1.Controls.Add(tabData)
        TabControl1.Controls.Add(tabAddUser)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.ItemSize = New Size(108, 30)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(6)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(2230, 1468)
        TabControl1.TabIndex = 0
        ' 
        ' tabControl
        ' 
        tabControl.BackColor = Color.CornflowerBlue
        tabControl.BackgroundImage = My.Resources.Resources.campus
        tabControl.BackgroundImageLayout = ImageLayout.Stretch
        tabControl.Controls.Add(panControl)
        tabControl.Controls.Add(panSettings)
        tabControl.Location = New Point(8, 38)
        tabControl.Margin = New Padding(6)
        tabControl.Name = "tabControl"
        tabControl.Padding = New Padding(6)
        tabControl.Size = New Size(2214, 1422)
        tabControl.TabIndex = 1
        tabControl.Text = "Control"
        ' 
        ' panControl
        ' 
        panControl.BackColor = Color.White
        panControl.Controls.Add(Label3)
        panControl.Location = New Point(965, 132)
        panControl.Margin = New Padding(6)
        panControl.Name = "panControl"
        panControl.Size = New Size(465, 111)
        panControl.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(29, 17)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(443, 86)
        Label3.TabIndex = 5
        Label3.Text = "Control Panel"
        ' 
        ' panSettings
        ' 
        panSettings.BackColor = Color.WhiteSmoke
        panSettings.Controls.Add(GroupBox1)
        panSettings.Location = New Point(783, 306)
        panSettings.Margin = New Padding(6)
        panSettings.Name = "panSettings"
        panSettings.Size = New Size(919, 1089)
        panSettings.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnResetSettings)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(lblMessage)
        GroupBox1.Controls.Add(rtfMessage)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(chkTimeIn)
        GroupBox1.Controls.Add(btnForce)
        GroupBox1.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(68, 70)
        GroupBox1.Margin = New Padding(6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(6)
        GroupBox1.Size = New Size(777, 936)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Time In / Out"
        ' 
        ' btnResetSettings
        ' 
        btnResetSettings.BackColor = Color.Silver
        btnResetSettings.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnResetSettings.Location = New Point(429, 767)
        btnResetSettings.Margin = New Padding(6)
        btnResetSettings.Name = "btnResetSettings"
        btnResetSettings.Size = New Size(238, 93)
        btnResetSettings.TabIndex = 10
        btnResetSettings.Text = "Reset"
        btnResetSettings.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Silver
        btnSave.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Location = New Point(108, 767)
        btnSave.Margin = New Padding(6)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(295, 93)
        btnSave.TabIndex = 9
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.Top
        lblMessage.AutoSize = True
        lblMessage.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        lblMessage.Location = New Point(588, 434)
        lblMessage.Margin = New Padding(6, 0, 6, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(87, 37)
        lblMessage.TabIndex = 8
        lblMessage.Text = "0 / 40"
        ' 
        ' rtfMessage
        ' 
        rtfMessage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rtfMessage.Location = New Point(120, 257)
        rtfMessage.Margin = New Padding(6)
        rtfMessage.MaxLength = 40
        rtfMessage.Name = "rtfMessage"
        rtfMessage.Size = New Size(559, 173)
        rtfMessage.TabIndex = 7
        rtfMessage.Text = "Please wait for the admin to come back."
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(101, 628)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(571, 37)
        Label4.TabIndex = 6
        Label4.Text = "Forces to time out all the attendance for today."
        ' 
        ' chkTimeIn
        ' 
        chkTimeIn.AutoSize = True
        chkTimeIn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkTimeIn.Location = New Point(268, 182)
        chkTimeIn.Margin = New Padding(6)
        chkTimeIn.Name = "chkTimeIn"
        chkTimeIn.Size = New Size(261, 49)
        chkTimeIn.TabIndex = 0
        chkTimeIn.Text = "Enable Time In"
        chkTimeIn.UseVisualStyleBackColor = True
        ' 
        ' btnForce
        ' 
        btnForce.BackColor = Color.LightCoral
        btnForce.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnForce.Location = New Point(238, 668)
        btnForce.Margin = New Padding(6)
        btnForce.Name = "btnForce"
        btnForce.Size = New Size(318, 86)
        btnForce.TabIndex = 4
        btnForce.Text = "Force Time Out"
        btnForce.UseVisualStyleBackColor = False
        ' 
        ' tabData
        ' 
        tabData.BackColor = Color.CornflowerBlue
        tabData.BackgroundImage = My.Resources.Resources.campus
        tabData.BackgroundImageLayout = ImageLayout.Stretch
        tabData.Controls.Add(panTitle)
        tabData.Controls.Add(panGrid)
        tabData.Controls.Add(panFilter)
        tabData.Location = New Point(8, 38)
        tabData.Margin = New Padding(6)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(6)
        tabData.Size = New Size(2214, 1422)
        tabData.TabIndex = 0
        tabData.Text = "Export"
        ' 
        ' panTitle
        ' 
        panTitle.BackColor = Color.White
        panTitle.Controls.Add(Label2)
        panTitle.Location = New Point(867, 99)
        panTitle.Margin = New Padding(6)
        panTitle.Name = "panTitle"
        panTitle.Size = New Size(585, 189)
        panTitle.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(29, 64)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(542, 86)
        Label2.TabIndex = 4
        Label2.Text = "Attendance Logs"
        ' 
        ' panGrid
        ' 
        panGrid.BackColor = Color.White
        panGrid.Controls.Add(grdAttendance)
        panGrid.Location = New Point(885, 462)
        panGrid.Margin = New Padding(6)
        panGrid.Name = "panGrid"
        panGrid.Size = New Size(1332, 1254)
        panGrid.TabIndex = 1
        ' 
        ' grdAttendance
        ' 
        grdAttendance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        grdAttendance.BackgroundColor = Color.White
        grdAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdAttendance.Location = New Point(49, 55)
        grdAttendance.Margin = New Padding(6)
        grdAttendance.Name = "grdAttendance"
        grdAttendance.ReadOnly = True
        grdAttendance.RowHeadersWidth = 51
        grdAttendance.RowTemplate.Height = 25
        grdAttendance.Size = New Size(1248, 1146)
        grdAttendance.TabIndex = 0
        grdAttendance.TabStop = False
        ' 
        ' panFilter
        ' 
        panFilter.BackColor = Color.White
        panFilter.Controls.Add(cboYear)
        panFilter.Controls.Add(btnReset)
        panFilter.Controls.Add(btnExport)
        panFilter.Controls.Add(btnSearch)
        panFilter.Controls.Add(Label1)
        panFilter.Controls.Add(dtpTo)
        panFilter.Controls.Add(dtpFrom)
        panFilter.Controls.Add(cboDepartment)
        panFilter.Controls.Add(PictureBox7)
        panFilter.Location = New Point(20, 461)
        panFilter.Margin = New Padding(6)
        panFilter.Name = "panFilter"
        panFilter.Size = New Size(838, 1254)
        panFilter.TabIndex = 0
        ' 
        ' cboYear
        ' 
        cboYear.DropDownStyle = ComboBoxStyle.DropDownList
        cboYear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboYear.FormattingEnabled = True
        cboYear.Items.AddRange(New Object() {"YEAR - ALL", "1", "2", "3", "4"})
        cboYear.Location = New Point(191, 622)
        cboYear.Margin = New Padding(6)
        cboYear.Name = "cboYear"
        cboYear.Size = New Size(452, 53)
        cboYear.TabIndex = 3
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ScrollBar
        btnReset.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(523, 975)
        btnReset.Margin = New Padding(6)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(123, 86)
        btnReset.TabIndex = 7
        btnReset.TabStop = False
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.Silver
        btnExport.Enabled = False
        btnExport.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnExport.Location = New Point(191, 1084)
        btnExport.Margin = New Padding(6)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(455, 86)
        btnExport.TabIndex = 8
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.CornflowerBlue
        btnSearch.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.Location = New Point(191, 975)
        btnSearch.Margin = New Padding(6)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(318, 86)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(390, 795)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 51)
        Label1.TabIndex = 19
        Label1.Text = "to"
        ' 
        ' dtpTo
        ' 
        dtpTo.CustomFormat = "MMMM dd, yyyy"
        dtpTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.Location = New Point(191, 854)
        dtpTo.Margin = New Padding(6)
        dtpTo.MaxDate = New Date(2024, 10, 31, 0, 0, 0, 0)
        dtpTo.MinDate = New Date(2023, 5, 1, 0, 0, 0, 0)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(452, 50)
        dtpTo.TabIndex = 5
        dtpTo.Value = New Date(2023, 6, 1, 0, 0, 0, 0)
        ' 
        ' dtpFrom
        ' 
        dtpFrom.CustomFormat = "MMMM dd, yyyy"
        dtpFrom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.Location = New Point(191, 727)
        dtpFrom.Margin = New Padding(6)
        dtpFrom.MaxDate = New Date(2024, 10, 31, 0, 0, 0, 0)
        dtpFrom.MinDate = New Date(2023, 5, 1, 0, 0, 0, 0)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(452, 50)
        dtpFrom.TabIndex = 4
        dtpFrom.Value = New Date(2023, 6, 1, 0, 0, 0, 0)
        ' 
        ' cboDepartment
        ' 
        cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboDepartment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboDepartment.FormattingEnabled = True
        cboDepartment.Items.AddRange(New Object() {"Department  - ALL"})
        cboDepartment.Location = New Point(191, 516)
        cboDepartment.Margin = New Padding(6)
        cboDepartment.Name = "cboDepartment"
        cboDepartment.Size = New Size(452, 53)
        cboDepartment.TabIndex = 2
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = My.Resources.Resources.LAYAG
        PictureBox7.Location = New Point(234, 72)
        PictureBox7.Margin = New Padding(6)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(356, 349)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        ' 
        ' tabAddUser
        ' 
        tabAddUser.BackgroundImage = My.Resources.Resources.campus
        tabAddUser.BackgroundImageLayout = ImageLayout.Stretch
        tabAddUser.Controls.Add(panAddUser)
        tabAddUser.Location = New Point(8, 38)
        tabAddUser.Margin = New Padding(6)
        tabAddUser.Name = "tabAddUser"
        tabAddUser.Padding = New Padding(6)
        tabAddUser.Size = New Size(2214, 1422)
        tabAddUser.TabIndex = 2
        tabAddUser.Text = "Add Student"
        tabAddUser.UseVisualStyleBackColor = True
        ' 
        ' panAddUser
        ' 
        panAddUser.BackColor = Color.WhiteSmoke
        panAddUser.BorderStyle = BorderStyle.Fixed3D
        panAddUser.Controls.Add(Label9)
        panAddUser.Controls.Add(cboStudentCourse)
        panAddUser.Controls.Add(cboStudentYear)
        panAddUser.Controls.Add(txtFullName)
        panAddUser.Controls.Add(cboStudentDepartment)
        panAddUser.Controls.Add(Label5)
        panAddUser.Controls.Add(Label6)
        panAddUser.Controls.Add(lblDepartment)
        panAddUser.Controls.Add(lblTimeIn)
        panAddUser.Controls.Add(lblCourse)
        panAddUser.Controls.Add(lblFullName)
        panAddUser.Controls.Add(Label8)
        panAddUser.Controls.Add(Label7)
        panAddUser.Controls.Add(PictureBox2)
        panAddUser.Controls.Add(btnAddUser)
        panAddUser.Controls.Add(lblStudent)
        panAddUser.Controls.Add(txtStudentID)
        panAddUser.Location = New Point(738, 224)
        panAddUser.Margin = New Padding(6)
        panAddUser.Name = "panAddUser"
        panAddUser.Size = New Size(849, 1224)
        panAddUser.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Baskerville Old Face", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(139, 620)
        Label9.Margin = New Padding(6, 0, 6, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(221, 27)
        Label9.TabIndex = 28
        Label9.Text = "(Surmane, First name)"
        ' 
        ' cboStudentCourse
        ' 
        cboStudentCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentCourse.Enabled = False
        cboStudentCourse.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentCourse.FormattingEnabled = True
        cboStudentCourse.Location = New Point(140, 988)
        cboStudentCourse.Margin = New Padding(6)
        cboStudentCourse.Name = "cboStudentCourse"
        cboStudentCourse.Size = New Size(414, 53)
        cboStudentCourse.TabIndex = 4
        ' 
        ' cboStudentYear
        ' 
        cboStudentYear.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentYear.Enabled = False
        cboStudentYear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentYear.FormattingEnabled = True
        cboStudentYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cboStudentYear.Location = New Point(578, 988)
        cboStudentYear.Margin = New Padding(6)
        cboStudentYear.Name = "cboStudentYear"
        cboStudentYear.Size = New Size(112, 53)
        cboStudentYear.TabIndex = 5
        ' 
        ' txtFullName
        ' 
        txtFullName.CharacterCasing = CharacterCasing.Upper
        txtFullName.Enabled = False
        txtFullName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtFullName.Location = New Point(140, 668)
        txtFullName.Margin = New Padding(6)
        txtFullName.MaxLength = 50
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "DELA CRUZ, JUAN"
        txtFullName.Size = New Size(550, 50)
        txtFullName.TabIndex = 2
        ' 
        ' cboStudentDepartment
        ' 
        cboStudentDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentDepartment.Enabled = False
        cboStudentDepartment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentDepartment.FormattingEnabled = True
        cboStudentDepartment.Items.AddRange(New Object() {"All"})
        cboStudentDepartment.Location = New Point(140, 823)
        cboStudentDepartment.Margin = New Padding(6)
        cboStudentDepartment.Name = "cboStudentDepartment"
        cboStudentDepartment.Size = New Size(550, 53)
        cboStudentDepartment.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(139, 759)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(227, 50)
        Label5.TabIndex = 27
        Label5.Text = "Department:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(578, 922)
        Label6.Margin = New Padding(6, 0, 6, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 50)
        Label6.TabIndex = 25
        Label6.Text = "Year:"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDepartment.Location = New Point(140, 896)
        lblDepartment.Margin = New Padding(6, 0, 6, 0)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(0, 51)
        lblDepartment.TabIndex = 21
        ' 
        ' lblTimeIn
        ' 
        lblTimeIn.AutoSize = True
        lblTimeIn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTimeIn.Location = New Point(140, 1024)
        lblTimeIn.Margin = New Padding(6, 0, 6, 0)
        lblTimeIn.Name = "lblTimeIn"
        lblTimeIn.Size = New Size(0, 51)
        lblTimeIn.TabIndex = 19
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.Location = New Point(140, 768)
        lblCourse.Margin = New Padding(6, 0, 6, 0)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(0, 51)
        lblCourse.TabIndex = 17
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.Location = New Point(140, 640)
        lblFullName.Margin = New Padding(6, 0, 6, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(0, 51)
        lblFullName.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(147, 924)
        Label8.Margin = New Padding(6, 0, 6, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(144, 50)
        Label8.TabIndex = 15
        Label8.Text = "Course:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(140, 572)
        Label7.Margin = New Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(195, 50)
        Label7.TabIndex = 14
        Label7.Text = "Full Name:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Image = My.Resources.Resources.LAYAG
        PictureBox2.Location = New Point(234, 50)
        PictureBox2.Margin = New Padding(6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(377, 328)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' btnAddUser
        ' 
        btnAddUser.BackColor = Color.Silver
        btnAddUser.Enabled = False
        btnAddUser.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddUser.Location = New Point(253, 1079)
        btnAddUser.Margin = New Padding(6)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(303, 86)
        btnAddUser.TabIndex = 6
        btnAddUser.Text = "Add Student"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.BackColor = Color.Transparent
        lblStudent.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudent.Location = New Point(139, 419)
        lblStudent.Margin = New Padding(6, 0, 6, 0)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(303, 50)
        lblStudent.TabIndex = 1
        lblStudent.Text = "Student Number:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(140, 486)
        txtStudentID.Margin = New Padding(6)
        txtStudentID.MaxLength = 10
        txtStudentID.Name = "txtStudentID"
        txtStudentID.PlaceholderText = "1234-12345"
        txtStudentID.Size = New Size(550, 50)
        txtStudentID.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.LightCoral
        btnClose.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(2084, 0)
        btnClose.Margin = New Padding(6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(150, 64)
        btnClose.TabIndex = 2
        btnClose.TabStop = False
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' frmAdmin
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2230, 1468)
        Controls.Add(btnClose)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(6)
        Name = "frmAdmin"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmAdmin"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        tabControl.ResumeLayout(False)
        panControl.ResumeLayout(False)
        panControl.PerformLayout()
        panSettings.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        tabData.ResumeLayout(False)
        panTitle.ResumeLayout(False)
        panTitle.PerformLayout()
        panGrid.ResumeLayout(False)
        CType(grdAttendance, ComponentModel.ISupportInitialize).EndInit()
        panFilter.ResumeLayout(False)
        panFilter.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        tabAddUser.ResumeLayout(False)
        panAddUser.ResumeLayout(False)
        panAddUser.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents tabControl As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents panFilter As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents panGrid As Panel
    Friend WithEvents grdAttendance As DataGridView
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents panTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents btnForce As Button
    Friend WithEvents panControl As Panel
    Friend WithEvents panSettings As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkTimeIn As CheckBox
    Friend WithEvents rtfMessage As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnResetSettings As Button
    Friend WithEvents tabAddUser As TabPage
    Friend WithEvents cboStudentYear As ComboBox
    Friend WithEvents panAddUser As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblTimeIn As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents lblStudent As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents cboStudentDepartment As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cboStudentCourse As ComboBox
    Friend WithEvents Label9 As Label
End Class
