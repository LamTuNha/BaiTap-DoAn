<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Menu
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
        Me.pnLogin = New System.Windows.Forms.Panel()
        Me.btExit = New System.Windows.Forms.Button()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnMenu = New System.Windows.Forms.Panel()
        Me.btQLSV = New System.Windows.Forms.Button()
        Me.btK_MH = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btLogout = New System.Windows.Forms.Button()
        Me.btExit2 = New System.Windows.Forms.Button()
        Me.pnLogin.SuspendLayout()
        Me.pnMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnLogin
        '
        Me.pnLogin.BackColor = System.Drawing.Color.PaleGreen
        Me.pnLogin.Controls.Add(Me.btExit)
        Me.pnLogin.Controls.Add(Me.btLogin)
        Me.pnLogin.Controls.Add(Me.txtPassword)
        Me.pnLogin.Controls.Add(Me.txtUsername)
        Me.pnLogin.Controls.Add(Me.lbPass)
        Me.pnLogin.Controls.Add(Me.lbUser)
        Me.pnLogin.Controls.Add(Me.Label4)
        Me.pnLogin.Controls.Add(Me.Label3)
        Me.pnLogin.Controls.Add(Me.Label2)
        Me.pnLogin.Controls.Add(Me.Label1)
        Me.pnLogin.ForeColor = System.Drawing.Color.Navy
        Me.pnLogin.Location = New System.Drawing.Point(12, 12)
        Me.pnLogin.Name = "pnLogin"
        Me.pnLogin.Size = New System.Drawing.Size(776, 426)
        Me.pnLogin.TabIndex = 13
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.LightPink
        Me.btExit.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.ForeColor = System.Drawing.Color.Navy
        Me.btExit.Location = New System.Drawing.Point(251, 285)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(142, 44)
        Me.btExit.TabIndex = 7
        Me.btExit.Text = "Thoát"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'btLogin
        '
        Me.btLogin.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btLogin.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.ForeColor = System.Drawing.Color.Navy
        Me.btLogin.Location = New System.Drawing.Point(425, 285)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(142, 44)
        Me.btLogin.TabIndex = 6
        Me.btLogin.Text = "Đăng Nhập"
        Me.btLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(280, 229)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(259, 22)
        Me.txtPassword.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Location = New System.Drawing.Point(279, 173)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(259, 22)
        Me.txtUsername.TabIndex = 3
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPass.ForeColor = System.Drawing.Color.Navy
        Me.lbPass.Location = New System.Drawing.Point(161, 229)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(110, 24)
        Me.lbPass.TabIndex = 2
        Me.lbPass.Text = "Password:"
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUser.ForeColor = System.Drawing.Color.Navy
        Me.lbUser.Location = New System.Drawing.Point(161, 173)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(112, 24)
        Me.lbUser.TabIndex = 1
        Me.lbUser.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(405, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "(Username: admin)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(410, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "(Password: admin)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Phần Mềm Quản Lý Sinh Viên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(284, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đăng Nhập."
        '
        'pnMenu
        '
        Me.pnMenu.BackColor = System.Drawing.Color.LightPink
        Me.pnMenu.Controls.Add(Me.btQLSV)
        Me.pnMenu.Controls.Add(Me.btK_MH)
        Me.pnMenu.Controls.Add(Me.Label6)
        Me.pnMenu.Controls.Add(Me.Label5)
        Me.pnMenu.Controls.Add(Me.btLogout)
        Me.pnMenu.Controls.Add(Me.btExit2)
        Me.pnMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnMenu.Location = New System.Drawing.Point(12, 12)
        Me.pnMenu.Name = "pnMenu"
        Me.pnMenu.Size = New System.Drawing.Size(776, 426)
        Me.pnMenu.TabIndex = 14
        '
        'btQLSV
        '
        Me.btQLSV.BackColor = System.Drawing.Color.SandyBrown
        Me.btQLSV.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btQLSV.ForeColor = System.Drawing.Color.Navy
        Me.btQLSV.Location = New System.Drawing.Point(47, 187)
        Me.btQLSV.Name = "btQLSV"
        Me.btQLSV.Size = New System.Drawing.Size(670, 100)
        Me.btQLSV.TabIndex = 13
        Me.btQLSV.Text = "Quản Lý Sinh Viên"
        Me.btQLSV.UseVisualStyleBackColor = False
        '
        'btK_MH
        '
        Me.btK_MH.BackColor = System.Drawing.Color.PaleGreen
        Me.btK_MH.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btK_MH.ForeColor = System.Drawing.Color.Navy
        Me.btK_MH.Location = New System.Drawing.Point(47, 70)
        Me.btK_MH.Name = "btK_MH"
        Me.btK_MH.Size = New System.Drawing.Size(670, 100)
        Me.btK_MH.TabIndex = 12
        Me.btK_MH.Text = "Quản Lý Khoa và Môn Học"
        Me.btK_MH.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(133, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Admin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(15, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Username:"
        '
        'btLogout
        '
        Me.btLogout.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btLogout.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogout.ForeColor = System.Drawing.Color.Navy
        Me.btLogout.Location = New System.Drawing.Point(381, 327)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Size = New System.Drawing.Size(142, 44)
        Me.btLogout.TabIndex = 9
        Me.btLogout.Text = "Đăng Xuất"
        Me.btLogout.UseVisualStyleBackColor = False
        '
        'btExit2
        '
        Me.btExit2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btExit2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit2.ForeColor = System.Drawing.Color.Navy
        Me.btExit2.Location = New System.Drawing.Point(575, 327)
        Me.btExit2.Name = "btExit2"
        Me.btExit2.Size = New System.Drawing.Size(142, 44)
        Me.btExit2.TabIndex = 8
        Me.btExit2.Text = "Thoát"
        Me.btExit2.UseVisualStyleBackColor = False
        '
        'Login_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 453)
        Me.Controls.Add(Me.pnLogin)
        Me.Controls.Add(Me.pnMenu)
        Me.Name = "Login_Menu"
        Me.Text = "Form1"
        Me.pnLogin.ResumeLayout(False)
        Me.pnLogin.PerformLayout()
        Me.pnMenu.ResumeLayout(False)
        Me.pnMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents pnLogin As Panel
    Friend WithEvents btExit As Button
    Friend WithEvents btLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lbPass As Label
    Friend WithEvents lbUser As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents pnMenu As Panel
    Friend WithEvents btQLSV As Button
    Friend WithEvents btK_MH As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btLogout As Button
    Friend WithEvents btExit2 As Button
End Class
