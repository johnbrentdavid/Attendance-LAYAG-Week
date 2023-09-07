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
        lblLPIES = New Label()
        lblIIEE = New Label()
        lblIECEP = New Label()
        lblCPS = New Label()
        lblCE = New Label()
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
        CType(picIIEE, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLPIES, ComponentModel.ISupportInitialize).BeginInit()
        CType(picIECEP, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCE, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCPS, ComponentModel.ISupportInitialize).BeginInit()
        panStudentID.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        tabView.SuspendLayout()
        panLogin.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabAttendance)
        TabControl1.Controls.Add(tabView)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.ItemSize = New Size(108, 30)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(5, 6, 5, 6)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(2228, 1760)
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
        tabAttendance.Location = New Point(8, 38)
        tabAttendance.Margin = New Padding(5, 6, 5, 6)
        tabAttendance.Name = "tabAttendance"
        tabAttendance.Padding = New Padding(5, 6, 5, 6)
        tabAttendance.Size = New Size(2212, 1714)
        tabAttendance.TabIndex = 0
        tabAttendance.Text = "Attendance"
        ' 
        ' lblCopyright
        ' 
        lblCopyright.Anchor = AnchorStyles.Bottom
        lblCopyright.AutoSize = True
        lblCopyright.BackColor = Color.Transparent
        lblCopyright.Font = New Font("Times New Roman", 14.1428576F, FontStyle.Italic, GraphicsUnit.Point)
        lblCopyright.Location = New Point(1699, 1664)
        lblCopyright.Margin = New Padding(5, 0, 5, 0)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(782, 44)
        lblCopyright.TabIndex = 8
        lblCopyright.Text = "Copyright 2023 | Computer Programming Society"
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Segoe UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblTime.Location = New Point(1012, 137)
        lblTime.Margin = New Padding(5, 0, 5, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(199, 92)
        lblTime.TabIndex = 4
        lblTime.Text = "Time"
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.Bottom
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.WhiteSmoke
        lblMessage.FlatStyle = FlatStyle.Flat
        lblMessage.Font = New Font("Segoe UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblMessage.Location = New Point(457, 1611)
        lblMessage.Margin = New Padding(5, 0, 5, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(1337, 92)
        lblMessage.TabIndex = 7
        lblMessage.Text = "Please wait for the admin to come back."
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' panLogos
        ' 
        panLogos.BackColor = Color.WhiteSmoke
        panLogos.BorderStyle = BorderStyle.Fixed3D
        panLogos.Controls.Add(Label6)
        panLogos.Controls.Add(lblTotal)
        panLogos.Controls.Add(lblLPIES)
        panLogos.Controls.Add(lblIIEE)
        panLogos.Controls.Add(lblIECEP)
        panLogos.Controls.Add(lblCPS)
        panLogos.Controls.Add(lblCE)
        panLogos.Controls.Add(picIIEE)
        panLogos.Controls.Add(picLPIES)
        panLogos.Controls.Add(picIECEP)
        panLogos.Controls.Add(picCE)
        panLogos.Controls.Add(picCPS)
        panLogos.Location = New Point(977, 337)
        panLogos.Margin = New Padding(5, 6, 5, 6)
        panLogos.Name = "panLogos"
        panLogos.Size = New Size(1220, 1250)
        panLogos.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Britannic Bold", 26.1428585F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(278, 540)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(659, 78)
        Label6.TabIndex = 21
        Label6.Text = "LAYAG PIRATA 2023"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotal.Location = New Point(17, 1195)
        lblTotal.Margin = New Padding(5, 0, 5, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(348, 40)
        lblTotal.TabIndex = 12
        lblTotal.Text = "Total Current Attendees: 0"
        lblTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLPIES
        ' 
        lblLPIES.Anchor = AnchorStyles.Bottom
        lblLPIES.AutoSize = True
        lblLPIES.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblLPIES.Location = New Point(804, 1019)
        lblLPIES.Margin = New Padding(5, 0, 5, 0)
        lblLPIES.Name = "lblLPIES"
        lblLPIES.Size = New Size(43, 50)
        lblLPIES.TabIndex = 10
        lblLPIES.Text = "0"
        lblLPIES.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIIEE
        ' 
        lblIIEE.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblIIEE.AutoSize = True
        lblIIEE.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblIIEE.Location = New Point(378, 1018)
        lblIIEE.Margin = New Padding(5, 0, 5, 0)
        lblIIEE.Name = "lblIIEE"
        lblIIEE.Size = New Size(43, 50)
        lblIIEE.TabIndex = 9
        lblIIEE.Text = "0"
        lblIIEE.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIECEP
        ' 
        lblIECEP.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblIECEP.AutoSize = True
        lblIECEP.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblIECEP.Location = New Point(1011, 419)
        lblIECEP.Margin = New Padding(5, 0, 5, 0)
        lblIECEP.Name = "lblIECEP"
        lblIECEP.Size = New Size(43, 50)
        lblIECEP.TabIndex = 8
        lblIECEP.Text = "0"
        lblIECEP.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCPS
        ' 
        lblCPS.Anchor = AnchorStyles.Top
        lblCPS.AutoSize = True
        lblCPS.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblCPS.Location = New Point(589, 420)
        lblCPS.Margin = New Padding(5, 0, 5, 0)
        lblCPS.Name = "lblCPS"
        lblCPS.Size = New Size(43, 50)
        lblCPS.TabIndex = 7
        lblCPS.Text = "0"
        lblCPS.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCE
        ' 
        lblCE.AutoSize = True
        lblCE.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblCE.Location = New Point(168, 419)
        lblCE.Margin = New Padding(5, 0, 5, 0)
        lblCE.Name = "lblCE"
        lblCE.Size = New Size(43, 50)
        lblCE.TabIndex = 6
        lblCE.Text = "0"
        lblCE.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picIIEE
        ' 
        picIIEE.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        picIIEE.Image = My.Resources.Resources.COECS
        picIIEE.Location = New Point(258, 688)
        picIIEE.Margin = New Padding(5, 6, 5, 6)
        picIIEE.Name = "picIIEE"
        picIIEE.Size = New Size(301, 320)
        picIIEE.SizeMode = PictureBoxSizeMode.StretchImage
        picIIEE.TabIndex = 4
        picIIEE.TabStop = False
        ' 
        ' picLPIES
        ' 
        picLPIES.Anchor = AnchorStyles.Bottom
        picLPIES.Image = My.Resources.Resources.LPUSC
        picLPIES.Location = New Point(685, 688)
        picLPIES.Margin = New Padding(5, 6, 5, 6)
        picLPIES.Name = "picLPIES"
        picLPIES.Size = New Size(295, 320)
        picLPIES.SizeMode = PictureBoxSizeMode.StretchImage
        picLPIES.TabIndex = 3
        picLPIES.TabStop = False
        ' 
        ' picIECEP
        ' 
        picIECEP.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picIECEP.Image = My.Resources.Resources.CITHM
        picIECEP.Location = New Point(878, 88)
        picIECEP.Margin = New Padding(5, 6, 5, 6)
        picIECEP.Name = "picIECEP"
        picIECEP.Size = New Size(292, 320)
        picIECEP.SizeMode = PictureBoxSizeMode.StretchImage
        picIECEP.TabIndex = 2
        picIECEP.TabStop = False
        ' 
        ' picCE
        ' 
        picCE.Image = My.Resources.Resources.CAS
        picCE.Location = New Point(45, 88)
        picCE.Margin = New Padding(5, 6, 5, 6)
        picCE.Name = "picCE"
        picCE.Size = New Size(301, 320)
        picCE.SizeMode = PictureBoxSizeMode.StretchImage
        picCE.TabIndex = 1
        picCE.TabStop = False
        ' 
        ' picCPS
        ' 
        picCPS.Anchor = AnchorStyles.Top
        picCPS.Image = My.Resources.Resources.CBA
        picCPS.Location = New Point(470, 88)
        picCPS.Margin = New Padding(5, 6, 5, 6)
        picCPS.Name = "picCPS"
        picCPS.Size = New Size(295, 320)
        picCPS.SizeMode = PictureBoxSizeMode.StretchImage
        picCPS.TabIndex = 0
        picCPS.TabStop = False
        ' 
        ' panStudentID
        ' 
        panStudentID.BackColor = Color.WhiteSmoke
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
        panStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        panStudentID.Location = New Point(89, 337)
        panStudentID.Margin = New Padding(5, 6, 5, 6)
        panStudentID.Name = "panStudentID"
        panStudentID.Size = New Size(847, 1250)
        panStudentID.TabIndex = 2
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDepartment.Location = New Point(141, 896)
        lblDepartment.Margin = New Padding(5, 0, 5, 0)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(0, 51)
        lblDepartment.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(141, 850)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(227, 50)
        Label5.TabIndex = 20
        Label5.Text = "Department:"
        ' 
        ' lblTimeIn
        ' 
        lblTimeIn.AutoSize = True
        lblTimeIn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTimeIn.Location = New Point(141, 1024)
        lblTimeIn.Margin = New Padding(5, 0, 5, 0)
        lblTimeIn.Name = "lblTimeIn"
        lblTimeIn.Size = New Size(0, 51)
        lblTimeIn.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(141, 978)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 50)
        Label2.TabIndex = 18
        Label2.Text = "Time-In:"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.Location = New Point(141, 768)
        lblCourse.Margin = New Padding(5, 0, 5, 0)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(0, 51)
        lblCourse.TabIndex = 17
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.Location = New Point(141, 640)
        lblFullName.Margin = New Padding(5, 0, 5, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(0, 51)
        lblFullName.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(141, 722)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(247, 50)
        Label8.TabIndex = 15
        Label8.Text = "Course - Year:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(141, 594)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(195, 50)
        Label7.TabIndex = 14
        Label7.Text = "Full Name:"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = My.Resources.Resources.LAYAG
        PictureBox7.Location = New Point(240, 55)
        PictureBox7.Margin = New Padding(5, 6, 5, 6)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(351, 306)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 12
        PictureBox7.TabStop = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DarkGray
        btnSubmit.Enabled = False
        btnSubmit.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.Location = New Point(250, 1118)
        btnSubmit.Margin = New Padding(5, 6, 5, 6)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(278, 85)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "Time In/Out"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudent.Location = New Point(141, 439)
        lblStudent.Margin = New Padding(5, 0, 5, 0)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(303, 50)
        lblStudent.TabIndex = 1
        lblStudent.Text = "Student Number:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Enabled = False
        txtStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(143, 498)
        txtStudentID.Margin = New Padding(5, 6, 5, 6)
        txtStudentID.MaxLength = 10
        txtStudentID.Name = "txtStudentID"
        txtStudentID.PlaceholderText = "1234-12345"
        txtStudentID.Size = New Size(550, 50)
        txtStudentID.TabIndex = 0
        ' 
        ' tabView
        ' 
        tabView.BackColor = Color.CornflowerBlue
        tabView.BackgroundImage = My.Resources.Resources.campus
        tabView.BackgroundImageLayout = ImageLayout.Stretch
        tabView.Controls.Add(panLogin)
        tabView.Location = New Point(8, 38)
        tabView.Margin = New Padding(5, 6, 5, 6)
        tabView.Name = "tabView"
        tabView.Padding = New Padding(5, 6, 5, 6)
        tabView.Size = New Size(2212, 1714)
        tabView.TabIndex = 1
        tabView.Text = "View"
        ' 
        ' panLogin
        ' 
        panLogin.BackColor = Color.White
        panLogin.Controls.Add(Label4)
        panLogin.Controls.Add(Label3)
        panLogin.Controls.Add(txtPassword)
        panLogin.Controls.Add(PictureBox10)
        panLogin.Controls.Add(btnLogin)
        panLogin.Controls.Add(Label1)
        panLogin.Controls.Add(txtUsername)
        panLogin.Location = New Point(718, 331)
        panLogin.Margin = New Padding(5, 6, 5, 6)
        panLogin.Name = "panLogin"
        panLogin.Size = New Size(837, 1254)
        panLogin.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(219, 469)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(425, 86)
        Label4.TabIndex = 21
        Label4.Text = "Admin Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(141, 844)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 50)
        Label3.TabIndex = 20
        Label3.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Wingdings", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(151, 907)
        txtPassword.Margin = New Padding(5, 6, 5, 6)
        txtPassword.MaxLength = 20
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "l"c
        txtPassword.Size = New Size(550, 43)
        txtPassword.TabIndex = 2
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Anchor = AnchorStyles.Top
        PictureBox10.Image = My.Resources.Resources.LAYAG
        PictureBox10.Location = New Point(251, 74)
        PictureBox10.Margin = New Padding(5, 6, 5, 6)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(373, 338)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 17
        PictureBox10.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ScrollBar
        btnLogin.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(300, 1059)
        btnLogin.Margin = New Padding(5, 6, 5, 6)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(243, 85)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(141, 633)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 50)
        Label1.TabIndex = 16
        Label1.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(152, 695)
        txtUsername.Margin = New Padding(5, 6, 5, 6)
        txtUsername.MaxLength = 20
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(550, 50)
        txtUsername.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.LightCoral
        btnClose.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(2081, 0)
        btnClose.Margin = New Padding(5, 6, 5, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(152, 64)
        btnClose.TabIndex = 1
        btnClose.TabStop = False
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' tmrSlow
        ' 
        tmrSlow.Interval = 1000
        ' 
        ' btnReconnect
        ' 
        btnReconnect.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnReconnect.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnReconnect.Enabled = False
        btnReconnect.FlatAppearance.BorderSize = 0
        btnReconnect.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        btnReconnect.Location = New Point(1937, 0)
        btnReconnect.Margin = New Padding(5, 6, 5, 6)
        btnReconnect.Name = "btnReconnect"
        btnReconnect.Size = New Size(145, 64)
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
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2228, 1760)
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
    Friend WithEvents lblLPIES As Label
    Friend WithEvents lblIIEE As Label
    Friend WithEvents lblIECEP As Label
    Friend WithEvents lblCPS As Label
    Friend WithEvents lblCE As Label
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
