﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        PictureBox8 = New PictureBox()
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
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
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
        TabControl1.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.ItemSize = New Size(108, 30)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1200, 550)
        TabControl1.TabIndex = 0
        ' 
        ' tabControl
        ' 
        tabControl.BackColor = Color.CornflowerBlue
        tabControl.BackgroundImage = CType(resources.GetObject("tabControl.BackgroundImage"), Image)
        tabControl.BackgroundImageLayout = ImageLayout.Stretch
        tabControl.Controls.Add(panControl)
        tabControl.Controls.Add(panSettings)
        tabControl.Location = New Point(4, 34)
        tabControl.Name = "tabControl"
        tabControl.Padding = New Padding(3)
        tabControl.Size = New Size(1192, 512)
        tabControl.TabIndex = 1
        tabControl.Text = "Control"
        ' 
        ' panControl
        ' 
        panControl.BackColor = Color.White
        panControl.Controls.Add(Label3)
        panControl.Location = New Point(492, 91)
        panControl.Name = "panControl"
        panControl.Size = New Size(251, 73)
        panControl.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(28, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(207, 36)
        Label3.TabIndex = 5
        Label3.Text = "Control Panel"
        ' 
        ' panSettings
        ' 
        panSettings.BackColor = Color.WhiteSmoke
        panSettings.Controls.Add(GroupBox1)
        panSettings.Location = New Point(325, 185)
        panSettings.Name = "panSettings"
        panSettings.Size = New Size(543, 574)
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
        GroupBox1.Location = New Point(44, 39)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(454, 496)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Time In / Out"
        ' 
        ' btnResetSettings
        ' 
        btnResetSettings.BackColor = Color.Silver
        btnResetSettings.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnResetSettings.Location = New Point(248, 436)
        btnResetSettings.Name = "btnResetSettings"
        btnResetSettings.Size = New Size(128, 44)
        btnResetSettings.TabIndex = 10
        btnResetSettings.Text = "Reset"
        btnResetSettings.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightGreen
        btnSave.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Location = New Point(48, 436)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(159, 44)
        btnSave.TabIndex = 9
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.Top
        lblMessage.AutoSize = True
        lblMessage.Font = New Font("Baskerville Old Face", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        lblMessage.Location = New Point(336, 244)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(40, 16)
        lblMessage.TabIndex = 8
        lblMessage.Text = "0 / 40"
        ' 
        ' rtfMessage
        ' 
        rtfMessage.Font = New Font("Century", 14.1F, FontStyle.Regular, GraphicsUnit.Point)
        rtfMessage.Location = New Point(83, 160)
        rtfMessage.MaxLength = 40
        rtfMessage.Name = "rtfMessage"
        rtfMessage.Size = New Size(294, 83)
        rtfMessage.TabIndex = 7
        rtfMessage.Text = "Please wait for the admin to come back."
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(72, 354)
        Label4.Name = "Label4"
        Label4.Size = New Size(300, 18)
        Label4.TabIndex = 6
        Label4.Text = "Forces to time out all the attendance for today."
        ' 
        ' chkTimeIn
        ' 
        chkTimeIn.AutoSize = True
        chkTimeIn.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        chkTimeIn.Location = New Point(141, 120)
        chkTimeIn.Name = "chkTimeIn"
        chkTimeIn.Size = New Size(170, 29)
        chkTimeIn.TabIndex = 0
        chkTimeIn.Text = "Enable Time In"
        chkTimeIn.UseVisualStyleBackColor = True
        ' 
        ' btnForce
        ' 
        btnForce.BackColor = Color.LightCoral
        btnForce.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnForce.Location = New Point(133, 374)
        btnForce.Name = "btnForce"
        btnForce.Size = New Size(171, 40)
        btnForce.TabIndex = 4
        btnForce.Text = "Force Time Out"
        btnForce.UseVisualStyleBackColor = False
        ' 
        ' tabData
        ' 
        tabData.BackColor = Color.CornflowerBlue
        tabData.BackgroundImage = CType(resources.GetObject("tabData.BackgroundImage"), Image)
        tabData.BackgroundImageLayout = ImageLayout.Stretch
        tabData.Controls.Add(panTitle)
        tabData.Controls.Add(panGrid)
        tabData.Controls.Add(panFilter)
        tabData.Location = New Point(4, 34)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(1192, 512)
        tabData.TabIndex = 0
        tabData.Text = "Export"
        ' 
        ' panTitle
        ' 
        panTitle.BackColor = Color.White
        panTitle.Controls.Add(Label2)
        panTitle.Location = New Point(467, 46)
        panTitle.Name = "panTitle"
        panTitle.Size = New Size(264, 89)
        panTitle.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(13, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(243, 36)
        Label2.TabIndex = 4
        Label2.Text = "Attendance Logs"
        ' 
        ' panGrid
        ' 
        panGrid.BackColor = Color.White
        panGrid.Controls.Add(grdAttendance)
        panGrid.Location = New Point(489, 205)
        panGrid.Name = "panGrid"
        panGrid.Size = New Size(706, 588)
        panGrid.TabIndex = 1
        ' 
        ' grdAttendance
        ' 
        grdAttendance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        grdAttendance.BackgroundColor = Color.White
        grdAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdAttendance.Location = New Point(27, 26)
        grdAttendance.Name = "grdAttendance"
        grdAttendance.ReadOnly = True
        grdAttendance.RowHeadersWidth = 51
        grdAttendance.RowTemplate.Height = 25
        grdAttendance.Size = New Size(660, 537)
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
        panFilter.Controls.Add(PictureBox8)
        panFilter.Controls.Add(PictureBox7)
        panFilter.Location = New Point(11, 205)
        panFilter.Name = "panFilter"
        panFilter.Size = New Size(451, 588)
        panFilter.TabIndex = 0
        ' 
        ' cboYear
        ' 
        cboYear.DropDownStyle = ComboBoxStyle.DropDownList
        cboYear.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        cboYear.FormattingEnabled = True
        cboYear.Items.AddRange(New Object() {"YEAR - ALL", "1", "2", "3", "4"})
        cboYear.Location = New Point(103, 300)
        cboYear.Name = "cboYear"
        cboYear.Size = New Size(245, 31)
        cboYear.TabIndex = 3
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ScrollBar
        btnReset.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(281, 457)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(67, 40)
        btnReset.TabIndex = 7
        btnReset.TabStop = False
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.LightGreen
        btnExport.Enabled = False
        btnExport.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnExport.Location = New Point(103, 508)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(245, 40)
        btnExport.TabIndex = 8
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.CornflowerBlue
        btnSearch.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.Location = New Point(103, 457)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(172, 40)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(210, 380)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 23)
        Label1.TabIndex = 19
        Label1.Text = "to"
        ' 
        ' dtpTo
        ' 
        dtpTo.CustomFormat = "MMMM dd, yyyy"
        dtpTo.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.Location = New Point(103, 406)
        dtpTo.MaxDate = New DateTime(2024, 10, 31, 0, 0, 0, 0)
        dtpTo.MinDate = New DateTime(2023, 5, 1, 0, 0, 0, 0)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(245, 30)
        dtpTo.TabIndex = 5
        dtpTo.Value = New DateTime(2023, 6, 1, 0, 0, 0, 0)
        ' 
        ' dtpFrom
        ' 
        dtpFrom.CustomFormat = "MMMM dd, yyyy"
        dtpFrom.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.Location = New Point(103, 349)
        dtpFrom.MaxDate = New DateTime(2024, 10, 31, 0, 0, 0, 0)
        dtpFrom.MinDate = New DateTime(2023, 5, 1, 0, 0, 0, 0)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(245, 30)
        dtpFrom.TabIndex = 4
        dtpFrom.Value = New DateTime(2023, 6, 1, 0, 0, 0, 0)
        ' 
        ' cboDepartment
        ' 
        cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboDepartment.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        cboDepartment.FormattingEnabled = True
        cboDepartment.Items.AddRange(New Object() {"Department  - ALL"})
        cboDepartment.Location = New Point(103, 252)
        cboDepartment.Name = "cboDepartment"
        cboDepartment.Size = New Size(245, 31)
        cboDepartment.TabIndex = 2
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Anchor = AnchorStyles.Top
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(233, 35)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(150, 150)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 15
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(67, 35)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(150, 150)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        ' 
        ' tabAddUser
        ' 
        tabAddUser.BackgroundImage = CType(resources.GetObject("tabAddUser.BackgroundImage"), Image)
        tabAddUser.BackgroundImageLayout = ImageLayout.Stretch
        tabAddUser.Controls.Add(panAddUser)
        tabAddUser.Location = New Point(4, 34)
        tabAddUser.Name = "tabAddUser"
        tabAddUser.Padding = New Padding(3)
        tabAddUser.Size = New Size(1192, 512)
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
        panAddUser.Location = New Point(398, 105)
        panAddUser.Name = "panAddUser"
        panAddUser.Size = New Size(459, 576)
        panAddUser.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Baskerville Old Face", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(75, 290)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 14)
        Label9.TabIndex = 28
        Label9.Text = "(Surmane, First name)"
        ' 
        ' cboStudentCourse
        ' 
        cboStudentCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentCourse.Enabled = False
        cboStudentCourse.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentCourse.FormattingEnabled = True
        cboStudentCourse.Location = New Point(76, 463)
        cboStudentCourse.Name = "cboStudentCourse"
        cboStudentCourse.Size = New Size(224, 31)
        cboStudentCourse.TabIndex = 4
        ' 
        ' cboStudentYear
        ' 
        cboStudentYear.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentYear.Enabled = False
        cboStudentYear.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentYear.FormattingEnabled = True
        cboStudentYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cboStudentYear.Location = New Point(312, 463)
        cboStudentYear.Name = "cboStudentYear"
        cboStudentYear.Size = New Size(62, 31)
        cboStudentYear.TabIndex = 5
        ' 
        ' txtFullName
        ' 
        txtFullName.CharacterCasing = CharacterCasing.Upper
        txtFullName.Enabled = False
        txtFullName.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        txtFullName.Location = New Point(76, 313)
        txtFullName.MaxLength = 50
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "DELA CRUZ, JUAN"
        txtFullName.Size = New Size(298, 30)
        txtFullName.TabIndex = 2
        ' 
        ' cboStudentDepartment
        ' 
        cboStudentDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentDepartment.Enabled = False
        cboStudentDepartment.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        cboStudentDepartment.FormattingEnabled = True
        cboStudentDepartment.Items.AddRange(New Object() {"All"})
        cboStudentDepartment.Location = New Point(76, 386)
        cboStudentDepartment.Name = "cboStudentDepartment"
        cboStudentDepartment.Size = New Size(298, 31)
        cboStudentDepartment.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(75, 356)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 25)
        Label5.TabIndex = 27
        Label5.Text = "Department:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(312, 432)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 25)
        Label6.TabIndex = 25
        Label6.Text = "Year:"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDepartment.Location = New Point(76, 420)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(0, 25)
        lblDepartment.TabIndex = 21
        ' 
        ' lblTimeIn
        ' 
        lblTimeIn.AutoSize = True
        lblTimeIn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTimeIn.Location = New Point(76, 480)
        lblTimeIn.Name = "lblTimeIn"
        lblTimeIn.Size = New Size(0, 25)
        lblTimeIn.TabIndex = 19
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.Location = New Point(76, 360)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(0, 25)
        lblCourse.TabIndex = 17
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.Location = New Point(76, 300)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(0, 25)
        lblFullName.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(79, 433)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 25)
        Label8.TabIndex = 15
        Label8.Text = "Course:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(76, 268)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 25)
        Label7.TabIndex = 14
        Label7.Text = "Full Name:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(156, 30)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 114)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' btnAddUser
        ' 
        btnAddUser.BackColor = Color.LightGreen
        btnAddUser.Enabled = False
        btnAddUser.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddUser.Location = New Point(136, 506)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(163, 40)
        btnAddUser.TabIndex = 6
        btnAddUser.Text = "Add Student"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.BackColor = Color.Transparent
        lblStudent.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudent.Location = New Point(75, 196)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(165, 25)
        lblStudent.TabIndex = 1
        lblStudent.Text = "Student Number:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Century", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(76, 228)
        txtStudentID.MaxLength = 10
        txtStudentID.Name = "txtStudentID"
        txtStudentID.PlaceholderText = "1234-12345"
        txtStudentID.Size = New Size(298, 30)
        txtStudentID.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.LightCoral
        btnClose.Font = New Font("Baskerville Old Face", 9.857143F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(1122, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(80, 30)
        btnClose.TabIndex = 2
        btnClose.TabStop = False
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' frmAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 550)
        Controls.Add(btnClose)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
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
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox8 As PictureBox
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
