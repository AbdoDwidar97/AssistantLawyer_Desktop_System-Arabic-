namespace FormLogin
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchClName = new System.Windows.Forms.ComboBox();
            this.CmbSearchCaseNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridCase = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COpponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GridSessions = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demands = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اختر اسم الموكل :";
            // 
            // cmbSearchClName
            // 
            this.cmbSearchClName.FormattingEnabled = true;
            this.cmbSearchClName.Location = new System.Drawing.Point(315, 48);
            this.cmbSearchClName.Name = "cmbSearchClName";
            this.cmbSearchClName.Size = new System.Drawing.Size(218, 21);
            this.cmbSearchClName.TabIndex = 1;
            this.cmbSearchClName.SelectedIndexChanged += new System.EventHandler(this.cmbSearchClName_SelectedIndexChanged);
            // 
            // CmbSearchCaseNo
            // 
            this.CmbSearchCaseNo.FormattingEnabled = true;
            this.CmbSearchCaseNo.Location = new System.Drawing.Point(26, 48);
            this.CmbSearchCaseNo.Name = "CmbSearchCaseNo";
            this.CmbSearchCaseNo.Size = new System.Drawing.Size(218, 21);
            this.CmbSearchCaseNo.TabIndex = 3;
            this.CmbSearchCaseNo.SelectedIndexChanged += new System.EventHandler(this.CmbSearchCaseNo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "اختر رقم القضية :";
            // 
            // GridCase
            // 
            this.GridCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.COpponent,
            this.AuthorizationNo,
            this.CourtName});
            this.GridCase.Location = new System.Drawing.Point(26, 75);
            this.GridCase.Name = "GridCase";
            this.GridCase.Size = new System.Drawing.Size(507, 131);
            this.GridCase.TabIndex = 4;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "الموضوع";
            this.Subject.Name = "Subject";
            // 
            // COpponent
            // 
            this.COpponent.HeaderText = "اسم الخصم";
            this.COpponent.Name = "COpponent";
            // 
            // AuthorizationNo
            // 
            this.AuthorizationNo.HeaderText = "رقم التوكيل";
            this.AuthorizationNo.Name = "AuthorizationNo";
            // 
            // CourtName
            // 
            this.CourtName.HeaderText = "اسم المحكمة";
            this.CourtName.Name = "CourtName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "القضايا :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "الجلسات :";
            // 
            // GridSessions
            // 
            this.GridSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Decision,
            this.Demands});
            this.GridSessions.Location = new System.Drawing.Point(26, 212);
            this.GridSessions.Name = "GridSessions";
            this.GridSessions.Size = new System.Drawing.Size(507, 145);
            this.GridSessions.TabIndex = 6;
            // 
            // Date
            // 
            this.Date.HeaderText = "التاريخ";
            this.Date.Name = "Date";
            // 
            // Decision
            // 
            this.Decision.HeaderText = "القرار";
            this.Decision.Name = "Decision";
            // 
            // Demands
            // 
            this.Demands.HeaderText = "الطلبات";
            this.Demands.Name = "Demands";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "تقارير";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GridSessions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridCase);
            this.Controls.Add(this.CmbSearchCaseNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSearchClName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchClName;
        private System.Windows.Forms.ComboBox CmbSearchCaseNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridCase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn COpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demands;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourtName;
        private System.Windows.Forms.Button button1;
    }
}