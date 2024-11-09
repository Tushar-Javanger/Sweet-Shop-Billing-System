<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePrice
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
        Me.CbSweetnameList = New System.Windows.Forms.ComboBox()
        Me.btChangePrice = New System.Windows.Forms.Button()
        Me.txtchangePrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CbSweetnameList
        '
        Me.CbSweetnameList.BackColor = System.Drawing.Color.Gainsboro
        Me.CbSweetnameList.DisplayMember = "(none)"
        Me.CbSweetnameList.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSweetnameList.FormattingEnabled = True
        Me.CbSweetnameList.Items.AddRange(New Object() {"Barfi", "Gajarpak", "Imarti", "Jalebi", "Kaju Katli", "KalaKand", "Ladoo", "Modak", "Motipak", "Petha", "Rasgulla", "RasBhari", "SohanPapdi", "ShakkarPara", "Tosha"})
        Me.CbSweetnameList.Location = New System.Drawing.Point(57, 91)
        Me.CbSweetnameList.Name = "CbSweetnameList"
        Me.CbSweetnameList.Size = New System.Drawing.Size(539, 50)
        Me.CbSweetnameList.TabIndex = 0
        Me.CbSweetnameList.Text = "Select SweetName"
        '
        'btChangePrice
        '
        Me.btChangePrice.BackColor = System.Drawing.Color.Gainsboro
        Me.btChangePrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btChangePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btChangePrice.Location = New System.Drawing.Point(1053, 91)
        Me.btChangePrice.Name = "btChangePrice"
        Me.btChangePrice.Size = New System.Drawing.Size(203, 50)
        Me.btChangePrice.TabIndex = 1
        Me.btChangePrice.Text = "Change Price"
        Me.btChangePrice.UseVisualStyleBackColor = False
        '
        'txtchangePrice
        '
        Me.txtchangePrice.BackColor = System.Drawing.Color.Gainsboro
        Me.txtchangePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtchangePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchangePrice.Location = New System.Drawing.Point(701, 92)
        Me.txtchangePrice.Name = "txtchangePrice"
        Me.txtchangePrice.Size = New System.Drawing.Size(292, 49)
        Me.txtchangePrice.TabIndex = 2
        '
        'ChangePrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 766)
        Me.Controls.Add(Me.txtchangePrice)
        Me.Controls.Add(Me.btChangePrice)
        Me.Controls.Add(Me.CbSweetnameList)
        Me.Name = "ChangePrice"
        Me.Text = "ChangePrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbSweetnameList As System.Windows.Forms.ComboBox
    Friend WithEvents btChangePrice As System.Windows.Forms.Button
    Friend WithEvents txtchangePrice As System.Windows.Forms.TextBox
End Class
