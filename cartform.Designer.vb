<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cartform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cartform))
        Me.ProjectDBDataSet = New FinalYearProject.ProjectDBDataSet()
        Me.CartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartTableAdapter = New FinalYearProject.ProjectDBDataSetTableAdapters.CartTableAdapter()
        Me.dgCart = New System.Windows.Forms.DataGridView()
        Me.ProjectDBDataSet1 = New FinalYearProject.ProjectDBDataSet1()
        Me.CartTableAdapter1 = New FinalYearProject.ProjectDBDataSet1TableAdapters.CartTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbAmount = New System.Windows.Forms.Label()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btGenerateBill = New System.Windows.Forms.Button()
        Me.btclear = New System.Windows.Forms.Button()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.ppd = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.ProjectDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectDBDataSet
        '
        Me.ProjectDBDataSet.DataSetName = "ProjectDBDataSet"
        Me.ProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartBindingSource
        '
        Me.CartBindingSource.DataMember = "Cart"
        Me.CartBindingSource.DataSource = Me.ProjectDBDataSet
        '
        'CartTableAdapter
        '
        Me.CartTableAdapter.ClearBeforeFill = True
        '
        'dgCart
        '
        Me.dgCart.AllowUserToAddRows = False
        Me.dgCart.AllowUserToDeleteRows = False
        Me.dgCart.AllowUserToResizeColumns = False
        Me.dgCart.AllowUserToResizeRows = False
        Me.dgCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgCart.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgCart.Location = New System.Drawing.Point(0, 0)
        Me.dgCart.MultiSelect = False
        Me.dgCart.Name = "dgCart"
        Me.dgCart.ReadOnly = True
        Me.dgCart.RowTemplate.Height = 24
        Me.dgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCart.Size = New System.Drawing.Size(1305, 515)
        Me.dgCart.TabIndex = 0
        '
        'ProjectDBDataSet1
        '
        Me.ProjectDBDataSet1.DataSetName = "ProjectDBDataSet1"
        Me.ProjectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartTableAdapter1
        '
        Me.CartTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 599)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Amount :"
        '
        'lbAmount
        '
        Me.lbAmount.AutoSize = True
        Me.lbAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAmount.Location = New System.Drawing.Point(463, 599)
        Me.lbAmount.Name = "lbAmount"
        Me.lbAmount.Size = New System.Drawing.Size(152, 51)
        Me.lbAmount.TabIndex = 2
        Me.lbAmount.Text = "Label2"
        '
        'btdelete
        '
        Me.btdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdelete.Location = New System.Drawing.Point(807, 559)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(152, 69)
        Me.btdelete.TabIndex = 3
        Me.btdelete.Text = "Delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'btGenerateBill
        '
        Me.btGenerateBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGenerateBill.Location = New System.Drawing.Point(993, 561)
        Me.btGenerateBill.Name = "btGenerateBill"
        Me.btGenerateBill.Size = New System.Drawing.Size(250, 69)
        Me.btGenerateBill.TabIndex = 4
        Me.btGenerateBill.Text = "Generate Bill"
        Me.btGenerateBill.UseVisualStyleBackColor = True
        '
        'btclear
        '
        Me.btclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btclear.Location = New System.Drawing.Point(898, 646)
        Me.btclear.Name = "btclear"
        Me.btclear.Size = New System.Drawing.Size(193, 48)
        Me.btclear.TabIndex = 5
        Me.btclear.Text = "Clear"
        Me.btclear.UseVisualStyleBackColor = True
        '
        'printDoc
        '
        '
        'ppd
        '
        Me.ppd.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppd.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppd.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppd.Enabled = True
        Me.ppd.Icon = CType(resources.GetObject("ppd.Icon"), System.Drawing.Icon)
        Me.ppd.Name = "ppd"
        Me.ppd.Visible = False
        '
        'cartform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1305, 706)
        Me.Controls.Add(Me.btclear)
        Me.Controls.Add(Me.btGenerateBill)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.lbAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgCart)
        Me.Name = "cartform"
        Me.Text = "Cart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProjectDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectDBDataSet As FinalYearProject.ProjectDBDataSet
    Friend WithEvents CartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CartTableAdapter As FinalYearProject.ProjectDBDataSetTableAdapters.CartTableAdapter
    Friend WithEvents dgCart As System.Windows.Forms.DataGridView
    Friend WithEvents ProjectDBDataSet1 As FinalYearProject.ProjectDBDataSet1
    Friend WithEvents CartTableAdapter1 As FinalYearProject.ProjectDBDataSet1TableAdapters.CartTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbAmount As System.Windows.Forms.Label
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents btGenerateBill As System.Windows.Forms.Button
    Friend WithEvents btclear As System.Windows.Forms.Button
    Friend WithEvents printDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents ppd As System.Windows.Forms.PrintPreviewDialog
End Class
