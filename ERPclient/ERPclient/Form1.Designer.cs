namespace ERPclient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("系统版本");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("系统升级");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("系统编码");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("帮助信息");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("系统信息", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("人员设置");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("权限设置");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("用户管理", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("基础设置", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("文件管理");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("采购信息");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("仓库信息");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("总经办");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("管理部");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("财务部");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("销售部");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("技术部");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("品质部");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("生产部");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("综合项目评估");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("日志查询");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("共享资料");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("个人资料");
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.liledsDataSet = new ERPclient.liledsDataSet();
            this.tbproinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_proinfoTableAdapter = new ERPclient.liledsDataSetTableAdapters.tb_proinfoTableAdapter();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recognitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liledsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproinfoBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.unitdDataGridViewTextBoxColumn,
            this.lastmDataGridViewTextBoxColumn,
            this.totalInDataGridViewTextBoxColumn,
            this.outtotalDataGridViewTextBoxColumn,
            this.intotalDataGridViewTextBoxColumn,
            this.recognitionDataGridViewTextBoxColumn,
            this.statusInDataGridViewTextBoxColumn,
            this.dateIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbproinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(157, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // liledsDataSet
            // 
            this.liledsDataSet.DataSetName = "liledsDataSet";
            this.liledsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbproinfoBindingSource
            // 
            this.tbproinfoBindingSource.DataMember = "tb_proinfo";
            this.tbproinfoBindingSource.DataSource = this.liledsDataSet;
            // 
            // tb_proinfoTableAdapter
            // 
            this.tb_proinfoTableAdapter.ClearBeforeFill = true;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // unitdDataGridViewTextBoxColumn
            // 
            this.unitdDataGridViewTextBoxColumn.DataPropertyName = "Unit_d";
            this.unitdDataGridViewTextBoxColumn.HeaderText = "Unit_d";
            this.unitdDataGridViewTextBoxColumn.Name = "unitdDataGridViewTextBoxColumn";
            // 
            // lastmDataGridViewTextBoxColumn
            // 
            this.lastmDataGridViewTextBoxColumn.DataPropertyName = "Last_m";
            this.lastmDataGridViewTextBoxColumn.HeaderText = "Last_m";
            this.lastmDataGridViewTextBoxColumn.Name = "lastmDataGridViewTextBoxColumn";
            // 
            // totalInDataGridViewTextBoxColumn
            // 
            this.totalInDataGridViewTextBoxColumn.DataPropertyName = "Total_In";
            this.totalInDataGridViewTextBoxColumn.HeaderText = "Total_In";
            this.totalInDataGridViewTextBoxColumn.Name = "totalInDataGridViewTextBoxColumn";
            // 
            // outtotalDataGridViewTextBoxColumn
            // 
            this.outtotalDataGridViewTextBoxColumn.DataPropertyName = "Out_total";
            this.outtotalDataGridViewTextBoxColumn.HeaderText = "Out_total";
            this.outtotalDataGridViewTextBoxColumn.Name = "outtotalDataGridViewTextBoxColumn";
            // 
            // intotalDataGridViewTextBoxColumn
            // 
            this.intotalDataGridViewTextBoxColumn.DataPropertyName = "In_total";
            this.intotalDataGridViewTextBoxColumn.HeaderText = "In_total";
            this.intotalDataGridViewTextBoxColumn.Name = "intotalDataGridViewTextBoxColumn";
            // 
            // recognitionDataGridViewTextBoxColumn
            // 
            this.recognitionDataGridViewTextBoxColumn.DataPropertyName = "Recognition";
            this.recognitionDataGridViewTextBoxColumn.HeaderText = "Recognition";
            this.recognitionDataGridViewTextBoxColumn.Name = "recognitionDataGridViewTextBoxColumn";
            // 
            // statusInDataGridViewTextBoxColumn
            // 
            this.statusInDataGridViewTextBoxColumn.DataPropertyName = "Status_In";
            this.statusInDataGridViewTextBoxColumn.HeaderText = "Status_In";
            this.statusInDataGridViewTextBoxColumn.Name = "statusInDataGridViewTextBoxColumn";
            // 
            // dateIdDataGridViewTextBoxColumn
            // 
            this.dateIdDataGridViewTextBoxColumn.DataPropertyName = "Date_Id";
            this.dateIdDataGridViewTextBoxColumn.HeaderText = "Date_Id";
            this.dateIdDataGridViewTextBoxColumn.Name = "dateIdDataGridViewTextBoxColumn";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 56);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点16";
            treeNode1.Text = "系统版本";
            treeNode2.Name = "节点17";
            treeNode2.Text = "系统升级";
            treeNode3.Name = "节点18";
            treeNode3.Text = "系统编码";
            treeNode4.Name = "节点19";
            treeNode4.Text = "帮助信息";
            treeNode5.Name = "节点15";
            treeNode5.Text = "系统信息";
            treeNode6.Name = "节点24";
            treeNode6.Text = "人员设置";
            treeNode7.Name = "节点25";
            treeNode7.Text = "权限设置";
            treeNode8.Name = "节点20";
            treeNode8.Text = "用户管理";
            treeNode9.Name = "节点0";
            treeNode9.Text = "基础设置";
            treeNode10.Name = "节点1";
            treeNode10.Text = "文件管理";
            treeNode11.Name = "节点2";
            treeNode11.Text = "采购信息";
            treeNode12.Name = "节点3";
            treeNode12.Text = "仓库信息";
            treeNode13.Name = "节点4";
            treeNode13.Text = "总经办";
            treeNode14.Name = "节点5";
            treeNode14.Text = "管理部";
            treeNode15.Name = "节点6";
            treeNode15.Text = "财务部";
            treeNode16.Name = "节点7";
            treeNode16.Text = "销售部";
            treeNode17.Name = "节点8";
            treeNode17.Text = "技术部";
            treeNode18.Name = "节点9";
            treeNode18.Text = "品质部";
            treeNode19.Name = "节点10";
            treeNode19.Text = "生产部";
            treeNode20.Name = "节点11";
            treeNode20.Text = "综合项目评估";
            treeNode21.Name = "节点12";
            treeNode21.Text = "日志查询";
            treeNode22.Name = "节点13";
            treeNode22.Text = "共享资料";
            treeNode23.Name = "节点14";
            treeNode23.Text = "个人资料";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            this.treeView1.Size = new System.Drawing.Size(121, 415);
            this.treeView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.打印ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 92);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存查询ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 库存查询ToolStripMenuItem
            // 
            this.库存查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存入库ToolStripMenuItem});
            this.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem";
            this.库存查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.库存查询ToolStripMenuItem.Text = "库存查询";
            // 
            // 库存入库ToolStripMenuItem
            // 
            this.库存入库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存出库ToolStripMenuItem});
            this.库存入库ToolStripMenuItem.Name = "库存入库ToolStripMenuItem";
            this.库存入库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.库存入库ToolStripMenuItem.Text = "库存入库";
            // 
            // 库存出库ToolStripMenuItem
            // 
            this.库存出库ToolStripMenuItem.Name = "库存出库ToolStripMenuItem";
            this.库存出库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.库存出库ToolStripMenuItem.Text = "库存出库";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打印ToolStripMenuItem.Text = "打印";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1230, 483);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Lileds ERP MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liledsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproinfoBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private liledsDataSet liledsDataSet;
        private System.Windows.Forms.BindingSource tbproinfoBindingSource;
        private ERPclient.liledsDataSetTableAdapters.tb_proinfoTableAdapter tb_proinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recognitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
    }
}

