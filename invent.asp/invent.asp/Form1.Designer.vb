<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.LiledsDataSet = New invent.asp.liledsDataSet
        Me.TbproinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_proinfoTableAdapter = New invent.asp.liledsDataSetTableAdapters.tb_proinfoTableAdapter
        Me.OrderNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StoreHouseIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventoryTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FileInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FileInmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SysTiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecognitionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiledsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbproinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNumberDataGridViewTextBoxColumn, Me.StoreHouseIdDataGridViewTextBoxColumn, Me.InventoryTypeDataGridViewTextBoxColumn, Me.InventoryNameDataGridViewTextBoxColumn, Me.FileInfoDataGridViewTextBoxColumn, Me.FileInmDataGridViewTextBoxColumn, Me.SysTiDataGridViewTextBoxColumn, Me.RecognitionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbproinfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(27, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(953, 283)
        Me.DataGridView1.TabIndex = 0
        '
        'LiledsDataSet
        '
        Me.LiledsDataSet.DataSetName = "liledsDataSet"
        Me.LiledsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbproinfoBindingSource
        '
        Me.TbproinfoBindingSource.DataMember = "tb_proinfo"
        Me.TbproinfoBindingSource.DataSource = Me.LiledsDataSet
        '
        'Tb_proinfoTableAdapter
        '
        Me.Tb_proinfoTableAdapter.ClearBeforeFill = True
        '
        'OrderNumberDataGridViewTextBoxColumn
        '
        Me.OrderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber"
        Me.OrderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber"
        Me.OrderNumberDataGridViewTextBoxColumn.Name = "OrderNumberDataGridViewTextBoxColumn"
        Me.OrderNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StoreHouseIdDataGridViewTextBoxColumn
        '
        Me.StoreHouseIdDataGridViewTextBoxColumn.DataPropertyName = "StoreHouseId"
        Me.StoreHouseIdDataGridViewTextBoxColumn.HeaderText = "StoreHouseId"
        Me.StoreHouseIdDataGridViewTextBoxColumn.Name = "StoreHouseIdDataGridViewTextBoxColumn"
        '
        'InventoryTypeDataGridViewTextBoxColumn
        '
        Me.InventoryTypeDataGridViewTextBoxColumn.DataPropertyName = "InventoryType"
        Me.InventoryTypeDataGridViewTextBoxColumn.HeaderText = "InventoryType"
        Me.InventoryTypeDataGridViewTextBoxColumn.Name = "InventoryTypeDataGridViewTextBoxColumn"
        '
        'InventoryNameDataGridViewTextBoxColumn
        '
        Me.InventoryNameDataGridViewTextBoxColumn.DataPropertyName = "InventoryName"
        Me.InventoryNameDataGridViewTextBoxColumn.HeaderText = "InventoryName"
        Me.InventoryNameDataGridViewTextBoxColumn.Name = "InventoryNameDataGridViewTextBoxColumn"
        '
        'FileInfoDataGridViewTextBoxColumn
        '
        Me.FileInfoDataGridViewTextBoxColumn.DataPropertyName = "FileInfo"
        Me.FileInfoDataGridViewTextBoxColumn.HeaderText = "FileInfo"
        Me.FileInfoDataGridViewTextBoxColumn.Name = "FileInfoDataGridViewTextBoxColumn"
        '
        'FileInmDataGridViewTextBoxColumn
        '
        Me.FileInmDataGridViewTextBoxColumn.DataPropertyName = "FileInm"
        Me.FileInmDataGridViewTextBoxColumn.HeaderText = "FileInm"
        Me.FileInmDataGridViewTextBoxColumn.Name = "FileInmDataGridViewTextBoxColumn"
        '
        'SysTiDataGridViewTextBoxColumn
        '
        Me.SysTiDataGridViewTextBoxColumn.DataPropertyName = "SysTi"
        Me.SysTiDataGridViewTextBoxColumn.HeaderText = "SysTi"
        Me.SysTiDataGridViewTextBoxColumn.Name = "SysTiDataGridViewTextBoxColumn"
        '
        'RecognitionDataGridViewTextBoxColumn
        '
        Me.RecognitionDataGridViewTextBoxColumn.DataPropertyName = "Recognition"
        Me.RecognitionDataGridViewTextBoxColumn.HeaderText = "Recognition"
        Me.RecognitionDataGridViewTextBoxColumn.Name = "RecognitionDataGridViewTextBoxColumn"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillToolStripButton, Me.ToolStripDropDownButton1, Me.ToolStripTextBox1})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1008, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(27, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox1.Text = "sdfg"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 762)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiledsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbproinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LiledsDataSet As invent.asp.liledsDataSet
    Friend WithEvents TbproinfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_proinfoTableAdapter As invent.asp.liledsDataSetTableAdapters.tb_proinfoTableAdapter
    Friend WithEvents OrderNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StoreHouseIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileInfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileInmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SysTiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecognitionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox

End Class
