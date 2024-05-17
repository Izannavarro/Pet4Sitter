namespace piTest
{
    partial class Dashboard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblNameCharged = new System.Windows.Forms.Label();
            this.lblLangCharged = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(517, 114);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(525, 144);
            this.lblLang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(51, 16);
            this.lblLang.TabIndex = 2;
            this.lblLang.Text = "Idioma:";
            // 
            // lblNameCharged
            // 
            this.lblNameCharged.AutoSize = true;
            this.lblNameCharged.Location = new System.Drawing.Point(588, 114);
            this.lblNameCharged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameCharged.Name = "lblNameCharged";
            this.lblNameCharged.Size = new System.Drawing.Size(0, 16);
            this.lblNameCharged.TabIndex = 3;
            // 
            // lblLangCharged
            // 
            this.lblLangCharged.AutoSize = true;
            this.lblLangCharged.Location = new System.Drawing.Point(588, 144);
            this.lblLangCharged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLangCharged.Name = "lblLangCharged";
            this.lblLangCharged.Size = new System.Drawing.Size(0, 16);
            this.lblLangCharged.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 406);
            this.Controls.Add(this.lblLangCharged);
            this.Controls.Add(this.lblNameCharged);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblNameCharged;
        private System.Windows.Forms.Label lblLangCharged;
    }
}