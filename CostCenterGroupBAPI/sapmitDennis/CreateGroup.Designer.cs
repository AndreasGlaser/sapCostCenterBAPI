namespace CostCenterGroupBAPI
{
    partial class CreateGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroup));
            this.createGridView = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.createCost_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createGroupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HierLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createValcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.createGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createGridView
            // 
            this.createGridView.AllowUserToAddRows = false;
            this.createGridView.AllowUserToDeleteRows = false;
            this.createGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.createGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createCost_Area,
            this.createGroupname,
            this.HierLevel,
            this.createValcount,
            this.createDescript});
            this.createGridView.EnableHeadersVisualStyles = false;
            this.createGridView.Location = new System.Drawing.Point(2, 2);
            this.createGridView.Margin = new System.Windows.Forms.Padding(2);
            this.createGridView.Name = "createGridView";
            this.createGridView.RowHeadersVisible = false;
            this.createGridView.RowTemplate.Height = 24;
            this.createGridView.Size = new System.Drawing.Size(659, 99);
            this.createGridView.TabIndex = 11;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(2, 134);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(112, 19);
            this.createBtn.TabIndex = 12;
            this.createBtn.Text = "create CostCenter";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.createGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.createBtn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 160);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // createCost_Area
            // 
            this.createCost_Area.Frozen = true;
            this.createCost_Area.HeaderText = "Cost_Area";
            this.createCost_Area.Name = "createCost_Area";
            // 
            // createGroupname
            // 
            this.createGroupname.Frozen = true;
            this.createGroupname.HeaderText = "Groupname";
            this.createGroupname.Name = "createGroupname";
            // 
            // HierLevel
            // 
            this.HierLevel.Frozen = true;
            this.HierLevel.HeaderText = "Hierarchy Level";
            this.HierLevel.Name = "HierLevel";
            // 
            // createValcount
            // 
            this.createValcount.Frozen = true;
            this.createValcount.HeaderText = "Valcount";
            this.createValcount.Name = "createValcount";
            // 
            // createDescript
            // 
            this.createDescript.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createDescript.HeaderText = "Descript";
            this.createDescript.Name = "createDescript";
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 184);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGroup";
            ((System.ComponentModel.ISupportInitialize)(this.createGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView createGridView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createCost_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn createGroupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn HierLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn createValcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDescript;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}