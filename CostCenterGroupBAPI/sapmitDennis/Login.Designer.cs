namespace CostCenterGroupBAPI
{
    partial class Login
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.connectionlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(88, 62);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(56, 19);
            this.loginbtn.TabIndex = 1;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // connectionlbl
            // 
            this.connectionlbl.AutoSize = true;
            this.connectionlbl.Location = new System.Drawing.Point(229, 68);
            this.connectionlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectionlbl.Name = "connectionlbl";
            this.connectionlbl.Size = new System.Drawing.Size(77, 13);
            this.connectionlbl.TabIndex = 2;
            this.connectionlbl.Text = "not Connected";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 263);
            this.Controls.Add(this.connectionlbl);
            this.Controls.Add(this.loginbtn);
            this.Name = "Login";
            this.Text = "CostCenterGroupBAPI Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label connectionlbl;
    }
}