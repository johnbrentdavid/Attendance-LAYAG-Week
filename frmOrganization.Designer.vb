<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrganization
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmOrganization))
        btnClose = New Button()
        panOrg = New Panel()
        lblOrg = New Label()
        picOrg = New PictureBox()
        panAttendees = New Panel()
        btnRefresh = New Button()
        grdAttendance = New DataGridView()
        panOrg.SuspendLayout()
        CType(picOrg, ComponentModel.ISupportInitialize).BeginInit()
        panAttendees.SuspendLayout()
        CType(grdAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(1349, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 2
        btnClose.TabStop = False
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' panOrg
        ' 
        panOrg.BackColor = Color.White
        panOrg.BorderStyle = BorderStyle.FixedSingle
        panOrg.Controls.Add(lblOrg)
        panOrg.Controls.Add(picOrg)
        panOrg.Location = New Point(110, 30)
        panOrg.Name = "panOrg"
        panOrg.Size = New Size(719, 190)
        panOrg.TabIndex = 3
        ' 
        ' lblOrg
        ' 
        lblOrg.Anchor = AnchorStyles.Top
        lblOrg.AutoSize = True
        lblOrg.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblOrg.Location = New Point(189, 45)
        lblOrg.MaximumSize = New Size(500, 150)
        lblOrg.Name = "lblOrg"
        lblOrg.Size = New Size(433, 100)
        lblOrg.TabIndex = 6
        lblOrg.Text = "Computer Programming Society"
        ' 
        ' picOrg
        ' 
        picOrg.Anchor = AnchorStyles.Top
        picOrg.Image = CType(resources.GetObject("picOrg.Image"), Image)
        picOrg.Location = New Point(23, 20)
        picOrg.Name = "picOrg"
        picOrg.Size = New Size(150, 150)
        picOrg.SizeMode = PictureBoxSizeMode.StretchImage
        picOrg.TabIndex = 1
        picOrg.TabStop = False
        ' 
        ' panAttendees
        ' 
        panAttendees.BackColor = Color.White
        panAttendees.BorderStyle = BorderStyle.FixedSingle
        panAttendees.Controls.Add(btnRefresh)
        panAttendees.Controls.Add(grdAttendance)
        panAttendees.Location = New Point(154, 256)
        panAttendees.Name = "panAttendees"
        panAttendees.Size = New Size(1114, 600)
        panAttendees.TabIndex = 4
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.CornflowerBlue
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(1038, -1)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 5
        btnRefresh.TabStop = False
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' grdAttendance
        ' 
        grdAttendance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grdAttendance.BackgroundColor = Color.White
        grdAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdAttendance.Location = New Point(20, 22)
        grdAttendance.Name = "grdAttendance"
        grdAttendance.ReadOnly = True
        grdAttendance.RowTemplate.Height = 25
        grdAttendance.Size = New Size(1072, 558)
        grdAttendance.TabIndex = 1
        grdAttendance.TabStop = False
        ' 
        ' frmOrganization
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Main_Background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1422, 877)
        Controls.Add(panAttendees)
        Controls.Add(panOrg)
        Controls.Add(btnClose)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmOrganization"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmOrganization"
        WindowState = FormWindowState.Maximized
        panOrg.ResumeLayout(False)
        panOrg.PerformLayout()
        CType(picOrg, ComponentModel.ISupportInitialize).EndInit()
        panAttendees.ResumeLayout(False)
        CType(grdAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents panOrg As Panel
    Friend WithEvents picOrg As PictureBox
    Friend WithEvents panAttendees As Panel
    Friend WithEvents grdAttendance As DataGridView
    Friend WithEvents lblOrg As Label
    Friend WithEvents btnRefresh As Button
End Class
