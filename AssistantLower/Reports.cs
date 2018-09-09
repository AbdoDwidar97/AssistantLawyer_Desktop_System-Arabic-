using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace FormLogin
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();
            Comm.CommandText = "Select Cname From Client";
            SqlDataReader Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbReportCname.Items.Add(Rd["Cname"].ToString());
            }

            Conn.Close();

            
            // TODO: This line of code loads data into the 'ALowerDataSet.Case' table. You can move, or remove it, as needed.
            this.CaseTableAdapter.Fill(this.ALowerDataSet.Case);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource Rp = new ReportDataSource();

            Rp.Name = "DataSet1";

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "Select * From [Case] Where CName = @Cn";
            SqlParameter P = new SqlParameter("@Cn", CmbReportCname.SelectedItem.ToString());
            Comm.Parameters.Add(P);

            SqlDataAdapter Adapt = new SqlDataAdapter(Comm);
            DataTable t = new DataTable();
            Adapt.Fill(t);

            Rp.Value = t;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Rp);

            reportViewer1.Refresh();
            reportViewer1.RefreshReport();

        }
    }
}
