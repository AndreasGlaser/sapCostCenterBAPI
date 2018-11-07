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
            this.lbl1 = new System.Windows.Forms.Label();
            this.getListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(54, 45);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.getListBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getListBtn.Name = "getListBtn";
            this.getListBtn.Size = new System.Drawing.Size(56, 19);
            this.getListBtn.TabIndex = 2;
            this.getListBtn.Text = "GetList";
            this.getListBtn.UseVisualStyleBackColor = true;
            this.getListBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(2, 0);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Description";
            // 
            // getListBox
            // 
            this.getListBox.FormattingEnabled = true;
            this.getListBox.Location = new System.Drawing.Point(3, 28);
            this.getListBox.Name = "getListBox";
            this.getListBox.Size = new System.Drawing.Size(213, 225);
            this.getListBox.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.getListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(318, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.557377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.44262F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 385);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.getListBtn);
            this.Controls.Add(this.connectionlbl);
            this.Controls.Add(this.loginbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label connectionlbl;
        private System.Windows.Forms.Button getListBtn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox getListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

