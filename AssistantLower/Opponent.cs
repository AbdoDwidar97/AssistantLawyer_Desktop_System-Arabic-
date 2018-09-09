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
    public partial class Opponent : Form
    {
        string Selected;
        public Opponent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = "Delete From Opponent Where OName = '" + CmbDelName.Text + "'";
            Comm.Connection = Conn;

            Conn.Open();
            int Es = Comm.ExecuteNonQuery();
            if (Es > 0)
            {
                MessageBox.Show("تم حذف الخصم بنجاح", "تم");
                TxtDelAdrs.Text = "";
                TxtDelTel.Text = "";

                CmbEditName.Items.Clear();
                CmbDelName.Items.Clear();

                Comm.CommandText = "SELECT * From Opponent";
                Comm.Connection = Conn;

                SqlDataReader Rd = Comm.ExecuteReader();
                while (Rd.Read())
                {
                    CmbEditName.Items.Add(Rd["Oname"].ToString());
                    CmbDelName.Items.Add(Rd["Oname"].ToString());
                }


            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية الحذف ، يرجى إعادة المحاولة", "خطأ");
            }
            Conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            


            //------------------------------------------------------------------------------------------------------------------
            try
            {
                Comm.CommandText = "Select * From Opponent";
                DataSet Set = new DataSet();
                SqlDataAdapter Adapt = new SqlDataAdapter(Comm);
                Comm.Connection = Conn;
                Adapt.Fill(Set);

                for (int i = 0; i < Set.Tables[0].Rows.Count; i++)
                {
                    if (Set.Tables[0].Rows[i][0].ToString().Trim() == TxtAddName.Text)
                    {
                        MessageBox.Show("هذا الخصم موجود مسبقاً", "خطأ");
                        throw new Exception();
                    }
                }


                //------------------------------------------------------------------------------------------------------------------

                Comm.Connection = Conn;
                Comm.CommandText = "INSERT INTO Opponent (OName, OAddress, OTel) VALUES (@Name,@Adrs,@Tel)";

                SqlParameter[] Prams = new SqlParameter[3];
                Prams[0] = new SqlParameter("@Name", TxtAddName.Text);
                Prams[1] = new SqlParameter("@Adrs", TxtAddAddress.Text);
                Prams[2] = new SqlParameter("@Tel", TxtAddTel.Text);
                Comm.Parameters.AddRange(Prams);

                Conn.Open();

                int Es = Comm.ExecuteNonQuery();

                if (Es > 0)
                {
                    MessageBox.Show("تم حفظ الخصم بنجاح", "تم");
                    TxtAddName.Text = "";
                    TxtAddTel.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {

            Selected = CmbEditName.SelectedItem.ToString();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");

            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "UPDATE Opponent SET OName = @Name, OAddress = @Adrs, OTel = @Tel where OName = '" + Selected + "'";

            SqlParameter[] Prams = new SqlParameter[3];
            Prams[0] = new SqlParameter("@name", CmbEditName.Text);
            Prams[1] = new SqlParameter("@Adrs", TxtEditAddress.Text);
            Prams[2] = new SqlParameter("@Tel", TxtEditTel.Text);
            Comm.Parameters.AddRange(Prams);

            Conn.Open();

            int Es = Comm.ExecuteNonQuery();

            if (Es > 0)
            {
                MessageBox.Show("تمت عملية التعديل بنجاح", "تم");
            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية التعديل يرجى إعادة المحاولة", "خطأ");
            }

            Conn.Close();


        }

        private void Opponent_Load(object sender, EventArgs e)
        {
            CmbEditName.Items.Clear();
            CmbDelName.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = "SELECT * From Opponent";
            Comm.Connection = Conn;

            Conn.Open();

            SqlDataReader Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbEditName.Items.Add(Rd["Oname"].ToString());
                CmbDelName.Items.Add(Rd["Oname"].ToString());
            }

            Conn.Close();
        }

        private void CmbEditName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = "SELECT OName, OAddress, OTel FROM Opponent WHERE OName = '" + CmbEditName.Text + "'";
            Comm.Connection = Conn;

            Conn.Open();


            SqlDataReader Rd = Comm.ExecuteReader();
            Rd.Read();
            TxtEditAddress.Text = Rd["Oaddress"].ToString();
            TxtEditTel.Text = Rd["OTel"].ToString();

            Conn.Close();

        }

        private void CmbDelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = "SELECT OName, OAddress, OTel FROM Opponent WHERE OName = '" + CmbDelName.Text + "'";
            Comm.Connection = Conn;

            Conn.Open();


            SqlDataReader Rd = Comm.ExecuteReader();
            Rd.Read();
            TxtDelAdrs.Text = Rd["Oaddress"].ToString();
            TxtDelTel.Text = Rd["OTel"].ToString();

            Conn.Close();
        }
    }
}
