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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fundament Infomation")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点3")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点4")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点5")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点6")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点7")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Basic Setting", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.LiledsDataSet = New inventorysys.asp.liledsDataSet
        Me.TbproinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_proinfoTableAdapter = New inventorysys.asp.liledsDataSetTableAdapters.tb_proinfoTableAdapter
        Me.OrderNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OuttotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecognitionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.TreeView1 = New System.Windows.Forms.TreeView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiledsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbproinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNumberDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.UnitdDataGridViewTextBoxColumn, Me.LastmDataGridViewTextBoxColumn, Me.TotalInDataGridViewTextBoxColumn, Me.OuttotalDataGridViewTextBoxColumn, Me.IntotalDataGridViewTextBoxColumn, Me.RecognitionDataGridViewTextBoxColumn, Me.StatusInDataGridViewTextBoxColumn, Me.DateIdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbproinfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(195, 86)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(1260, 551)
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
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "Product_name"
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        '
        'UnitdDataGridViewTextBoxColumn
        '
        Me.UnitdDataGridViewTextBoxColumn.DataPropertyName = "Unit_d"
        Me.UnitdDataGridViewTextBoxColumn.HeaderText = "Unit_d"
        Me.UnitdDataGridViewTextBoxColumn.Name = "UnitdDataGridViewTextBoxColumn"
        '
        'LastmDataGridViewTextBoxColumn
        '
        Me.LastmDataGridViewTextBoxColumn.DataPropertyName = "Last_m"
        Me.LastmDataGridViewTextBoxColumn.HeaderText = "Last_m"
        Me.LastmDataGridViewTextBoxColumn.Name = "LastmDataGridViewTextBoxColumn"
        '
        'TotalInDataGridViewTextBoxColumn
        '
        Me.TotalInDataGridViewTextBoxColumn.DataPropertyName = "Total_In"
        Me.TotalInDataGridViewTextBoxColumn.HeaderText = "Total_In"
        Me.TotalInDataGridViewTextBoxColumn.Name = "TotalInDataGridViewTextBoxColumn"
        '
        'OuttotalDataGridViewTextBoxColumn
        '
        Me.OuttotalDataGridViewTextBoxColumn.DataPropertyName = "Out_total"
        Me.OuttotalDataGridViewTextBoxColumn.HeaderText = "Out_total"
        Me.OuttotalDataGridViewTextBoxColumn.Name = "OuttotalDataGridViewTextBoxColumn"
        '
        'IntotalDataGridViewTextBoxColumn
        '
        Me.IntotalDataGridViewTextBoxColumn.DataPropertyName = "In_total"
        Me.IntotalDataGridViewTextBoxColumn.HeaderText = "In_total"
        Me.IntotalDataGridViewTextBoxColumn.Name = "IntotalDataGridViewTextBoxColumn"
        '
        'RecognitionDataGridViewTextBoxColumn
        '
        Me.RecognitionDataGridViewTextBoxColumn.DataPropertyName = "Recognition"
        Me.RecognitionDataGridViewTextBoxColumn.HeaderText = "Recognition"
        Me.RecognitionDataGridViewTextBoxColumn.Name = "RecognitionDataGridViewTextBoxColumn"
        '
        'StatusInDataGridViewTextBoxColumn
        '
        Me.StatusInDataGridViewTextBoxColumn.DataPropertyName = "Status_In"
        Me.StatusInDataGridViewTextBoxColumn.HeaderText = "Status_In"
        Me.StatusInDataGridViewTextBoxColumn.Name = "StatusInDataGridViewTextBoxColumn"
        '
        'DateIdDataGridViewTextBoxColumn
        '
        Me.DateIdDataGridViewTextBoxColumn.DataPropertyName = "Date_Id"
        Me.DateIdDataGridViewTextBoxColumn.HeaderText = "Date_Id"
        Me.DateIdDataGridViewTextBoxColumn.Name = "DateIdDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1508, 25)
        Me.FillToolStrip.TabIndex = 2
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(47, 22)
        Me.FillToolStripButton.Text = "Check"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(2, 48)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "节点1"
        TreeNode1.Text = "Fundament Infomation"
        TreeNode2.Name = "节点3"
        TreeNode2.Text = "节点3"
        TreeNode3.Name = "节点4"
        TreeNode3.Text = "节点4"
        TreeNode4.Name = "节点5"
        TreeNode4.Text = "节点5"
        TreeNode5.Name = "节点6"
        TreeNode5.Text = "节点6"
        TreeNode6.Name = "节点7"
        TreeNode6.Text = "节点7"
        TreeNode7.Name = "节点0"
        TreeNode7.Text = "Basic Setting"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.TreeView1.Size = New System.Drawing.Size(188, 770)
        Me.TreeView1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1508, 1005)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Lileds Inventory System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiledsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbproinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LiledsDataSet As inventorysys.asp.liledsDataSet
    Friend WithEvents TbproinfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_proinfoTableAdapter As inventorysys.asp.liledsDataSetTableAdapters.tb_proinfoTableAdapter
    Friend WithEvents OrderNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OuttotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecognitionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Public WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
