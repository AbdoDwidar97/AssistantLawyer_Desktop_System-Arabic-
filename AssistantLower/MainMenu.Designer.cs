namespace FormLogin
{
    partial class MainMenu
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
            this.Tb = new System.Windows.Forms.TabControl();
            this.TbClient = new System.Windows.Forms.TabPage();
            this.TbOppo = new System.Windows.Forms.TabPage();
            this.TbCase = new System.Windows.Forms.TabPage();
            this.TbSearch = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb
            // 
            this.Tb.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Tb.Controls.Add(this.TbClient);
            this.Tb.Controls.Add(this.TbOppo);
            this.Tb.Controls.Add(this.TbCase);
            this.Tb.Controls.Add(this.TbSearch);
            this.Tb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb.Location = new System.Drawing.Point(12, 34);
            this.Tb.Multiline = true;
            this.Tb.Name = "Tb";
            this.Tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tb.RightToLeftLayout = true;
            this.Tb.SelectedIndex = 0;
            this.Tb.Size = new System.Drawing.Size(832, 482);
            this.Tb.TabIndex = 0;
            // 
            // TbClient
            // 
            this.TbClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbClient.ImageKey = "(none)";
            this.TbClient.Location = new System.Drawing.Point(25, 4);
            this.TbClient.Name = "TbClient";
            this.TbClient.Padding = new System.Windows.Forms.Padding(3);
            this.TbClient.Size = new System.Drawing.Size(803, 474);
            this.TbClient.TabIndex = 0;
            this.TbClient.Text = "الموكل";
            this.TbClient.UseVisualStyleBackColor = true;
            // 
            // TbOppo
            // 
            this.TbOppo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbOppo.Location = new System.Drawing.Point(25, 4);
            this.TbOppo.Name = "TbOppo";
            this.TbOppo.Padding = new System.Windows.Forms.Padding(3);
            this.TbOppo.Size = new System.Drawing.Size(803, 474);
            this.TbOppo.TabIndex = 1;
            this.TbOppo.Text = "الخصم";
            this.TbOppo.UseVisualStyleBackColor = true;
            // 
            // TbCase
            // 
            this.TbCase.Location = new System.Drawing.Point(25, 4);
            this.TbCase.Name = "TbCase";
            this.TbCase.Padding = new System.Windows.Forms.Padding(3);
            this.TbCase.Size = new System.Drawing.Size(803, 474);
            this.TbCase.TabIndex = 2;
            this.TbCase.Text = "القضية";
            this.TbCase.UseVisualStyleBackColor = true;
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(25, 4);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.TbSearch.Size = new System.Drawing.Size(803, 474);
            this.TbSearch.TabIndex = 3;
            this.TbSearch.Text = "بحث";
            this.TbSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormLogin.Properties.Resources.law01x10;
            this.pictureBox1.Location = new System.Drawing.Point(850, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Tb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tb;
        private System.Windows.Forms.TabPage TbClient;
        private System.Windows.Forms.TabPage TbOppo;
        private System.Windows.Forms.TabPage TbCase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage TbSearch;
    }
}