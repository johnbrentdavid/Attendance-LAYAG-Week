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
        panLogos = New Panel()
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
        lblMessage = New Label()
        panTime = New Panel()
        lblTime = New Label()
        panStudentID = New Panel()
        lblTimeIn = New Label()
        Label2 = New Label()
        lblCourse = New Label()
        lblFullName = New Label()
        Label8 = New Label()
        Label7 = New Label()
        PictureBox8 = New PictureBox()
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
        Timer1 = New Timer(components)
        TabControl1.SuspendLayout()
        tabAttendance.SuspendLayout()
        panLogos.SuspendLayout()
        CType(picLYCO, ComponentModel.ISupportInitialize).BeginInit()
        CType(picIIEE, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLPIES, ComponentModel.ISupportInitialize).BeginInit()
        CType(picIECEP, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCE, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCPS, ComponentModel.ISupportInitialize).BeginInit()
        panTime.SuspendLayout()
        panStudentID.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
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
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1371, 1147)
        TabControl1.TabIndex = 0
        ' 
        ' tabAttendance
        ' 
        tabAttendance.BackColor = Color.CornflowerBlue
        tabAttendance.BackgroundImage = My.Resources.Resources.Main_Background
        tabAttendance.BackgroundImageLayout = ImageLayout.Stretch
        tabAttendance.Controls.Add(panLogos)
        tabAttendance.Controls.Add(lblMessage)
        tabAttendance.Controls.Add(panTime)
        tabAttendance.Controls.Add(panStudentID)
        tabAttendance.Location = New Point(4, 34)
        tabAttendance.Margin = New Padding(3, 4, 3, 4)
        tabAttendance.Name = "tabAttendance"
        tabAttendance.Padding = New Padding(3, 4, 3, 4)
        tabAttendance.Size = New Size(1363, 1109)
        tabAttendance.TabIndex = 0
        tabAttendance.Text = "Attendance"
        ' 
        ' panLogos
        ' 
        panLogos.BackColor = Color.White
        panLogos.BorderStyle = BorderStyle.FixedSingle
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
        panLogos.Location = New Point(601, 211)
        panLogos.Margin = New Padding(3, 4, 3, 4)
        panLogos.Name = "panLogos"
        panLogos.Size = New Size(707, 783)
        panLogos.TabIndex = 3
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(27, 723)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(314, 32)
        lblTotal.TabIndex = 12
        lblTotal.Text = "Total Current Attendees: 0"
        lblTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLYCO
        ' 
        lblLYCO.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblLYCO.AutoSize = True
        lblLYCO.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblLYCO.Location = New Point(579, 612)
        lblLYCO.Name = "lblLYCO"
        lblLYCO.Size = New Size(28, 32)
        lblLYCO.TabIndex = 11
        lblLYCO.Text = "0"
        lblLYCO.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLPIES
        ' 
        lblLPIES.Anchor = AnchorStyles.Bottom
        lblLPIES.AutoSize = True
        lblLPIES.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblLPIES.Location = New Point(342, 612)
        lblLPIES.Name = "lblLPIES"
        lblLPIES.Size = New Size(28, 32)
        lblLPIES.TabIndex = 10
        lblLPIES.Text = "0"
        lblLPIES.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIIEE
        ' 
        lblIIEE.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblIIEE.AutoSize = True
        lblIIEE.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblIIEE.Location = New Point(101, 612)
        lblIIEE.Name = "lblIIEE"
        lblIIEE.Size = New Size(28, 32)
        lblIIEE.TabIndex = 9
        lblIIEE.Text = "0"
        lblIIEE.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIECEP
        ' 
        lblIECEP.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblIECEP.AutoSize = True
        lblIECEP.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblIECEP.Location = New Point(579, 229)
        lblIECEP.Name = "lblIECEP"
        lblIECEP.Size = New Size(28, 32)
        lblIECEP.TabIndex = 8
        lblIECEP.Text = "0"
        lblIECEP.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCPS
        ' 
        lblCPS.Anchor = AnchorStyles.Top
        lblCPS.AutoSize = True
        lblCPS.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCPS.Location = New Point(342, 229)
        lblCPS.Name = "lblCPS"
        lblCPS.Size = New Size(28, 32)
        lblCPS.TabIndex = 7
        lblCPS.Text = "0"
        lblCPS.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCE
        ' 
        lblCE.AutoSize = True
        lblCE.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCE.Location = New Point(101, 229)
        lblCE.Name = "lblCE"
        lblCE.Size = New Size(28, 32)
        lblCE.TabIndex = 6
        lblCE.Text = "0"
        lblCE.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLYCO
        ' 
        picLYCO.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        picLYCO.Image = CType(resources.GetObject("picLYCO.Image"), Image)
        picLYCO.Location = New Point(506, 408)
        picLYCO.Margin = New Padding(3, 4, 3, 4)
        picLYCO.Name = "picLYCO"
        picLYCO.Size = New Size(171, 200)
        picLYCO.SizeMode = PictureBoxSizeMode.StretchImage
        picLYCO.TabIndex = 5
        picLYCO.TabStop = False
        ' 
        ' picIIEE
        ' 
        picIIEE.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        picIIEE.Image = CType(resources.GetObject("picIIEE.Image"), Image)
        picIIEE.Location = New Point(27, 408)
        picIIEE.Margin = New Padding(3, 4, 3, 4)
        picIIEE.Name = "picIIEE"
        picIIEE.Size = New Size(171, 200)
        picIIEE.SizeMode = PictureBoxSizeMode.StretchImage
        picIIEE.TabIndex = 4
        picIIEE.TabStop = False
        ' 
        ' picLPIES
        ' 
        picLPIES.Anchor = AnchorStyles.Bottom
        picLPIES.Image = CType(resources.GetObject("picLPIES.Image"), Image)
        picLPIES.Location = New Point(269, 408)
        picLPIES.Margin = New Padding(3, 4, 3, 4)
        picLPIES.Name = "picLPIES"
        picLPIES.Size = New Size(171, 200)
        picLPIES.SizeMode = PictureBoxSizeMode.StretchImage
        picLPIES.TabIndex = 3
        picLPIES.TabStop = False
        ' 
        ' picIECEP
        ' 
        picIECEP.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picIECEP.Image = CType(resources.GetObject("picIECEP.Image"), Image)
        picIECEP.Location = New Point(506, 25)
        picIECEP.Margin = New Padding(3, 4, 3, 4)
        picIECEP.Name = "picIECEP"
        picIECEP.Size = New Size(171, 200)
        picIECEP.SizeMode = PictureBoxSizeMode.StretchImage
        picIECEP.TabIndex = 2
        picIECEP.TabStop = False
        ' 
        ' picCE
        ' 
        picCE.Image = CType(resources.GetObject("picCE.Image"), Image)
        picCE.Location = New Point(27, 25)
        picCE.Margin = New Padding(3, 4, 3, 4)
        picCE.Name = "picCE"
        picCE.Size = New Size(171, 200)
        picCE.SizeMode = PictureBoxSizeMode.StretchImage
        picCE.TabIndex = 1
        picCE.TabStop = False
        ' 
        ' picCPS
        ' 
        picCPS.Anchor = AnchorStyles.Top
        picCPS.Image = CType(resources.GetObject("picCPS.Image"), Image)
        picCPS.Location = New Point(269, 25)
        picCPS.Margin = New Padding(3, 4, 3, 4)
        picCPS.Name = "picCPS"
        picCPS.Size = New Size(171, 200)
        picCPS.SizeMode = PictureBoxSizeMode.StretchImage
        picCPS.TabIndex = 0
        picCPS.TabStop = False
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.Top
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.White
        lblMessage.BorderStyle = BorderStyle.FixedSingle
        lblMessage.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblMessage.ForeColor = Color.Black
        lblMessage.Location = New Point(296, 1024)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(859, 64)
        lblMessage.TabIndex = 6
        lblMessage.Text = "Please wait for the admin to come back."
        ' 
        ' panTime
        ' 
        panTime.BackColor = Color.White
        panTime.BorderStyle = BorderStyle.FixedSingle
        panTime.Controls.Add(lblTime)
        panTime.Location = New Point(371, 60)
        panTime.Margin = New Padding(3, 4, 3, 4)
        panTime.Name = "panTime"
        panTime.Size = New Size(620, 118)
        panTime.TabIndex = 5
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTime.Location = New Point(251, 25)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(128, 62)
        lblTime.TabIndex = 4
        lblTime.Text = "Time"
        ' 
        ' panStudentID
        ' 
        panStudentID.BackColor = Color.White
        panStudentID.BorderStyle = BorderStyle.FixedSingle
        panStudentID.Controls.Add(lblTimeIn)
        panStudentID.Controls.Add(Label2)
        panStudentID.Controls.Add(lblCourse)
        panStudentID.Controls.Add(lblFullName)
        panStudentID.Controls.Add(Label8)
        panStudentID.Controls.Add(Label7)
        panStudentID.Controls.Add(PictureBox8)
        panStudentID.Controls.Add(PictureBox7)
        panStudentID.Controls.Add(btnSubmit)
        panStudentID.Controls.Add(lblStudent)
        panStudentID.Controls.Add(txtStudentID)
        panStudentID.Location = New Point(55, 211)
        panStudentID.Margin = New Padding(3, 4, 3, 4)
        panStudentID.Name = "panStudentID"
        panStudentID.Size = New Size(515, 783)
        panStudentID.TabIndex = 2
        ' 
        ' lblTimeIn
        ' 
        lblTimeIn.AutoSize = True
        lblTimeIn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTimeIn.Location = New Point(87, 628)
        lblTimeIn.Name = "lblTimeIn"
        lblTimeIn.Size = New Size(0, 32)
        lblTimeIn.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(87, 595)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 32)
        Label2.TabIndex = 18
        Label2.Text = "Time-In"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.Location = New Point(87, 532)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(0, 32)
        lblCourse.TabIndex = 17
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.Location = New Point(87, 436)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(0, 32)
        lblFullName.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(87, 496)
        Label8.Name = "Label8"
        Label8.Size = New Size(156, 32)
        Label8.TabIndex = 15
        Label8.Text = "Course - Year"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(87, 403)
        Label7.Name = "Label7"
        Label7.Size = New Size(123, 32)
        Label7.TabIndex = 14
        Label7.Text = "Full Name"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Anchor = AnchorStyles.Top
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(265, 47)
        PictureBox8.Margin = New Padding(3, 4, 3, 4)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(171, 200)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 13
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(75, 47)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(171, 200)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 12
        PictureBox7.TabStop = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ScrollBar
        btnSubmit.Enabled = False
        btnSubmit.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.Location = New Point(120, 700)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(275, 53)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "Time In/Out"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudent.Location = New Point(87, 285)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(141, 32)
        lblStudent.TabIndex = 1
        lblStudent.Text = "Student No."
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtStudentID.Location = New Point(87, 323)
        txtStudentID.Margin = New Padding(3, 4, 3, 4)
        txtStudentID.MaxLength = 10
        txtStudentID.Name = "txtStudentID"
        txtStudentID.PlaceholderText = "1234-12345"
        txtStudentID.Size = New Size(340, 39)
        txtStudentID.TabIndex = 0
        ' 
        ' tabView
        ' 
        tabView.BackColor = Color.CornflowerBlue
        tabView.BackgroundImage = CType(resources.GetObject("tabView.BackgroundImage"), Image)
        tabView.BackgroundImageLayout = ImageLayout.Stretch
        tabView.Controls.Add(panLogin)
        tabView.Location = New Point(4, 34)
        tabView.Margin = New Padding(3, 4, 3, 4)
        tabView.Name = "tabView"
        tabView.Padding = New Padding(3, 4, 3, 4)
        tabView.Size = New Size(1363, 1131)
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
        panLogin.Location = New Point(442, 207)
        panLogin.Margin = New Padding(3, 4, 3, 4)
        panLogin.Name = "panLogin"
        panLogin.Size = New Size(515, 784)
        panLogin.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(161, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(210, 46)
        Label4.TabIndex = 21
        Label4.Text = "Admin Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(87, 529)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 32)
        Label3.TabIndex = 20
        Label3.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Wingdings", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(87, 567)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.MaxLength = 20
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "l"c
        txtPassword.Size = New Size(340, 34)
        txtPassword.TabIndex = 1
        txtPassword.Text = "password123"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.Top
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(266, 47)
        PictureBox9.Margin = New Padding(3, 4, 3, 4)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(171, 200)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 18
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Anchor = AnchorStyles.Top
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(77, 47)
        PictureBox10.Margin = New Padding(3, 4, 3, 4)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(171, 200)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 17
        PictureBox10.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ScrollBar
        btnLogin.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(120, 659)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(275, 53)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(87, 397)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 32)
        Label1.TabIndex = 16
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtUsername.Location = New Point(87, 435)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.MaxLength = 20
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(340, 39)
        txtUsername.TabIndex = 0
        txtUsername.Text = "2020-10735"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(1288, 0)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(86, 31)
        btnClose.TabIndex = 1
        btnClose.TabStop = False
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' frmAttendance
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1371, 1147)
        Controls.Add(btnClose)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
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
        panTime.ResumeLayout(False)
        panTime.PerformLayout()
        panStudentID.ResumeLayout(False)
        panStudentID.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panTime As Panel
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
    Friend WithEvents lblMessage As Label
End Class
