namespace sapmitDennis
{
    partial class Form1
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
            this.Cost_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostAreaSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.getListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(54, 45);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(56, 19);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectionlbl
            // 
            this.connectionlbl.AutoSize = true;
            this.connectionlbl.Location = new System.Drawing.Point(148, 48);
            this.connectionlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectionlbl.Name = "connectionlbl";
            this.connectionlbl.Size = new System.Drawing.Size(77, 13);
            this.connectionlbl.TabIndex = 1;
            this.connectionlbl.Text = "not Connected";
            this.connectionlbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // getListBtn
            // 
            this.getListBtn.Location = new System.Drawing.Point(318, 28);
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
            this.getListGridView.Location = new System.Drawing.Point(305, 110);
            this.getListGridView.Name = "getListGridView";
            this.getListGridView.ReadOnly = true;
            this.getListGridView.Size = new System.Drawing.Size(458, 275);
            this.getListGridView.TabIndex = 6;
            // 
            // Cost_Area
            // 
            this.Cost_Area.HeaderText = "Cost_Area";
            this.Cost_Area.Name = "Cost_Area";
            this.Cost_Area.ReadOnly = true;
            // 
            // Groupname
            // 
            this.Groupname.HeaderText = "Groupname";
            this.Groupname.Name = "Groupname";
            this.Groupname.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // CostAreaSearch
            // 
            this.CostAreaSearch.Location = new System.Drawing.Point(431, 26);
            this.CostAreaSearch.Name = "CostAreaSearch";
            this.CostAreaSearch.Size = new System.Drawing.Size(100, 20);
            this.CostAreaSearch.TabIndex = 7;
            this.CostAreaSearch.Text = "1000";
            this.CostAreaSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.CostAreaSearch);
            this.Controls.Add(this.getListGridView);
            this.Controls.Add(this.getListBtn);
            this.Controls.Add(this.connectionlbl);
            this.Controls.Add(this.loginbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.getListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label connectionlbl;
        private System.Windows.Forms.Button getListBtn;
        private System.Windows.Forms.DataGridView getListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TextBox CostAreaSearch;
    }
}

