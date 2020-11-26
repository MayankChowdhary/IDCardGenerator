<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatabaseScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseScreen))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDCardGenDBDataSet = New WindowsApplication1.IDCardGenDBDataSet()
        Me.IDcardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDcardTableAdapter = New WindowsApplication1.IDCardGenDBDataSetTableAdapters.IDcardTableAdapter()
        Me.RollDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodGrpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDCardGenDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDcardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.BloodGrpDataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.GuardianDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ImageDataGridViewImageColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.SessionDataGridViewTextBoxColumn, Me.LogoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.IDcardBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.OrangeRed
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1254, 681)
        Me.DataGridView1.TabIndex = 0
        '
        'IDCardGenDBDataSet
        '
        Me.IDCardGenDBDataSet.DataSetName = "IDCardGenDBDataSet"
        Me.IDCardGenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDcardBindingSource
        '
        Me.IDcardBindingSource.DataMember = "IDcard"
        Me.IDcardBindingSource.DataSource = Me.IDCardGenDBDataSet
        '
        'IDcardTableAdapter
        '
        Me.IDcardTableAdapter.ClearBeforeFill = True
        '
        'RollDataGridViewTextBoxColumn
        '
        Me.RollDataGridViewTextBoxColumn.DataPropertyName = "Roll"
        Me.RollDataGridViewTextBoxColumn.HeaderText = "Roll"
        Me.RollDataGridViewTextBoxColumn.Name = "RollDataGridViewTextBoxColumn"
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "Sname"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "Sname"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "Cname"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "Cname"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'BloodGrpDataGridViewTextBoxColumn
        '
        Me.BloodGrpDataGridViewTextBoxColumn.DataPropertyName = "Blood_Grp"
        Me.BloodGrpDataGridViewTextBoxColumn.HeaderText = "Blood_Grp"
        Me.BloodGrpDataGridViewTextBoxColumn.Name = "BloodGrpDataGridViewTextBoxColumn"
        '
        'ProgramDataGridViewTextBoxColumn
        '
        Me.ProgramDataGridViewTextBoxColumn.DataPropertyName = "Program"
        Me.ProgramDataGridViewTextBoxColumn.HeaderText = "Program"
        Me.ProgramDataGridViewTextBoxColumn.Name = "ProgramDataGridViewTextBoxColumn"
        '
        'GuardianDataGridViewTextBoxColumn
        '
        Me.GuardianDataGridViewTextBoxColumn.DataPropertyName = "Guardian"
        Me.GuardianDataGridViewTextBoxColumn.HeaderText = "Guardian"
        Me.GuardianDataGridViewTextBoxColumn.Name = "GuardianDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ImageDataGridViewImageColumn
        '
        Me.ImageDataGridViewImageColumn.DataPropertyName = "Image"
        Me.ImageDataGridViewImageColumn.HeaderText = "Image"
        Me.ImageDataGridViewImageColumn.Name = "ImageDataGridViewImageColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'SessionDataGridViewTextBoxColumn
        '
        Me.SessionDataGridViewTextBoxColumn.DataPropertyName = "Session"
        Me.SessionDataGridViewTextBoxColumn.HeaderText = "Session"
        Me.SessionDataGridViewTextBoxColumn.Name = "SessionDataGridViewTextBoxColumn"
        '
        'LogoDataGridViewImageColumn
        '
        Me.LogoDataGridViewImageColumn.DataPropertyName = "logo"
        Me.LogoDataGridViewImageColumn.HeaderText = "logo"
        Me.LogoDataGridViewImageColumn.Name = "LogoDataGridViewImageColumn"
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
        CType(Me.IDCardGenDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDcardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDCardGenDBDataSet As IDCardGenDBDataSet
    Friend WithEvents IDcardBindingSource As BindingSource
    Friend WithEvents IDcardTableAdapter As IDCardGenDBDataSetTableAdapters.IDcardTableAdapter
    Friend WithEvents RollDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodGrpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogoDataGridViewImageColumn As DataGridViewImageColumn
End Class
