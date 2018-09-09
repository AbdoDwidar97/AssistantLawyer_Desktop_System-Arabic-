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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");

            using (SqlCommand Comm = new SqlCommand())
            {

                Comm.Connection = Conn;
                Conn.Open();

                Comm.CommandText = "SELECT UName, Pass FROM User_Accounts WHERE (UName = @Uname) AND (Pass = @Pass)";


                SqlParameter[] Prams = new SqlParameter[2];

                Prams[0] = new SqlParameter("@Uname", TxtName.Text);
                Prams[1] = new SqlParameter("@Pass", TxtPass.Text);

                Comm.Parameters.AddRange(Prams);

                SqlDataReader Rd = Comm.ExecuteReader();
                Rd.Read();



                if (Rd.HasRows)
                {
                    MainMenu Frm = new MainMenu();
                    Frm.Show();
                    this.Hide();
                }


                else MessageBox.Show("إسم المستخدم أو كلمة المرور غير صحيحة");

                Conn.Close();

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUserForm frm = new AddUserForm();
            frm.ShowDialog();
            

        }
    }
}
