<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quantityform
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
        Me.cbsweetname = New System.Windows.Forms.ComboBox()
        Me.btAddQuantity = New System.Windows.Forms.Button()
        Me.txtAddQuantity = New System.Windows.Forms.TextBox()
        Me.lbShowQuantity = New System.Windows.Forms.Label()
        Me.rbkilograms = New System.Windows.Forms.RadioButton()
        Me.rbgrams = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cbsweetname
        '
        Me.cbsweetname.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsweetname.FormattingEnabled = True
        Me.cbsweetname.Items.AddRange(New Object() {"Barfi", "Gajarpak", "Imarti", "Jalebi", "Kaju Katli", "KalaKand", "Ladoo", "Modak", "Motipak", "Petha", "Rasgulla", "RasBhari", "SohanPapdi", "ShakkarPara", "Tosha"})
        Me.cbsweetname.Location = New System.Drawing.Point(52, 57)
        Me.cbsweetname.Name = "cbsweetname"
        Me.cbsweetname.Size = New System.Drawing.Size(488, 50)
        Me.cbsweetname.TabIndex = 0
        Me.cbsweetname.Text = "Select Sweetname"
        '
        'btAddQuantity
        '
        Me.btAddQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddQuantity.Location = New System.Drawing.Point(1038, 194)
        Me.btAddQuantity.Name = "btAddQuantity"
        Me.btAddQuantity.Size = New System.Drawing.Size(261, 61)
        Me.btAddQuantity.TabIndex = 2
        Me.btAddQuantity.Text = "Add Quantity"
        Me.btAddQuantity.UseVisualStyleBackColor = True
        '
        'txtAddQuantity
        '
        Me.txtAddQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddQuantity.Location = New System.Drawing.Point(698, 194)
        Me.txtAddQuantity.Name = "txtAddQuantity"
        Me.txtAddQuantity.Size = New System.Drawing.Size(301, 61)
        Me.txtAddQuantity.TabIndex = 3
        '
        'lbShowQuantity
        '
        Me.lbShowQuantity.AutoSize = True
        Me.lbShowQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShowQuantity.Location = New System.Drawing.Point(593, 63)
        Me.lbShowQuantity.Name = "lbShowQuantity"
        Me.lbShowQuantity.Size = New System.Drawing.Size(0, 44)
        Me.lbShowQuantity.TabIndex = 4
        '
        'rbkilograms
        '
        Me.rbkilograms.AutoSize = True
        Me.rbkilograms.Checked = True
        Me.rbkilograms.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbkilograms.Location = New System.Drawing.Point(707, 139)
        Me.rbkilograms.Name = "rbkilograms"
        Me.rbkilograms.Size = New System.Drawing.Size(163, 36)
        Me.rbkilograms.TabIndex = 5
        Me.rbkilograms.TabStop = True
        Me.rbkilograms.Text = "Kilograms"
        Me.rbkilograms.UseVisualStyleBackColor = True
        '
        'rbgrams
        '
        Me.rbgrams.AutoSize = True
        Me.rbgrams.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbgrams.Location = New System.Drawing.Point(1038, 139)
        Me.rbgrams.Name = "rbgrams"
        Me.rbgrams.Size = New System.Drawing.Size(120, 36)
        Me.rbgrams.TabIndex = 6
        Me.rbgrams.TabStop = True
        Me.rbgrams.Text = "Grams"
        Me.rbgrams.UseVisualStyleBackColor = True
        '
        'quantityform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1332, 754)
        Me.Controls.Add(Me.rbgrams)
        Me.Controls.Add(Me.rbkilograms)
        Me.Controls.Add(Me.lbShowQuantity)
        Me.Controls.Add(Me.txtAddQuantity)
        Me.Controls.Add(Me.btAddQuantity)
        Me.Controls.Add(Me.cbsweetname)
        Me.Name = "quantityform"
        Me.Text = "Quantity"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbsweetname As System.Windows.Forms.ComboBox
    Friend WithEvents btAddQuantity As System.Windows.Forms.Button
    Friend WithEvents txtAddQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lbShowQuantity As System.Windows.Forms.Label
    Friend WithEvents rbkilograms As System.Windows.Forms.RadioButton
    Friend WithEvents rbgrams As System.Windows.Forms.RadioButton
End Class
