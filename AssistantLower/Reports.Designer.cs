namespace FormLogin
{
    partial class Reports
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
            
                this.components = new System.ComponentModel.Container();
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                this.CaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.ALowerDataSet = new ALowerDataSet();
                this.button1 = new System.Windows.Forms.Button();
                this.CmbReportCname = new System.Windows.Forms.ComboBox();
                this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
                this.CaseTableAdapter = new ALowerDataSetTableAdapters.CaseTableAdapter();
                this.button2 = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.CaseBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.ALowerDataSet)).BeginInit();
                this.SuspendLayout();
                // 
                // CaseBindingSource
                // 
                this.CaseBindingSource.DataMember = "Case";
                this.CaseBindingSource.DataSource = this.ALowerDataSet;
                // 
                // ALowerDataSet
                // 
                this.ALowerDataSet.DataSetName = "ALowerDataSet";
                this.ALowerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(245, 14);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(129, 23);
                this.button1.TabIndex = 0;
                this.button1.Text = "الحصول على التقرير";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // CmbReportCname
                // 
                this.CmbReportCname.FormattingEnabled = true;
                this.CmbReportCname.Location = new System.Drawing.Point(14, 16);
                this.CmbReportCname.Name = "CmbReportCname";
                this.CmbReportCname.Size = new System.Drawing.Size(225, 21);
                this.CmbReportCname.TabIndex = 1;
                // 
                // reportViewer1
                // 
                reportDataSource1.Name = "DataSet1";
                reportDataSource1.Value = this.CaseBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormLogin.Report1.rdlc";
                this.reportViewer1.Location = new System.Drawing.Point(14, 43);
                this.reportViewer1.Name = "reportViewer1";
                this.reportViewer1.Size = new System.Drawing.Size(643, 328);
                this.reportViewer1.TabIndex = 2;
                // 
                // CaseTableAdapter
                // 
                this.CaseTableAdapter.ClearBeforeFill = true;
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(568, 377);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(89, 23);
                this.button2.TabIndex = 3;
                this.button2.Text = "رجوع";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                // 
                // Reports
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.White;
                this.ClientSize = new System.Drawing.Size(669, 411);
                this.ControlBox = false;
                this.Controls.Add(this.button2);
                this.Controls.Add(this.reportViewer1);
                this.Controls.Add(this.CmbReportCname);
                this.Controls.Add(this.button1);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Name = "Reports";
                this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Reports";
                this.Load += new System.EventHandler(this.Reports_Load);
                ((System.ComponentModel.ISupportInitialize)(this.CaseBindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.ALowerDataSet)).EndInit();
                this.ResumeLayout(false);
            
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbReportCname;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CaseBindingSource;
        private ALowerDataSet ALowerDataSet;
        private ALowerDataSetTableAdapters.CaseTableAdapter CaseTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}