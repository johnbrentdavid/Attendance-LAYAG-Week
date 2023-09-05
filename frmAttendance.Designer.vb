<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAttendance))
        TabControl1 = New TabControl()
        tabAttendance = New TabPage()
        lblCopyright = New Label()
        lblTime = New Label()
        lblMessage = New Label()
        panLogos = New Panel()
        Label6 = New Label()
        lblTotal = New Label()
        lblLYCO = New Label()
        lblLPIES = New Label()
        lblIIEE = New Label()
        lblIECEP = New Label()
        lblCPS = New Label()
        lblCE = New Label()
        picLYCO = New PictureBox()
        picIIEE = New PictureBox()
        picLPIES = New PictureBox()
        picIECEP = New PictureBox()
        picCE = New PictureBox()
        picCPS = New PictureBox()
        panStudentID = New Panel()
        lblDepartment = New Label()
        Label5 = New Label()
        lblTimeIn = New Label()
        Label2 = New Label()
        lblCourse = New Label()
        lblFullName = New Label()
        Label8 = New Label()
        Label7 = New Label()
        PictureBox7 = New PictureBox()
        btnSubmit = New Button()
        lblStudent = New Label()
        txtStudentID = New TextBox()
        tabView = New TabPage()
        panLogin = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        txtPassword = New TextBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        btnLogin = New Button()
        Label1 = New Label()
        txtUsername = New TextBox()
        btnClose = New Button()
        tmrSlow = New Timer(components)
        btnReconnect = New Button()
        tmrFast = New Timer(components)
        TabControl1.SuspendLayout()
        tabAttendance.SuspendLayout()
        panLogos.SuspendLayout()
        CType(picLYCO, ComponentModel.ISupportInitialize).BeginInit()
        CType(picIIEE, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLPIES, ComponentModel.ISupportInitialize).BeginInit()
        CType(picIECEP, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCE, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCPS, ComponentModel.ISupportInitialize).BeginInit()
        panStudentID.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        tabView.SuspendLayout()
        panLogin.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabAttendance)
        TabControl1.Controls.Add(tabView)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.ItemSize = New Size(108, 30)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(5, 6, 5, 6)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(2057, 1650)
        TabControl1.TabIndex = 0
        ' 
        ' tabAttendance
        ' 
        tabAttendance.BackColor = Color.CornflowerBlue
        tabAttendance.BackgroundImage = My.Resources.Resources.Main_Background
        tabAttendance.BackgroundImageLayout = ImageLayout.Stretch
        tabAttendance.Controls.Add(lblCopyright)
        tabAttendance.Controls.Add(lblTime)
        tabAttendance.Controls.Add(lblMessage)
        tabAttendance.Controls.Add(panLogos)
        tabAttendance.Controls.Add(panStudentID)
        tabAttendance.Location = New Point(4, 34)
        tabAttendance.Margin = New Padding(5, 6, 5, 6)
        tabAttendance.Name = "tabAttendance"
        tabAttendance.Padding = New Padding(5, 6, 5, 6)
        tabAttendance.Size = New Size(2049, 1612)
        tabAttendance.TabIndex = 0
        tabAttendance.Text = "Attendance"
        ' 
        ' lblCopyright
        ' 
        lblCopyright.Anchor = AnchorStyles.Bottom
        lblCopyright.AutoSize = True
        lblCopyright.BackColor = Color.Transparent
        lblCopyright.BorderStyle = BorderStyle.FixedSingle
        lblCopyright.Font = New Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point)
        lblCopyright.Location = New Point(564, 1531)
        lblCopyright.Margin = New Padding(5, 0, 5, 0)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(867, 50)
        lblCopyright.TabIndex = 8
        lblCopyright.Text = "Copyright 2023 | Computer Programming Society"
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top
        lblTime.AutoSize = True
        lblTime.BackColor = Color.White
        lblTime.BorderStyle = BorderStyle.FixedSingle
        lblTime.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTime.Location = New Point(934, 128)
        lblTime.Margin = New Padding(5, 0, 5, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(179, 89)
        lblTime.TabIndex = 4
        lblTime.Text = "Time"
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.Bottom
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.WhiteSmoke
        lblMessage.BorderStyle = BorderStyle.Fixed3D
        lblMessage.FlatStyle = FlatStyle.Flat
        lblMessage.Font = New Font("Lucida Bright", 27.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        lblMessage.Location = New Point(390, 1444)
        lblMessage.Margin = New Padding(5, 0, 5, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(1340, 77)
        lblMessage.TabIndex = 7
        lblMessage.Text = "Please wait for the admin to come back."
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' panLogos
        ' 
        panLogos.BackColor = Color.White
        panLogos.BorderStyle = BorderStyle.Fixed3D
        panLogos.Controls.Add(Label6)
        panLogos.Controls.Add(lblTotal)
        panLogos.Controls.Add(lblLYCO)
        panLogos.Controls.Add(lblLPIES)
        panLogos.Controls.Add(lblIIEE)
        panLogos.Controls.Add(lblIECEP)
        panLogos.Controls.Add(lblCPS)
        panLogos.Controls.Add(lblCE)
        panLogos.Controls.Add(picLYCO)
        panLogos.Controls.Add(picIIEE)
        panLogos.Controls.Add(picLPIES)
        panLogos.Controls.Add(picIECEP)
        panLogos.Controls.Add(picCE)
        panLogos.Controls.Add(picCPS)
        panLogos.Location = New Point(902, 316)
        panLogos.Margin = New Padding(5, 6, 5, 6)
        panLogos.Name = "panLogos"
        panLogos.Size = New Size(1058, 1172)
        panLogos.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Britannic Bold", 26.1428585F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(217, 457)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(609, 68)
        Label6.TabIndex = 21
        Label6.Text = """LAYAG PIRATA 2023"""
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(41, 1080)
        lblTotal.Margin = New Padding(5, 0, 5, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(498, 48)
        lblTotal.TabIndex = 12
        lblTotal.Text = "Total Current Attendees: 0"
        lblTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLYCO
        ' 
        lblLYCO.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblLYCO.AutoSize = True
        lblLYCO.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblLYCO.Location = New Point(866, 917)
        lblLYCO.Margin = New Padding(5, 0, 5, 0)
        lblLYCO.Name = "lblLYCO"
        lblLYCO.Size = New Size(42, 48)
        lblLYCO.TabIndex = 11
        lblLYCO.Text = "0"
        lblLYCO.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLPIES
        ' 
        lblLPIES.Anchor = AnchorStyles.Bottom
        lblLPIES.AutoSize = True
        lblLPIES.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblLPIES.Location = New Point(511, 919)
        lblLPIES.Margin = New Padding(5, 0, 5, 0)
        lblLPIES.Name = "lblLPIES"
        lblLPIES.Size = New Size(42, 48)
        lblLPIES.TabIndex = 10
        lblLPIES.Text = "0"
        lblLPIES.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIIEE
        ' 
        lblIIEE.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblIIEE.AutoSize = True
        lblIIEE.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblIIEE.Location = New Point(151, 918)
        lblIIEE.Margin = New Padding(5, 0, 5, 0)
        lblIIEE.Name = "lblIIEE"
        lblIIEE.Size = New Size(42, 48)
        lblIIEE.TabIndex = 9
        lblIIEE.Text = "0"
        lblIIEE.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIECEP
        ' 
        lblIECEP.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblIECEP.AutoSize = True
        lblIECEP.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblIECEP.Location = New Point(866, 349)
        lblIECEP.Margin = New Padding(5, 0, 5, 0)
        lblIECEP.Name = "lblIECEP"
        lblIECEP.Size = New Size(42, 48)
        lblIECEP.TabIndex = 8
        lblIECEP.Text = "0"
        lblIECEP.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCPS
        ' 
        lblCPS.Anchor = AnchorStyles.Top
        lblCPS.AutoSize = True
        lblCPS.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblCPS.Location = New Point(511, 350)
        lblCPS.Margin = New Padding(5, 0, 5, 0)
        lblCPS.Name = "lblCPS"
        lblCPS.Size = New Size(42, 48)
        lblCPS.TabIndex = 7
        lblCPS.Text = "0"
        lblCPS.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCE
        ' 
        lblCE.AutoSize = True
        lblCE.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblCE.Location = New Point(151, 349)
        lblCE.Margin = New Padding(5, 0, 5, 0)
        lblCE.Name = "lblCE"
        lblCE.Size = New Size(42, 48)
        lblCE.TabIndex = 6
        lblCE.Text = "0"
        lblCE.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLYCO
        ' 
        picLYCO.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        picLYCO.Image = CType(resources.GetObject("picLYCO.Image"), Image)
        picLYCO.Location = New Point(756, 608)
        picLYCO.Margin = New Padding(5, 6, 5, 6)
        picLYCO.Name = "picLYCO"
        picLYCO.Size = New Size(257, 300)
        picLYCO.SizeMode = PictureBoxSizeMode.StretchImage
        picLYCO.TabIndex = 5
        picLYCO.TabStop = False
        ' 
        ' picIIEE
        ' 
        picIIEE.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        picIIEE.Image = CType(resources.GetObject("picIIEE.Image"), Image)
        picIIEE.Location = New Point(41, 608)
        picIIEE.Margin = New Padding(5, 6, 5, 6)
        picIIEE.Name = "picIIEE"
        picIIEE.Size = New Size(257, 300)
        picIIEE.SizeMode = PictureBoxSizeMode.StretchImage
        picIIEE.TabIndex = 4
        picIIEE.TabStop = False
        ' 
        ' picLPIES
        ' 
        picLPIES.Anchor = AnchorStyles.Bottom
        picLPIES.Image = CType(resources.GetObject("picLPIES.Image"), Image)
        picLPIES.Location = New Point(401, 608)
        picLPIES.Margin = New Padding(5, 6, 5, 6)
        picLPIES.Name = "picLPIES"
        picLPIES.Size = New Size(257, 300)
        picLPIES.SizeMode = PictureBoxSizeMode.StretchImage
        picLPIES.TabIndex = 3
        picLPIES.TabStop = False
        ' 
        ' picIECEP
        ' 
        picIECEP.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picIECEP.Image = CType(resources.GetObject("picIECEP.Image"), Image)
        picIECEP.Location = New Point(756, 38)
        picIECEP.Margin = New Padding(5, 6, 5, 6)
        picIECEP.Name = "picIECEP"
        picIECEP.Size = New Size(257, 300)
        picIECEP.SizeMode = PictureBoxSizeMode.StretchImage
        picIECEP.TabIndex = 2
        picIECEP.TabStop = False
        ' 
        ' picCE
        ' 
        picCE.Image = CType(resources.GetObject("picCE.Image"), Image)
        picCE.Location = New Point(41, 38)
        picCE.Margin = New Padding(5, 6, 5, 6)
        picCE.Name = "picCE"
        picCE.Size = New Size(257, 300)
        picCE.SizeMode = PictureBoxSizeMode.StretchImage
        picCE.TabIndex = 1
        picCE.TabStop = False
        ' 
        ' picCPS
        ' 
        picCPS.Anchor = AnchorStyles.Top
        picCPS.Image = CType(resources.GetObject("picCPS.Image"), Image)
        picCPS.Location = New Point(401, 38)
        picCPS.Margin = New Padding(5, 6, 5, 6)
        picCPS.Name = "picCPS"
        picCPS.Size = New Size(257, 300)
        picCPS.SizeMode = PictureBoxSizeMode.StretchImage
        picCPS.TabIndex = 0
        picCPS.TabStop = False
        ' 
        ' panStudentID
        ' 
        panStudentID.BackColor = Color.White
        panStudentID.BorderStyle = BorderStyle.Fixed3D
        panStudentID.Controls.Add(lblDepartment)
        panStudentID.Controls.Add(Label5)
        panStudentID.Controls.Add(lblTimeIn)
        panStudentID.Controls.Add(Label2)
        panStudentID.Controls.Add(lblCourse)
        panStudentID.Controls.Add(lblFullName)
        panStudentID.Controls.Add(Label8)
        panStudentID.Controls.Add(Label7)
        panStudentID.Controls.Add(PictureBox7)
        panStudentID.Controls.Add(btnSubmit)
        panStudentID.Controls.Add(lblStudent)
        panStudentID.Controls.Add(txtStudentID)
        panStudentID.Location = New Point(82, 316)
        panStudentID.Margin = New Padding(5, 6, 5, 6)
        panStudentID.Name = "panStudentID"
        panStudentID.Size = New Size(770, 1172)
        panStudentID.TabIndex = 2
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDepartment.Location = New Point(130, 840)
        lblDepartment.Margin = New Padding(5, 0, 5, 0)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(0, 46)
        lblDepartment.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(130, 797)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(208, 43)
        Label5.TabIndex = 20
        Label5.Text = "Department:"
        ' 
        ' lblTimeIn
        ' 
        lblTimeIn.AutoSize = True
        lblTimeIn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTimeIn.Location = New Point(130, 960)
        lblTimeIn.Margin = New Padding(5, 0, 5, 0)
        lblTimeIn.Name = "lblTimeIn"
        lblTimeIn.Size = New Size(0, 46)
        lblTimeIn.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(130, 917)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 43)
        Label2.TabIndex = 18
        Label2.Text = "Time-In:"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.Location = New Point(130, 720)
        lblCourse.Margin = New Padding(5, 0, 5, 0)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(0, 46)
        lblCourse.TabIndex = 17
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.Location = New Point(130, 600)
        lblFullName.Margin = New Padding(5, 0, 5, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(0, 46)
        lblFullName.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(130, 677)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(231, 43)
        Label8.TabIndex = 15
        Label8.Text = "Course - Year:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(130, 557)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(185, 43)
        Label7.TabIndex = 14
        Label7.Text = "Full Name:"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(261, 52)
        PictureBox7.Margin = New Padding(5, 6, 5, 6)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(257, 234)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 12
        PictureBox7.TabStop = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DarkGray
        btnSubmit.Enabled = False
        btnSubmit.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.Location = New Point(180, 1050)
        btnSubmit.Margin = New Padding(5, 6, 5, 6)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(413, 80)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "Time In/Out"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Font = New Font("Baskerville Old Face", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudent.Location = New Point(130, 394)
        lblStudent.Margin = New Padding(5, 0, 5, 0)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(276, 43)
        lblStudent.TabIndex = 1
        lblStudent.Text = "Student Number:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Enabled = False
        txtStudentID.Font = New Font("Baskerville Old Face", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(130, 467)
        txtStudentID.Margin = New Padding(5, 6, 5, 6)
        txtStudentID.MaxLength = 10
        txtStudentID.Name = "txtStudentID"
        txtStudentID.PlaceholderText = "1234-12345"
        txtStudentID.Size = New Size(508, 45)
        txtStudentID.TabIndex = 0
        ' 
        ' tabView
        ' 
        tabView.BackColor = Color.CornflowerBlue
        tabView.BackgroundImage = CType(resources.GetObject("tabView.BackgroundImage"), Image)
        tabView.BackgroundImageLayout = ImageLayout.Stretch
        tabView.Controls.Add(panLogin)
        tabView.Location = New Point(4, 34)
        tabView.Margin = New Padding(5, 6, 5, 6)
        tabView.Name = "tabView"
        tabView.Padding = New Padding(5, 6, 5, 6)
        tabView.Size = New Size(2049, 1612)
        tabView.TabIndex = 1
        tabView.Text = "View"
        ' 
        ' panLogin
        ' 
        panLogin.BackColor = Color.White
        panLogin.Controls.Add(Label4)
        panLogin.Controls.Add(Label3)
        panLogin.Controls.Add(txtPassword)
        panLogin.Controls.Add(PictureBox9)
        panLogin.Controls.Add(PictureBox10)
        panLogin.Controls.Add(btnLogin)
        panLogin.Controls.Add(Label1)
        panLogin.Controls.Add(txtUsername)
        panLogin.Location = New Point(663, 310)
        panLogin.Margin = New Padding(5, 6, 5, 6)
        panLogin.Name = "panLogin"
        panLogin.Size = New Size(773, 1176)
        panLogin.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(242, 442)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(298, 65)
        Label4.TabIndex = 21
        Label4.Text = "Admin Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(130, 794)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 46)
        Label3.TabIndex = 20
        Label3.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Wingdings", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(130, 850)
        txtPassword.Margin = New Padding(5, 6, 5, 6)
        txtPassword.MaxLength = 20
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "l"c
        txtPassword.Size = New Size(508, 44)
        txtPassword.TabIndex = 2
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.Top
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(399, 70)
        PictureBox9.Margin = New Padding(5, 6, 5, 6)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(257, 300)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 18
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Anchor = AnchorStyles.Top
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(115, 70)
        PictureBox10.Margin = New Padding(5, 6, 5, 6)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(257, 300)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 17
        PictureBox10.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ScrollBar
        btnLogin.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(180, 988)
        btnLogin.Margin = New Padding(5, 6, 5, 6)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(413, 80)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(130, 596)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 46)
        Label1.TabIndex = 16
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtUsername.Location = New Point(130, 652)
        txtUsername.Margin = New Padding(5, 6, 5, 6)
        txtUsername.MaxLength = 20
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(508, 52)
        txtUsername.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(1932, 0)
        btnClose.Margin = New Padding(5, 6, 5, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(129, 46)
        btnClose.TabIndex = 1
        btnClose.TabStop = False
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' tmrSlow
        ' 
        tmrSlow.Interval = 1000
        ' 
        ' btnReconnect
        ' 
        btnReconnect.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnReconnect.BackColor = Color.FromArgb(CByte(3), CByte(252), CByte(15))
        btnReconnect.Enabled = False
        btnReconnect.FlatAppearance.BorderSize = 0
        btnReconnect.FlatStyle = FlatStyle.Flat
        btnReconnect.Location = New Point(1793, 0)
        btnReconnect.Margin = New Padding(5, 6, 5, 6)
        btnReconnect.Name = "btnReconnect"
        btnReconnect.Size = New Size(129, 46)
        btnReconnect.TabIndex = 2
        btnReconnect.TabStop = False
        btnReconnect.Text = "Status"
        btnReconnect.UseVisualStyleBackColor = False
        ' 
        ' tmrFast
        ' 
        ' 
        ' frmAttendance
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2057, 1650)
        Controls.Add(btnClose)
        Controls.Add(btnReconnect)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 6, 5, 6)
        Name = "frmAttendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        tabAttendance.ResumeLayout(False)
        tabAttendance.PerformLayout()
        panLogos.ResumeLayout(False)
        panLogos.PerformLayout()
        CType(picLYCO, ComponentModel.ISupportInitialize).EndInit()
        CType(picIIEE, ComponentModel.ISupportInitialize).EndInit()
        CType(picLPIES, ComponentModel.ISupportInitialize).EndInit()
        CType(picIECEP, ComponentModel.ISupportInitialize).EndInit()
        CType(picCE, ComponentModel.ISupportInitialize).EndInit()
        CType(picCPS, ComponentModel.ISupportInitialize).EndInit()
        panStudentID.ResumeLayout(False)
        panStudentID.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        tabView.ResumeLayout(False)
        panLogin.ResumeLayout(False)
        panLogin.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabAttendance As TabPage
    Friend WithEvents tabView As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents lblStudent As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents panStudentID As Panel
    Friend WithEvents btnSubmit As Button
    Friend WithEvents picIECEP As PictureBox
    Friend WithEvents picCE As PictureBox
    Friend WithEvents picCPS As PictureBox
    Friend WithEvents panLogos As Panel
    Friend WithEvents lblLYCO As Label
    Friend WithEvents lblLPIES As Label
    Friend WithEvents lblIIEE As Label
    Friend WithEvents lblIECEP As Label
    Friend WithEvents lblCPS As Label
    Friend WithEvents lblCE As Label
    Friend WithEvents picLYCO As PictureBox
    Friend WithEvents picIIEE As PictureBox
    Friend WithEvents picLPIES As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents tmrSlow As Timer
    Friend WithEvents lblTimeIn As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents panLogin As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReconnect As Button
    Friend WithEvents tmrFast As Timer
    Friend WithEvents lblMessage As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Label5 As Label
End Class
