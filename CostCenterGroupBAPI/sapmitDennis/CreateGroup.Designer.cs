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
            this.createGridView = new System.Windows.Forms.DataGridView();
            this.createCost_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createGroupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HierLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createValcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.createGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createGridView
            // 
            this.createGridView.AllowUserToAddRows = false;
            this.createGridView.AllowUserToDeleteRows = false;
            this.createGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createCost_Area,
            this.createGroupname,
            this.HierLevel,
            this.createValcount,
            this.createDescript});
            this.createGridView.Location = new System.Drawing.Point(20, 129);
            this.createGridView.Margin = new System.Windows.Forms.Padding(2);
            this.createGridView.Name = "createGridView";
            this.createGridView.RowTemplate.Height = 24;
            this.createGridView.Size = new System.Drawing.Size(675, 122);
            this.createGridView.TabIndex = 11;
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
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(647, 309);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(112, 19);
            this.createBtn.TabIndex = 12;
            this.createBtn.Text = "create CostCenter";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.createGridView);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            ((System.ComponentModel.ISupportInitialize)(this.createGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView createGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn createCost_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn createGroupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn HierLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn createValcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDescript;
        private System.Windows.Forms.Button createBtn;
    }
}