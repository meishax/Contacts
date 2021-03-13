namespace 学生通讯录
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("计算机科学与技术");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("信息安全");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("电子信息科学与技术");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("全部专业", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_add = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_delete = new System.Windows.Forms.ToolStripButton();
            this.toolstrip_search = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_back = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_add,
            this.toolStrip_edit,
            this.toolStrip_delete,
            this.toolstrip_search,
            this.toolStrip_save,
            this.toolStrip_back});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1672, 94);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_add
            // 
            this.toolStrip_add.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_add.Image")));
            this.toolStrip_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_add.Name = "toolStrip_add";
            this.toolStrip_add.Size = new System.Drawing.Size(43, 91);
            this.toolStrip_add.Text = "添加";
            this.toolStrip_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_add.Click += new System.EventHandler(this.toolStrip_add_Click);
            // 
            // toolStrip_edit
            // 
            this.toolStrip_edit.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_edit.Image")));
            this.toolStrip_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_edit.Name = "toolStrip_edit";
            this.toolStrip_edit.RightToLeftAutoMirrorImage = true;
            this.toolStrip_edit.Size = new System.Drawing.Size(43, 91);
            this.toolStrip_edit.Text = "编辑";
            this.toolStrip_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_edit.Click += new System.EventHandler(this.toolStrip_edit_Click);
            // 
            // toolStrip_delete
            // 
            this.toolStrip_delete.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_delete.Image")));
            this.toolStrip_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_delete.Name = "toolStrip_delete";
            this.toolStrip_delete.Size = new System.Drawing.Size(43, 91);
            this.toolStrip_delete.Text = "删除";
            this.toolStrip_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_delete.Click += new System.EventHandler(this.toolStrip_delete_Click);
            // 
            // toolstrip_search
            // 
            this.toolstrip_search.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_search.Image")));
            this.toolstrip_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrip_search.Name = "toolstrip_search";
            this.toolstrip_search.Size = new System.Drawing.Size(43, 91);
            this.toolstrip_search.Text = "查找";
            this.toolstrip_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolstrip_search.Click += new System.EventHandler(this.toolstrip_search_Click);
            // 
            // toolStrip_save
            // 
            this.toolStrip_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_save.Image")));
            this.toolStrip_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_save.Name = "toolStrip_save";
            this.toolStrip_save.Size = new System.Drawing.Size(43, 91);
            this.toolStrip_save.Text = "备份";
            this.toolStrip_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_save.Click += new System.EventHandler(this.toolStrip_save_Click);
            // 
            // toolStrip_back
            // 
            this.toolStrip_back.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_back.Image")));
            this.toolStrip_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_back.Name = "toolStrip_back";
            this.toolStrip_back.Size = new System.Drawing.Size(43, 91);
            this.toolStrip_back.Text = "恢复";
            this.toolStrip_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_back.Click += new System.EventHandler(this.toolStrip_back_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 94);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1672, 527);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "计算机科学与技术";
            treeNode2.Name = "节点2";
            treeNode2.Text = "信息安全";
            treeNode3.Name = "节点3";
            treeNode3.Text = "电子信息科学与技术";
            treeNode4.Name = "节点0";
            treeNode4.Text = "全部专业";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(294, 527);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1374, 527);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1672, 621);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myContracts";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_add;
        private System.Windows.Forms.ToolStripButton toolStrip_edit;
        private System.Windows.Forms.ToolStripButton toolStrip_delete;
        private System.Windows.Forms.ToolStripButton toolstrip_search;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripButton toolStrip_save;
        private System.Windows.Forms.ToolStripButton toolStrip_back;
    }
}

