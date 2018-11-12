namespace CostCenterGroupBAPI
{
    partial class AddNode
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
            this.AddGridView = new System.Windows.Forms.DataGridView();
            this.ControllingArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddGridView
            // 
            this.AddGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ControllingArea,
            this.GroupName,
            this.SubGroupName});
            this.AddGridView.Location = new System.Drawing.Point(37, 100);
            this.AddGridView.Margin = new System.Windows.Forms.Padding(2);
            this.AddGridView.Name = "AddGridView";
            this.AddGridView.RowTemplate.Height = 24;
            this.AddGridView.Size = new System.Drawing.Size(675, 122);
            this.AddGridView.TabIndex = 12;
            // 
            // ControllingArea
            // 
            this.ControllingArea.HeaderText = "ControllingArea";
            this.ControllingArea.Name = "ControllingArea";
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "GroupName";
            this.GroupName.Name = "GroupName";
            // 
            // SubGroupName
            // 
            this.SubGroupName.HeaderText = "SubGroupName";
            this.SubGroupName.Name = "SubGroupName";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(637, 313);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 19);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Add Node to Center";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AddGridView);
            this.Name = "AddNode";
            this.Text = "AddNode";
            ((System.ComponentModel.ISupportInitialize)(this.AddGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AddGridView;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControllingArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGroupName;
    }
}