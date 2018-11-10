namespace sapmitDennis
{
    partial class getDetailDataGrid
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.connectionlbl = new System.Windows.Forms.Label();
            this.getListBtn = new System.Windows.Forms.Button();
            this.getListGridView = new System.Windows.Forms.DataGridView();
            this.CostAreaSearch = new System.Windows.Forms.TextBox();
            this.getDetailBtn = new System.Windows.Forms.Button();
            this.getDetailGridView = new System.Windows.Forms.DataGridView();
            this.Cost_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupname2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HierarchyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createGridView = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.createCost_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createGroupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HierLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createValcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.getListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDetailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(72, 55);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectionlbl
            // 
            this.connectionlbl.AutoSize = true;
            this.connectionlbl.Location = new System.Drawing.Point(197, 59);
            this.connectionlbl.Name = "connectionlbl";
            this.connectionlbl.Size = new System.Drawing.Size(100, 17);
            this.connectionlbl.TabIndex = 1;
            this.connectionlbl.Text = "not Connected";
            this.connectionlbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // getListBtn
            // 
            this.getListBtn.Location = new System.Drawing.Point(648, 34);
            this.getListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getListBtn.Name = "getListBtn";
            this.getListBtn.Size = new System.Drawing.Size(75, 23);
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
            this.getListGridView.Location = new System.Drawing.Point(648, 95);
            this.getListGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getListGridView.Name = "getListGridView";
            this.getListGridView.ReadOnly = true;
            this.getListGridView.Size = new System.Drawing.Size(515, 264);
            this.getListGridView.TabIndex = 6;
            this.getListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getListGridView_CellContentClick);
            // 
            // CostAreaSearch
            // 
            this.CostAreaSearch.Location = new System.Drawing.Point(804, 34);
            this.CostAreaSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CostAreaSearch.Name = "CostAreaSearch";
            this.CostAreaSearch.Size = new System.Drawing.Size(132, 22);
            this.CostAreaSearch.TabIndex = 7;
            this.CostAreaSearch.Text = "1000";
            this.CostAreaSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // getDetailBtn
            // 
            this.getDetailBtn.Location = new System.Drawing.Point(201, 135);
            this.getDetailBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getDetailBtn.Name = "getDetailBtn";
            this.getDetailBtn.Size = new System.Drawing.Size(100, 28);
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
            this.getDetailGridView.Location = new System.Drawing.Point(13, 171);
            this.getDetailGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getDetailGridView.Name = "getDetailGridView";
            this.getDetailGridView.ReadOnly = true;
            this.getDetailGridView.Size = new System.Drawing.Size(580, 170);
            this.getDetailGridView.TabIndex = 9;
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
            // createGridView
            // 
            this.createGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createCost_Area,
            this.createGroupname,
            this.HierLevel,
            this.createValcount,
            this.createDescript});
            this.createGridView.Location = new System.Drawing.Point(36, 395);
            this.createGridView.Name = "createGridView";
            this.createGridView.RowTemplate.Height = 24;
            this.createGridView.Size = new System.Drawing.Size(900, 150);
            this.createGridView.TabIndex = 10;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(963, 522);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(149, 23);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "create CostCenter";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // createCost_Area
            // 
            this.createCost_Area.HeaderText = "Cost_Area";
            this.createCost_Area.Name = "createCost_Area";
            // 
            // createGroupname
            // 
            this.createGroupname.HeaderText = "Groupname";
            this.createGroupname.Name = "createGroupname";
            // 
            // HierLevel
            // 
            this.HierLevel.HeaderText = "Hierarchy Level";
            this.HierLevel.Name = "HierLevel";
            // 
            // createValcount
            // 
            this.createValcount.HeaderText = "Valcount";
            this.createValcount.Name = "createValcount";
            // 
            // createDescript
            // 
            this.createDescript.HeaderText = "Descript";
            this.createDescript.Name = "createDescript";
            // 
            // getDetailDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 609);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.createGridView);
            this.Controls.Add(this.getDetailGridView);
            this.Controls.Add(this.getDetailBtn);
            this.Controls.Add(this.CostAreaSearch);
            this.Controls.Add(this.getListGridView);
            this.Controls.Add(this.getListBtn);
            this.Controls.Add(this.connectionlbl);
            this.Controls.Add(this.loginbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "getDetailDataGrid";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.getListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDetailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label connectionlbl;
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
        private System.Windows.Forms.DataGridView createGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn createCost_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn createGroupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn HierLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn createValcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDescript;
        private System.Windows.Forms.Button createBtn;
    }
}

