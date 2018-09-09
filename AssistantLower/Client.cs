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
    public partial class Client : Form
    {
        string Selected;

        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            


            //------------------------------------------------------------------------------------------------------------------
            try
            {
                Comm.CommandText = "Select * From Client";
                DataSet Set = new DataSet();
                SqlDataAdapter Adapt = new SqlDataAdapter(Comm);
                Comm.Connection = Conn;
                Adapt.Fill(Set);

                for (int i = 0; i < Set.Tables[0].Rows.Count; i++)
                {
                    if (Set.Tables[0].Rows[i][0].ToString().Trim() == TxtAddName.Text)
                    {
                        MessageBox.Show("هذا العميل موجود مسبقاً", "خطأ");
                        throw new Exception();
                    }
                }


                //------------------------------------------------------------------------------------------------------------------

                Comm.Connection = Conn;
                Comm.CommandText = "INSERT INTO Client (CName, CNationalID, CAddress, CTel) VALUES (@Name,@ID,@Address,@Tel)";

                SqlParameter[] Prams = new SqlParameter[4];
                Prams[0] = new SqlParameter("@Name", TxtAddName.Text);
                Prams[1] = new SqlParameter("@ID", TxtAddID.Text);
                Prams[2] = new SqlParameter("@Address", TxtAddAddress.Text);
                Prams[3] = new SqlParameter("@Tel", TxtAddTel.Text);
                Comm.Parameters.AddRange(Prams);

                Conn.Open();

                int Es = Comm.ExecuteNonQuery();

                if (Es > 0)
                {
                    MessageBox.Show("تم حفظ الموكل بنجاح", "تم");
                    TxtAddName.Text = "";
                    TxtAddTel.Text = "";
                    TxtAddID.Text = "";
                    TxtAddAddress.Text = "";

                }
                else
                {
                    MessageBox.Show("حدث خطأ يرجى إعادة المحاولة", "خطأ");
                }


                Conn.Close();

            }

            catch { }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = "SELECT CName, CNationalID, CAddress, CTel FROM Client WHERE CName = '" + CmbEditName.Text + "'";
            Comm.Connection = Conn;
            
            Conn.Open();


            SqlDataReader Rd = Comm.ExecuteReader();
            Rd.Read();
            TxtEditAddress.Text = Rd["Caddress"].ToString();
            TxtEditID.Text = Rd["CNationalID"].ToString();
            TxtEditTel.Text = Rd["CTel"].ToString();

            Conn.Close();

        }

        private void Client_Load(object sender, EventArgs e)
        {
            CmbEditName.Items.Clear();
            CmbDelName.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = "SELECT * From Client";
            Comm.Connection = Conn;
            
            Conn.Open();

            SqlDataReader Rd = Comm.ExecuteReader();
            while(Rd.Read())
            {
                CmbEditName.Items.Add(Rd["Cname"].ToString());
                CmbDelName.Items.Add(Rd["Cname"].ToString());
            }

            Conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = "Delete From Client Where CName = '" + CmbDelName.Text + "'";
            Comm.Connection = Conn;

            Conn.Open();
            int Es = Comm.ExecuteNonQuery();
            if (Es > 0)
            {
                MessageBox.Show("تم حذف العميل بنجاح", "تم");
                TxtDelAdrs.Text = "";
                TxtDelID.Text = "";
                TxtDelTel.Text = "";

                CmbEditName.Items.Clear();
                CmbDelName.Items.Clear();

                Comm.CommandText = "SELECT * From Client";
                Comm.Connection = Conn;
             
                SqlDataReader Rd = Comm.ExecuteReader();
                while (Rd.Read())
                {
                    CmbEditName.Items.Add(Rd["Cname"].ToString());
                    CmbDelName.Items.Add(Rd["Cname"].ToString());
                }

               
            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية الحذف ، يرجى إعادة المحاولة","خطأ");
            }
            Conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selected = CmbEditName.SelectedItem.ToString();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "UPDATE Client SET CName = @Name, CNationalID = @ID, CAddress = @Adrs, CTel = @Tel where CName = '" + Selected + "'";

            SqlParameter[] Prams = new SqlParameter[4];
            Prams[0] = new SqlParameter("@name", CmbEditName.Text);
            Prams[1] = new SqlParameter("@ID", TxtEditID.Text);
            Prams[2] = new SqlParameter("@Adrs", TxtEditAddress.Text);
            Prams[3] = new SqlParameter("@Tel", TxtEditTel.Text);
            Comm.Parameters.AddRange(Prams);

            Conn.Open();

            int Es = Comm.ExecuteNonQuery();

            if (Es > 0)
            {
                MessageBox.Show("تمت عملية التعديل بنجاح", "تم");
            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية التعديل يرجى إعادة المحاولة","خطأ");
            }

            Conn.Close();

      }

        private void CmbDelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = "SELECT CName, CNationalID, CAddress, CTel FROM Client WHERE CName = '" + CmbDelName.Text + "'";
            Comm.Connection = Conn;

            Conn.Open();


            SqlDataReader Rd = Comm.ExecuteReader();
            Rd.Read();
            TxtDelAdrs.Text = Rd["Caddress"].ToString();
            TxtDelID.Text = Rd["CNationalID"].ToString();
            TxtDelTel.Text = Rd["CTel"].ToString();

            Conn.Close();
        }
    }
}
