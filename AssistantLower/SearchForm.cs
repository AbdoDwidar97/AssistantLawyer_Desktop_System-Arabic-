using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormLogin
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "SELECT * FROM [Client]";

            SqlDataReader Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                cmbSearchClName.Items.Add(Rd["Cname"].ToString());
            }
            Rd.Close();

            Comm.CommandText = "SELECT * FROM [Case]";

            Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbSearchCaseNo.Items.Add(Rd["CaseNo"].ToString());
            }

            Conn.Close();


        }

        private void cmbSearchClName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridCase.Rows.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "Select * From [Case] Where Cname = @Cname";

            SqlParameter P = new SqlParameter("@Cname", cmbSearchClName.SelectedItem.ToString());
            Comm.Parameters.Add(P);

            SqlDataReader Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                GridCase.Rows.Add(Rd["Subject"].ToString(),Rd["COpponent"].ToString(),Rd["AuthorizationNo"].ToString(),Rd["CourtName"].ToString());
            }

            Conn.Close();

        }

        private void CmbSearchCaseNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridSessions.Rows.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "Select * From [Sessions] Where CaseNo = @CaseNo";

            SqlParameter P = new SqlParameter("@CaseNo", CmbSearchCaseNo.SelectedItem.ToString());
            Comm.Parameters.Add(P);

            SqlDataReader Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                GridSessions.Rows.Add(Rd["Date"].ToString(), Rd["Decision"].ToString(), Rd["Demands"].ToString());
            }

            Conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports Rfrm = new Reports();
            Rfrm.ShowDialog();

        }
    }
}
