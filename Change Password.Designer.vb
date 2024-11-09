<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change_Password))
        Me.txtAdminPin = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lbPin = New System.Windows.Forms.Label()
        Me.lbNewPin = New System.Windows.Forms.Label()
        Me.lbConfirmPin = New System.Windows.Forms.Label()
        Me.btok = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAdminPin
        '
        Me.txtAdminPin.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAdminPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPin.Location = New System.Drawing.Point(722, 105)
        Me.txtAdminPin.Name = "txtAdminPin"
        Me.txtAdminPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminPin.Size = New System.Drawing.Size(346, 41)
        Me.txtAdminPin.TabIndex = 0
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(722, 185)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(346, 41)
        Me.txtNewPassword.TabIndex = 1
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(722, 266)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(346, 41)
        Me.txtConfirmPassword.TabIndex = 2
        '
        'lbPin
        '
        Me.lbPin.AutoSize = True
        Me.lbPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPin.Location = New System.Drawing.Point(223, 105)
        Me.lbPin.Name = "lbPin"
        Me.lbPin.Size = New System.Drawing.Size(203, 44)
        Me.lbPin.TabIndex = 3
        Me.lbPin.Text = "Admin Pin"
        '
        'lbNewPin
        '
        Me.lbNewPin.AutoSize = True
        Me.lbNewPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNewPin.Location = New System.Drawing.Point(223, 185)
        Me.lbNewPin.Name = "lbNewPin"
        Me.lbNewPin.Size = New System.Drawing.Size(283, 44)
        Me.lbNewPin.TabIndex = 4
        Me.lbNewPin.Text = "New Password"
        '
        'lbConfirmPin
        '
        Me.lbConfirmPin.AutoSize = True
        Me.lbConfirmPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConfirmPin.Location = New System.Drawing.Point(223, 266)
        Me.lbConfirmPin.Name = "lbConfirmPin"
        Me.lbConfirmPin.Size = New System.Drawing.Size(347, 44)
        Me.lbConfirmPin.TabIndex = 5
        Me.lbConfirmPin.Text = "Confirm Password"
        '
        'btok
        '
        Me.btok.BackColor = System.Drawing.Color.Gainsboro
        Me.btok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btok.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btok.Location = New System.Drawing.Point(373, 378)
        Me.btok.Name = "btok"
        Me.btok.Size = New System.Drawing.Size(197, 58)
        Me.btok.TabIndex = 6
        Me.btok.Text = "Submit"
        Me.btok.UseVisualStyleBackColor = False
        '
        'btBack
        '
        Me.btBack.BackColor = System.Drawing.Color.Gainsboro
        Me.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBack.Location = New System.Drawing.Point(646, 378)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(166, 58)
        Me.btBack.TabIndex = 7
        Me.btBack.Text = "Back"
        Me.btBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(141, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(141, 194)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(141, 275)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(55, 44)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1178, 612)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.btok)
        Me.Controls.Add(Me.lbConfirmPin)
        Me.Controls.Add(Me.lbNewPin)
        Me.Controls.Add(Me.lbPin)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtAdminPin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Change_Password"
        Me.Text = "Change_Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAdminPin As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lbPin As System.Windows.Forms.Label
    Friend WithEvents lbNewPin As System.Windows.Forms.Label
    Friend WithEvents lbConfirmPin As System.Windows.Forms.Label
    Friend WithEvents btok As System.Windows.Forms.Button
    Friend WithEvents btBack As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
