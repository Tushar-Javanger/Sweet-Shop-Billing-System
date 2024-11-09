<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbsweetshopname = New System.Windows.Forms.Label()
        Me.changepasswordicon = New System.Windows.Forms.PictureBox()
        Me.lbChangePassword = New System.Windows.Forms.Label()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lbUserPassword = New System.Windows.Forms.Label()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.changepasswordicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.lbsweetshopname)
        Me.GroupBox1.Controls.Add(Me.changepasswordicon)
        Me.GroupBox1.Controls.Add(Me.lbChangePassword)
        Me.GroupBox1.Controls.Add(Me.ShowPassword)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.btLogin)
        Me.GroupBox1.Controls.Add(Me.txtUserPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.lbUserPassword)
        Me.GroupBox1.Controls.Add(Me.lbUsername)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1273, 642)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lbsweetshopname
        '
        Me.lbsweetshopname.AutoSize = True
        Me.lbsweetshopname.Font = New System.Drawing.Font("Nirmala UI", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsweetshopname.Location = New System.Drawing.Point(12, 46)
        Me.lbsweetshopname.Name = "lbsweetshopname"
        Me.lbsweetshopname.Size = New System.Drawing.Size(558, 65)
        Me.lbsweetshopname.TabIndex = 11
        Me.lbsweetshopname.Text = "Shri Balaji Sweet House"
        '
        'changepasswordicon
        '
        Me.changepasswordicon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changepasswordicon.Image = CType(resources.GetObject("changepasswordicon.Image"), System.Drawing.Image)
        Me.changepasswordicon.Location = New System.Drawing.Point(744, 373)
        Me.changepasswordicon.Name = "changepasswordicon"
        Me.changepasswordicon.Size = New System.Drawing.Size(39, 30)
        Me.changepasswordicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.changepasswordicon.TabIndex = 10
        Me.changepasswordicon.TabStop = False
        '
        'lbChangePassword
        '
        Me.lbChangePassword.AutoSize = True
        Me.lbChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbChangePassword.Location = New System.Drawing.Point(784, 378)
        Me.lbChangePassword.Name = "lbChangePassword"
        Me.lbChangePassword.Size = New System.Drawing.Size(173, 25)
        Me.lbChangePassword.TabIndex = 9
        Me.lbChangePassword.Text = "Change Password"
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.Location = New System.Drawing.Point(809, 189)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(175, 29)
        Me.ShowPassword.TabIndex = 8
        Me.ShowPassword.Text = "Show Password"
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.Location = New System.Drawing.Point(878, 256)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(159, 44)
        Me.btCancel.TabIndex = 6
        Me.btCancel.Text = "CANCEL"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btLogin
        '
        Me.btLogin.BackColor = System.Drawing.Color.White
        Me.btLogin.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.Location = New System.Drawing.Point(716, 256)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(130, 44)
        Me.btLogin.TabIndex = 5
        Me.btLogin.Text = "LOGIN"
        Me.btLogin.UseVisualStyleBackColor = False
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Location = New System.Drawing.Point(809, 120)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPassword.Size = New System.Drawing.Size(238, 30)
        Me.txtUserPassword.TabIndex = 4
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(809, 73)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(238, 30)
        Me.txtUserName.TabIndex = 3
        '
        'lbUserPassword
        '
        Me.lbUserPassword.AutoSize = True
        Me.lbUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserPassword.Location = New System.Drawing.Point(670, 123)
        Me.lbUserPassword.Name = "lbUserPassword"
        Me.lbUserPassword.Size = New System.Drawing.Size(106, 25)
        Me.lbUserPassword.TabIndex = 2
        Me.lbUserPassword.Text = "Password"
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsername.Location = New System.Drawing.Point(670, 73)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(113, 25)
        Me.lbUsername.TabIndex = 1
        Me.lbUsername.Text = "UserName"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(558, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1283, 654)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.changepasswordicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lbUserPassword As System.Windows.Forms.Label
    Friend WithEvents lbUsername As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents lbChangePassword As System.Windows.Forms.Label
    Friend WithEvents changepasswordicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbsweetshopname As System.Windows.Forms.Label

End Class
