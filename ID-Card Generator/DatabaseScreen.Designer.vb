<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseScreen))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDcardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCard_DBDataSet = New WindowsApplication1.IdCard_DBDataSet()
        Me.IdCardDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDcardTableAdapter = New WindowsApplication1.IdCard_DBDataSetTableAdapters.IDcardTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDcardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCard_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCardDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.OrangeRed
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1254, 681)
        Me.DataGridView1.TabIndex = 0
        '
        'IDcardBindingSource
        '
        Me.IDcardBindingSource.DataMember = "IDcard"
        Me.IDcardBindingSource.DataSource = Me.IdCard_DBDataSet
        '
        'IdCard_DBDataSet
        '
        Me.IdCard_DBDataSet.DataSetName = "IdCard_DBDataSet"
        Me.IdCard_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdCardDBDataSetBindingSource
        '
        Me.IdCardDBDataSetBindingSource.DataSource = Me.IdCard_DBDataSet
        Me.IdCardDBDataSetBindingSource.Position = 0
        '
        'IDcardTableAdapter
        '
        Me.IDcardTableAdapter.ClearBeforeFill = True
        '
        'DatabaseScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 681)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatabaseScreen"
        Me.Text = "ID-Card Database"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDcardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCard_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCardDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdCardDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdCard_DBDataSet As WindowsApplication1.IdCard_DBDataSet
    Friend WithEvents IDcardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDcardTableAdapter As WindowsApplication1.IdCard_DBDataSetTableAdapters.IDcardTableAdapter
End Class
