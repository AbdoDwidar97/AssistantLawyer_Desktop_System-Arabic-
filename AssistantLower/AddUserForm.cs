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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            DataSet Set = new DataSet();

            Set.ReadXml("ManagePWD.xml");

           byte [] decrypt =  Convert.FromBase64String(Set.Tables[0].Rows[0][0].ToString());
           string decryptString = UTF8Encoding.UTF8.GetString(decrypt);

           if (Set.Tables[0].Rows[0][0].ToString() != "" && decryptString == TxtMangePass.Text)
           {
               SqlCommand Comm = new SqlCommand();
               Comm.Connection = Conn;
               Comm.CommandText = "INSERT INTO User_Accounts (UName, Pass) VALUES (@p1,@p2)";

               SqlParameter[] Prams = new SqlParameter[2];
               Prams[0] = new SqlParameter("@p1", TxtName.Text);
               Prams[1] = new SqlParameter("@p2", TxtPass.Text);

               Comm.Parameters.AddRange(Prams);

               Conn.Open();
               int H = Comm.ExecuteNonQuery();

               if (H > 0)
                   MessageBox.Show("تم حفظ المستخدم بنجاح", "تم");

               else MessageBox.Show("لم يتم حفظ المستخدم", "خطأ");

           }
           else
           {
               MessageBox.Show("كلمة مرور الإدارة غير صحيحة");
           }


        }

       
    }
}
