namespace CostCenterGroupBAPI
{
    partial class Overview
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.getListBtn = new System.Windows.Forms.Button();
            this.getListGridView = new System.Windows.Forms.DataGridView();
            this.Cost_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostAreaSearch = new System.Windows.Forms.TextBox();
            this.getDetailBtn = new System.Windows.Forms.Button();
            this.getDetailGridView = new System.Windows.Forms.DataGridView();
            this.Groupname2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HierarchyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateGroupBtn = new System.Windows.Forms.Button();
            this.AddNodeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.getListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // getListBtn
            // 
            this.getListBtn.Location = new System.Drawing.Point(27, 40);
            this.getListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.getListBtn.Name = "getListBtn";
            this.getListBtn.Size = new System.Drawing.Size(56, 19);
            this.getListBtn.TabIndex = 2;
            this.getListBtn.Text = "GetList";
            this.getListBtn.UseVisualStyleBackColor = true;
            this.getListBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // getListGridView
            // 
            this.getListGridView.AllowUserToAddRows = false;
            this.getListGridView.AllowUserToDeleteRows = false;
            this.getListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cost_Area,
            this.Groupname,
            this.Description});
            this.getListGridView.Location = new System.Drawing.Point(27, 91);
            this.getListGridView.Name = "getListGridView";
            this.getListGridView.ReadOnly = true;
            this.getListGridView.Size = new System.Drawing.Size(386, 354);
            this.getListGridView.TabIndex = 6;
            this.getListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getListGridView_CellContentClick);
            // 
            // Cost_Area
            // 
            this.Cost_Area.FillWeight = 70F;
            this.Cost_Area.HeaderText = "Cost_Area";
            this.Cost_Area.Name = "Cost_Area";
            this.Cost_Area.ReadOnly = true;
            this.Cost_Area.Width = 70;
            // 
            // Groupname
            // 
            this.Groupname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Groupname.FillWeight = 50F;
            this.Groupname.HeaderText = "Groupname";
            this.Groupname.Name = "Groupname";
            this.Groupname.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 100;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // CostAreaSearch
            // 
            this.CostAreaSearch.Location = new System.Drawing.Point(138, 39);
            this.CostAreaSearch.Name = "CostAreaSearch";
            this.CostAreaSearch.Size = new System.Drawing.Size(100, 20);
            this.CostAreaSearch.TabIndex = 7;
            this.CostAreaSearch.Text = "1000";
            this.CostAreaSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // getDetailBtn
            // 
            this.getDetailBtn.Location = new System.Drawing.Point(435, 40);
            this.getDetailBtn.Name = "getDetailBtn";
            this.getDetailBtn.Size = new System.Drawing.Size(75, 23);
            this.getDetailBtn.TabIndex = 8;
            this.getDetailBtn.Text = "Get Detail";
            this.getDetailBtn.UseVisualStyleBackColor = true;
            this.getDetailBtn.Click += new System.EventHandler(this.getDetailBtn_Click);
            // 
            // getDetailGridView
            // 
            this.getDetailGridView.AllowUserToAddRows = false;
            this.getDetailGridView.AllowUserToDeleteRows = false;
            this.getDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Groupname2,
            this.HierarchyLevel,
            this.ValCount,
            this.Descript});
            this.getDetailGridView.Location = new System.Drawing.Point(435, 91);
            this.getDetailGridView.Name = "getDetailGridView";
            this.getDetailGridView.ReadOnly = true;
            this.getDetailGridView.Size = new System.Drawing.Size(355, 354);
            this.getDetailGridView.TabIndex = 9;
            // 
            // Groupname2
            // 
            this.Groupname2.HeaderText = "Groupname";
            this.Groupname2.Name = "Groupname2";
            this.Groupname2.ReadOnly = true;
            this.Groupname2.Width = 70;
            // 
            // HierarchyLevel
            // 
            this.HierarchyLevel.HeaderText = "Hierarchy Level";
            this.HierarchyLevel.Name = "HierarchyLevel";
            this.HierarchyLevel.ReadOnly = true;
            this.HierarchyLevel.Width = 60;
            // 
            // ValCount
            // 
            this.ValCount.HeaderText = "Value Count";
            this.ValCount.Name = "ValCount";
            this.ValCount.ReadOnly = true;
            this.ValCount.Width = 50;
            // 
            // Descript
            // 
            this.Descript.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descript.HeaderText = "Description";
            this.Descript.Name = "Descript";
            this.Descript.ReadOnly = true;
            // 
            // CreateGroupBtn
            // 
            this.CreateGroupBtn.Location = new System.Drawing.Point(653, 40);
            this.CreateGroupBtn.Name = "CreateGroupBtn";
            this.CreateGroupBtn.Size = new System.Drawing.Size(90, 23);
            this.CreateGroupBtn.TabIndex = 12;
            this.CreateGroupBtn.Text = "Create Group";
            this.CreateGroupBtn.UseVisualStyleBackColor = true;
            this.CreateGroupBtn.Click += new System.EventHandler(this.CreateGroupBtn_Click);
            // 
            // AddNodeBtn
            // 
            this.AddNodeBtn.Location = new System.Drawing.Point(776, 40);
            this.AddNodeBtn.Name = "AddNodeBtn";
            this.AddNodeBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNodeBtn.TabIndex = 13;
            this.AddNodeBtn.Text = "Add Node";
            this.AddNodeBtn.UseVisualStyleBackColor = true;
            this.AddNodeBtn.Click += new System.EventHandler(this.AddNodeBtn_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 495);
            this.Controls.Add(this.AddNodeBtn);
            this.Controls.Add(this.CreateGroupBtn);
            this.Controls.Add(this.getDetailGridView);
            this.Controls.Add(this.getDetailBtn);
            this.Controls.Add(this.CostAreaSearch);
            this.Controls.Add(this.getListGridView);
            this.Controls.Add(this.getListBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Overview";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.getListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDetailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getListBtn;
        private System.Windows.Forms.DataGridView getListGridView;
        private System.Windows.Forms.TextBox CostAreaSearch;
        private System.Windows.Forms.Button getDetailBtn;
        private System.Windows.Forms.DataGridView getDetailGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupname2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HierarchyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descript;
        private System.Windows.Forms.Button CreateGroupBtn;
        private System.Windows.Forms.Button AddNodeBtn;
    }
}

