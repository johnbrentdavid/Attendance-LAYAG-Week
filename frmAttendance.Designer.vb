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
        lblLPUSC = New Label()
        lblCOECS = New Label()
        lblCITHM = New Label()
        lblCBA = New Label()
        lblCAS = New Label()
        picCOECS = New PictureBox()
        picLPUSC = New PictureBox()
        picCITHM = New PictureBox()
        picCAS = New PictureBox()
        picCBA = New PictureBox()
        panStudentID = New Panel()
        txtStudentID = New TextBox()
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
        tabView = New TabPage()
        panLogin = New Panel()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox10 = New PictureBox()
        btnLogin = New Button()
        Label1 = New Label()
        btnClose = New Button()
        tmrSlow = New Timer(components)
        btnReconnect = New Button()
        tmrFast = New Timer(components)
        TabControl1.SuspendLayout()
        tabAttendance.SuspendLayout()
        panLogos.SuspendLayout()
        CType(picCOECS, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLPUSC, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCITHM, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCAS, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCBA, ComponentModel.ISupportInitialize).BeginInit()
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
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1045, 516)
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
        tabAttendance.Name = "tabAttendance"
        tabAttendance.Padding = New Padding(3)
        tabAttendance.Size = New Size(1037, 478)
        tabAttendance.TabIndex = 0
        tabAttendance.Text = "Attendance"
        ' 
        ' lblCopyright
        ' 
        lblCopyright.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblCopyright.AutoSize = True
        lblCopyright.BackColor = Color.Transparent
        lblCopyright.Font = New Font("Times New Roman", 14.1428576F, FontStyle.Italic, GraphicsUnit.Point)
        lblCopyright.Location = New Point(641, 457)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(393, 21)
        lblCopyright.TabIndex = 8
        lblCopyright.Text = "Copyright 2023 | Computer Programming Society"
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Segoe UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblTime.Location = New Point(466, 23)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(102, 47)
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
        lblMessage.Location = New Point(177, 330)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(683, 47)
        lblMessage.TabIndex = 7
        lblMessage.Text = "Please wait for the admin to come back."
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' panLogos
        ' 
        panLogos.Anchor = AnchorStyles.Top
        panLogos.BackColor = Color.WhiteSmoke
        panLogos.BorderStyle = BorderStyle.Fixed3D
        panLogos.Controls.Add(Label6)
        panLogos.Controls.Add(lblTotal)
        panLogos.Controls.Add(lblLPUSC)
        panLogos.Controls.Add(lblCOECS)
        panLogos.Controls.Add(lblCITHM)
        panLogos.Controls.Add(lblCBA)
        panLogos.Controls.Add(lblCAS)
        panLogos.Controls.Add(picCOECS)
        panLogos.Controls.Add(picLPUSC)
        panLogos.Controls.Add(picCITHM)
        panLogos.Controls.Add(picCAS)
        panLogos.Controls.Add(picCBA)
        panLogos.Location = New Point(508, 158)
        panLogos.Name = "panLogos"
        panLogos.Size = New Size(659, 588)
        panLogos.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Britannic Bold", 26.1428585F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(150, 253)
        Label6.Name = "Label6"
        Label6.Size = New Size(327, 38)
        Label6.TabIndex = 21
        Label6.Text = "LAYAG PIRATA 2023"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotal.Location = New Point(9, 560)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(180, 20)
        lblTotal.TabIndex = 12
        lblTotal.Text = "Total Current Attendees: 0"
        lblTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLPUSC
        ' 
        lblLPUSC.Anchor = AnchorStyles.Bottom
        lblLPUSC.AutoSize = True
        lblLPUSC.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblLPUSC.Location = New Point(437, 478)
        lblLPUSC.Name = "lblLPUSC"
        lblLPUSC.Size = New Size(23, 25)
        lblLPUSC.TabIndex = 10
        lblLPUSC.Text = "0"
        lblLPUSC.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCOECS
        ' 
        lblCOECS.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblCOECS.AutoSize = True
        lblCOECS.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblCOECS.Location = New Point(209, 477)
        lblCOECS.Name = "lblCOECS"
        lblCOECS.Size = New Size(23, 25)
        lblCOECS.TabIndex = 9
        lblCOECS.Text = "0"
        lblCOECS.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCITHM
        ' 
        lblCITHM.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCITHM.AutoSize = True
        lblCITHM.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblCITHM.Location = New Point(540, 196)
        lblCITHM.Name = "lblCITHM"
        lblCITHM.Size = New Size(23, 25)
        lblCITHM.TabIndex = 8
        lblCITHM.Text = "0"
        lblCITHM.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCBA
        ' 
        lblCBA.Anchor = AnchorStyles.Top
        lblCBA.AutoSize = True
        lblCBA.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblCBA.Location = New Point(321, 197)
        lblCBA.Name = "lblCBA"
        lblCBA.Size = New Size(23, 25)
        lblCBA.TabIndex = 7
        lblCBA.Text = "0"
        lblCBA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCAS
        ' 
        lblCAS.AutoSize = True
        lblCAS.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        lblCAS.Location = New Point(94, 196)
        lblCAS.Name = "lblCAS"
        lblCAS.Size = New Size(23, 25)
        lblCAS.TabIndex = 6
        lblCAS.Text = "0"
        lblCAS.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picCOECS
        ' 
        picCOECS.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        picCOECS.Image = My.Resources.Resources.COECS
        picCOECS.Location = New Point(139, 322)
        picCOECS.Name = "picCOECS"
        picCOECS.Size = New Size(162, 150)
        picCOECS.SizeMode = PictureBoxSizeMode.StretchImage
        picCOECS.TabIndex = 4
        picCOECS.TabStop = False
        ' 
        ' picLPUSC
        ' 
        picLPUSC.Anchor = AnchorStyles.Bottom
        picLPUSC.Image = My.Resources.Resources.LPUSC
        picLPUSC.Location = New Point(369, 322)
        picLPUSC.Name = "picLPUSC"
        picLPUSC.Size = New Size(159, 150)
        picLPUSC.SizeMode = PictureBoxSizeMode.StretchImage
        picLPUSC.TabIndex = 3
        picLPUSC.TabStop = False
        ' 
        ' picCITHM
        ' 
        picCITHM.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picCITHM.Image = My.Resources.Resources.CITHM
        picCITHM.Location = New Point(473, 41)
        picCITHM.Name = "picCITHM"
        picCITHM.Size = New Size(157, 150)
        picCITHM.SizeMode = PictureBoxSizeMode.StretchImage
        picCITHM.TabIndex = 2
        picCITHM.TabStop = False
        ' 
        ' picCAS
        ' 
        picCAS.Image = My.Resources.Resources.CAS
        picCAS.Location = New Point(24, 41)
        picCAS.Name = "picCAS"
        picCAS.Size = New Size(162, 150)
        picCAS.SizeMode = PictureBoxSizeMode.StretchImage
        picCAS.TabIndex = 1
        picCAS.TabStop = False
        ' 
        ' picCBA
        ' 
        picCBA.Anchor = AnchorStyles.Top
        picCBA.Image = My.Resources.Resources.CBA
        picCBA.Location = New Point(253, 41)
        picCBA.Name = "picCBA"
        picCBA.Size = New Size(159, 150)
        picCBA.SizeMode = PictureBoxSizeMode.StretchImage
        picCBA.TabIndex = 0
        picCBA.TabStop = False
        ' 
        ' panStudentID
        ' 
        panStudentID.Anchor = AnchorStyles.Top
        panStudentID.BackColor = Color.WhiteSmoke
        panStudentID.BorderStyle = BorderStyle.Fixed3D
        panStudentID.Controls.Add(txtStudentID)
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
        panStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        panStudentID.Location = New Point(-142, 158)
        panStudentID.Name = "panStudentID"
        panStudentID.Size = New Size(594, 588)
        panStudentID.TabIndex = 2
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Enabled = False
        txtStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(77, 233)
        txtStudentID.MaxLength = 10
        txtStudentID.Name = "txtStudentID"
        txtStudentID.PlaceholderText = "1234-12345"
        txtStudentID.Size = New Size(434, 29)
        txtStudentID.TabIndex = 0
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(76, 398)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 25)
        Label5.TabIndex = 20
        Label5.Text = "Department:"
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(76, 458)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 25)
        Label2.TabIndex = 18
        Label2.Text = "Time-In:"
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
        Label8.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(76, 338)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 25)
        Label8.TabIndex = 15
        Label8.Text = "Course - Year:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(76, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 25)
        Label7.TabIndex = 14
        Label7.Text = "Full Name:"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = My.Resources.Resources.LAYAG
        PictureBox7.Location = New Point(197, 26)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(189, 143)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 12
        PictureBox7.TabStop = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Top
        btnSubmit.BackColor = Color.DarkGray
        btnSubmit.Enabled = False
        btnSubmit.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.Location = New Point(220, 521)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(150, 40)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "Time In/Out"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudent.Location = New Point(76, 205)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(154, 25)
        lblStudent.TabIndex = 1
        lblStudent.Text = "Student Number:"
        ' 
        ' tabView
        ' 
        tabView.BackColor = Color.CornflowerBlue
        tabView.BackgroundImage = My.Resources.Resources.campus
        tabView.BackgroundImageLayout = ImageLayout.Stretch
        tabView.Controls.Add(panLogin)
        tabView.Location = New Point(4, 34)
        tabView.Name = "tabView"
        tabView.Padding = New Padding(3)
        tabView.Size = New Size(1037, 478)
        tabView.TabIndex = 1
        tabView.Text = "View"
        ' 
        ' panLogin
        ' 
        panLogin.BackColor = Color.White
        panLogin.Controls.Add(txtPassword)
        panLogin.Controls.Add(txtUsername)
        panLogin.Controls.Add(Label4)
        panLogin.Controls.Add(Label3)
        panLogin.Controls.Add(PictureBox10)
        panLogin.Controls.Add(btnLogin)
        panLogin.Controls.Add(Label1)
        panLogin.Location = New Point(387, 155)
        panLogin.Name = "panLogin"
        panLogin.Size = New Size(451, 588)
        panLogin.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Wingdings", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(81, 425)
        txtPassword.MaxLength = 20
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "l"c
        txtPassword.Size = New Size(298, 25)
        txtPassword.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(82, 326)
        txtUsername.MaxLength = 20
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(298, 29)
        txtUsername.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(118, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(213, 45)
        Label4.TabIndex = 21
        Label4.Text = "Admin Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(76, 396)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 25)
        Label3.TabIndex = 20
        Label3.Text = "Password:"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Anchor = AnchorStyles.Top
        PictureBox10.Image = My.Resources.Resources.LAYAG
        PictureBox10.Location = New Point(135, 35)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(201, 158)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 17
        PictureBox10.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ScrollBar
        btnLogin.Font = New Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(162, 496)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(131, 40)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(76, 297)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 25)
        Label1.TabIndex = 16
        Label1.Text = "Username:"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.LightCoral
        btnClose.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(963, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(82, 30)
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
        btnReconnect.Location = New Point(885, 0)
        btnReconnect.Name = "btnReconnect"
        btnReconnect.Size = New Size(78, 30)
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
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1045, 516)
        Controls.Add(btnReconnect)
        Controls.Add(btnClose)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAttendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        tabAttendance.ResumeLayout(False)
        tabAttendance.PerformLayout()
        panLogos.ResumeLayout(False)
        panLogos.PerformLayout()
        CType(picCOECS, ComponentModel.ISupportInitialize).EndInit()
        CType(picLPUSC, ComponentModel.ISupportInitialize).EndInit()
        CType(picCITHM, ComponentModel.ISupportInitialize).EndInit()
        CType(picCAS, ComponentModel.ISupportInitialize).EndInit()
        CType(picCBA, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents picCITHM As PictureBox
    Friend WithEvents picCAS As PictureBox
    Friend WithEvents picCBA As PictureBox
    Friend WithEvents panLogos As Panel
    Friend WithEvents lblLPUSC As Label
    Friend WithEvents lblCOECS As Label
    Friend WithEvents lblCITHM As Label
    Friend WithEvents lblCBA As Label
    Friend WithEvents lblCAS As Label
    Friend WithEvents picCOECS As PictureBox
    Friend WithEvents picLPUSC As PictureBox
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
