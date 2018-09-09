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
    public partial class Case : Form
    {
        public Case()
        {
            InitializeComponent();
        }

        private void Case_Load(object sender, EventArgs e)
        {
            
        }

        private void RBAddCase_CheckedChanged(object sender, EventArgs e)
        {
            GrbCaseData.Enabled = true;
            GrbClOppData.Enabled = true;
            GrbSession.Enabled = false;
            BtnAddCase.Enabled = true;
            BtnAddSession.Enabled = false;
            CmbCname.Items.Clear();
            CmbOname.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            //----------------------------------------------------------
            Comm.CommandText = "SELECT * FROM Client";
            SqlDataReader Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbCname.Items.Add(Rd["CName"].ToString());
            }

            Rd.Close();

            //----------------------------------------------------------
            Comm.CommandText = "SELECT * FROM Opponent";
            Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbOname.Items.Add(Rd["OName"].ToString());
            }


            Conn.Close();
        }

        private void RBAddSession_CheckedChanged(object sender, EventArgs e)
        {
            GrbCaseData.Enabled = false;
            GrbClOppData.Enabled = false;
            GrbSession.Enabled = true;
            BtnAddCase.Enabled = false;
            BtnAddSession.Enabled = true;
            CmbCaseNum.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "SELECT  [Case].* FROM [Case]";
            SqlDataReader Rd = Comm.ExecuteReader();

            while (Rd.Read())
            {
                CmbCaseNum.Items.Add(Rd["CaseNo"].ToString());
            }

            
        }

        private void BtnAddCase_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "INSERT INTO [Case] (CaseNo, Subject, AuthorizationNo, CourtName, Date, CName, Cstatus, Copponent, Ostatus) VALUES (@CaseNo,@Subj,@Autho,@CortName,@Date,@Cname,@Cstatus,@Oppo,@OStatus)";

            SqlParameter[] Prams = new SqlParameter[9];
            Prams[0] = new SqlParameter("@CaseNo", TxtNumSubj.Text);
            Prams[1] = new SqlParameter("@Subj", TxtSubj.Text);
            Prams[2] = new SqlParameter("@Autho", TxtAutho.Text);
            Prams[3] = new SqlParameter("@CortName", TxtCort.Text);
            Prams[4] = new SqlParameter("@Date", DTPDate.Text);
            Prams[5] = new SqlParameter("@Cname", CmbCname.Text);
            Prams[6] = new SqlParameter("@Cstatus", CmbCstatus.Text);
            Prams[7] = new SqlParameter("@Oppo", CmbOname.Text);
            Prams[8] = new SqlParameter("@OStatus", CmbOstatus.Text);
            Comm.Parameters.AddRange(Prams);

            int Eff = Comm.ExecuteNonQuery();
            if (Eff > 0)
            {
                MessageBox.Show("تم إضافة القضية بنجاح", "تم");

                TxtAutho.Text = "";
                TxtCort.Text = "";
                TxtNumSubj.Text = "";
                TxtSubj.Text = "";
                CmbCname.Text = "";
                CmbCstatus.Text = "";
                CmbOname.Text = "";
                CmbOstatus.Text = "";

                
            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية الإضافة ، يرجى إعادة المحاولة","خطأ");
            }

            Conn.Close();

        }

        private void BtnAddSession_Click(object sender, EventArgs e)
        {

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "INSERT INTO Sessions (Date, Decision, Demands, CaseNo) VALUES (@Date,@De,@Dmnd,@CaseNo)";

            SqlParameter[] Prams = new SqlParameter[4];
            Prams[0] = new SqlParameter("@CaseNo", CmbCaseNum.Text);
            Prams[1] = new SqlParameter("@Date", DTPSessionDate.Text);
            Prams[2] = new SqlParameter("@De", TxtDecision.Text);
            Prams[3] = new SqlParameter("@Dmnd", TxtDemands.Text);
            Comm.Parameters.AddRange(Prams);
            

            int aff = Comm.ExecuteNonQuery();
            if (aff > 0)
            {
                MessageBox.Show("تم إضافة الجلسة بنجاح", "تم");
                TxtDecision.Text = "";
                TxtDemands.Text = "";
                CmbCaseNum.Text = "";
            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية الإضافة ، يرجى إعادة المحاولة","خطأ");
            }

            Conn.Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GrbEditCaseData.Enabled = true;
            GrbEditClOppData.Enabled = true;
            BtnEditCase.Enabled = true;
            GrbEditSession.Enabled = false;
            BtnEditSession.Enabled = false;
            CmbEditCname.Items.Clear();
            CmbEditOname.Items.Clear();
            CmbEditCaseNo.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            //----------------------------------------------------------
            Comm.CommandText = "SELECT * FROM Client";
            SqlDataReader Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbEditCname.Items.Add(Rd["CName"].ToString());
            }

            Rd.Close();

            //----------------------------------------------------------
            Comm.CommandText = "SELECT * FROM Opponent";
            Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbEditOname.Items.Add(Rd["OName"].ToString());
            }

            Rd.Close();

            //-----------------------------------------------------------

            Comm.CommandText = "SELECT * FROM [Case]";
            Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbEditCaseNo.Items.Add(Rd["CaseNo"].ToString());
            }

            Conn.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GrbEditCaseData.Enabled = false;
            GrbEditClOppData.Enabled = false;
            BtnEditCase.Enabled = false;
            GrbEditSession.Enabled = true;
            BtnEditSession.Enabled = true;
            CmbEditSessionCaseNo.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "SELECT * FROM [Sessions]";
            SqlDataReader Rd = Comm.ExecuteReader();

            while (Rd.Read())
            {
                CmbEditSessionCaseNo.Items.Add(Rd["CaseNo"].ToString());
            }
            Conn.Close();

        }

        private void CmbEditCaseNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "Select * From [Case] Where CaseNo = '" + CmbEditCaseNo.Text + "'";

            SqlDataReader Rd = Comm.ExecuteReader();
            Rd.Read();
            if (Rd.HasRows)
            {
                TxtEditAutho.Text = Rd["AuthorizationNo"].ToString();
                TxtEditSubj.Text = Rd["Subject"].ToString();
                DTPEditDate.Text = Rd["Date"].ToString();
                CmbEditCname.Text = Rd["CName"].ToString();
                CmbEditCstatus.Text = Rd["Cstatus"].ToString();
                CmbEditOname.Text = Rd["Copponent"].ToString();
                CmbEditOstatus.Text = Rd["Ostatus"].ToString();

            }
            Conn.Close();

        }

        private void CmbEditSessionCaseNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbEditSessionDate.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "Select * From [Sessions] Where CaseNo = '" + CmbEditSessionCaseNo.Text + "'";

            SqlDataReader Rd = Comm.ExecuteReader();

            while (Rd.Read())
            {
                CmbEditSessionDate.Items.Add(Rd["Date"].ToString());
            }
            Conn.Close();

        }

        private void BtnEditCase_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "UPDATE [Case] SET Subject = @Subj, AuthorizationNo = @Autho, Date = @Date, CName = @Cname, Cstatus = @Cstatus, Copponent = @Oppo, Ostatus = @Ostatus Where CaseNo = '" + CmbEditCaseNo.Text + "'";

            SqlParameter[] Prams = new SqlParameter[7];
            Prams[0] = new SqlParameter("@Subj", TxtEditSubj.Text);
            Prams[1] = new SqlParameter("@Autho", TxtEditAutho.Text);
            Prams[2] = new SqlParameter("@Date", DTPEditDate.Text);
            Prams[3] = new SqlParameter("@Cname", CmbEditCname.Text);
            Prams[4] = new SqlParameter("@Cstatus", CmbEditCstatus.Text);
            Prams[5] = new SqlParameter("@Oppo", CmbEditOname.Text);
            Prams[6] = new SqlParameter("@OStatus", CmbEditOstatus.Text);
            Comm.Parameters.AddRange(Prams);

            int Eff = Comm.ExecuteNonQuery();
            if (Eff > 0)
            {
                MessageBox.Show("تم تعديل القضية بنجاح", "تم");

                TxtEditAutho.Text = "";
                CmbEditCaseNo.SelectedItem = "";
                TxtEditSubj.Text = "";
                CmbEditCname.SelectedItem = "";
                CmbEditCstatus.SelectedItem = "";
                CmbEditOname.SelectedItem = "";
                CmbEditOstatus.SelectedItem = "";


            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية التعديل ، يرجى إعادة المحاولة", "خطأ");
            }

            Conn.Close();

        }

        private void GrbEditSession_Enter(object sender, EventArgs e)
        {

        }

        private void CmbEditSessionDate_SelectedIndexChanged(object sender, EventArgs e)
        {


            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "Select * From Sessions Where Date = @Date And CaseNo = @CaseNo";
            
            DateTime SeDate = Convert.ToDateTime(CmbEditSessionDate.SelectedItem.ToString());

            SqlParameter[] Prams = new SqlParameter[2];
            Prams[0] = new SqlParameter("@Date", SeDate);
            Prams[1] = new SqlParameter("@CaseNo", CmbEditSessionCaseNo.SelectedItem.ToString());
            Comm.Parameters.AddRange(Prams);


            SqlDataReader Rd = Comm.ExecuteReader();
            Rd.Read();
            if (Rd.HasRows)
            {
                TxtEditDec.Text = Rd["Decision"].ToString();
                TxtEditDemand.Text = Rd["Demands"].ToString();

            }

            Conn.Close();


        }

        private void BtnEditSession_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            DateTime SeDate = DateTime.Parse(CmbEditSessionDate.SelectedItem.ToString());

            Comm.CommandText = "UPDATE Sessions SET Date = @Date, Decision = @De, Demands = @Dmnd, CaseNo = @CaseNo Where Date = @Date And CaseNo = @CaseNo";

            SqlParameter P1 = new SqlParameter("@Date", SeDate);
            SqlParameter P2 = new SqlParameter("@CaseNo", CmbEditCaseNo.SelectedItem.ToString());

            SqlParameter P3 = new SqlParameter("@De", TxtEditDec.Text);
            SqlParameter P4 = new SqlParameter("@Dmnd", TxtEditDemand.Text);

            Comm.Parameters.Add(P4);
            Comm.Parameters.Add(P3);
            Comm.Parameters.Add(P1);
            Comm.Parameters.Add(P2);

            int aff = Comm.ExecuteNonQuery();
            if (aff > 0)
            {
                MessageBox.Show("تم تعديل الجلسة بنجاح", "تم");
                TxtEditDec.Text = "";
                TxtEditDemand.Text = "";
                CmbEditCaseNo.Text = "";
            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية التعديل ، يرجى إعادة المحاولة", "خطأ");
            }

            Conn.Close();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            GrbDelCaseData.Enabled = true;
            GrbDelClOppData.Enabled = true;
            BtnDelCase.Enabled = true;
            GrbDelSession.Enabled = false;
            BtnDelSession.Enabled = false;
            CmbDelCname.Items.Clear();
            CmbDelOname.Items.Clear();
            CmbDelCaseNo.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            //----------------------------------------------------------
            Comm.CommandText = "SELECT * FROM Client";
            SqlDataReader Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbDelCname.Items.Add(Rd["CName"].ToString());
            }

            Rd.Close();

            //----------------------------------------------------------
            Comm.CommandText = "SELECT * FROM Opponent";
            Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbDelOname.Items.Add(Rd["OName"].ToString());
            }

            Rd.Close();

            //-----------------------------------------------------------

            Comm.CommandText = "SELECT * FROM [Case]";
            Rd = Comm.ExecuteReader();
            while (Rd.Read())
            {
                CmbDelCaseNo.Items.Add(Rd["CaseNo"].ToString());
            }

            Conn.Close();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GrbDelCaseData.Enabled = false;
            GrbDelClOppData.Enabled = false;
            BtnDelCase.Enabled = false;
            GrbDelSession.Enabled = true;
            BtnDelSession.Enabled = true;
            CmbDelSessionCaseNo.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "SELECT * FROM [Sessions]";
            SqlDataReader Rd = Comm.ExecuteReader();

            while (Rd.Read())
            {
                CmbDelSessionCaseNo.Items.Add(Rd["CaseNo"].ToString());
            }
            Conn.Close();

        }

        private void CmbDelSessionCaseNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDelSessionDate.Items.Clear();

            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "Select * From [Sessions] Where CaseNo = '" + CmbDelSessionCaseNo.Text + "'";

            SqlDataReader Rd = Comm.ExecuteReader();

            while (Rd.Read())
            {
                CmbDelSessionDate.Items.Add(Rd["Date"].ToString());
            }
            Conn.Close();

        }

        private void CmbDelCaseNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "Select * From [Case] Where CaseNo = '" + CmbDelCaseNo.Text + "'";

            SqlDataReader Rd = Comm.ExecuteReader();
            Rd.Read();
            if (Rd.HasRows)
            {
                TxtDelAutho.Text = Rd["AuthorizationNo"].ToString();
                TxtDelSubj.Text = Rd["Subject"].ToString();
                DTPDelDate.Text = Rd["Date"].ToString();
                CmbDelCname.Text = Rd["CName"].ToString();
                CmbDelCstatus.Text = Rd["Cstatus"].ToString();
                CmbDelOname.Text = Rd["Copponent"].ToString();
                CmbDelOStatus.Text = Rd["Ostatus"].ToString();

            }
            Conn.Close();

        }

        private void BtnDelCase_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
                SqlCommand Comm = new SqlCommand();
                Comm.Connection = Conn;
                Conn.Open();

                Comm.CommandText = "DELETE FROM [Case] WHERE CaseNo = '" + CmbDelCaseNo.Text + "'";


                int Eff = Comm.ExecuteNonQuery();
                if (Eff > 0)
                {
                    MessageBox.Show("تم حذف القضية بنجاح", "تم");

                    TxtDelAutho.Text = "";
                    CmbDelCaseNo.SelectedItem = "";
                    TxtDelSubj.Text = "";
                    CmbDelCname.SelectedItem = "";
                    CmbDelCstatus.SelectedItem = "";
                    CmbDelOname.SelectedItem = "";
                    CmbDelOStatus.SelectedItem = "";


                }
                else
                {
                    MessageBox.Show("حدث خطأ فى عملية الحذف ، يرجى إعادة المحاولة", "خطأ");
                }

                Conn.Close();
            }
            catch
            {
                
            }

        }

        private void CmbDelSessionDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            Comm.CommandText = "Select * From Sessions Where Date = @Date And CaseNo = @CaseNo";

            DateTime SeDate = Convert.ToDateTime(CmbDelSessionDate.Text);

            SqlParameter[] Prams = new SqlParameter[2];
            Prams[0] = new SqlParameter("@Date", SeDate);
            Prams[1] = new SqlParameter("@CaseNo", CmbDelSessionCaseNo.Text);
            Comm.Parameters.AddRange(Prams);


            SqlDataReader Rd = Comm.ExecuteReader();
            Rd.Read();
            if (Rd.HasRows)
            {
                TxtDelDec.Text = Rd["Decision"].ToString();
                TxtDelDemand.Text = Rd["Demands"].ToString();

            }

            Conn.Close();

        }

        private void BtnDelSession_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=ALower;Integrated Security=True");
            SqlCommand Comm = new SqlCommand();
            Comm.Connection = Conn;
            Conn.Open();

            DateTime SeDate = DateTime.Parse(CmbDelSessionDate.Text);

            Comm.CommandText = "DELETE FROM [Sessions] WHERE CaseNo = @CaseNo And Date = @Date";

            SqlParameter P1 = new SqlParameter("@CaseNo", CmbDelSessionCaseNo.SelectedItem.ToString());
            Comm.Parameters.Add(P1);

            SqlParameter P2 = new SqlParameter("@Date", DateTime.Parse(CmbDelSessionDate.SelectedItem.ToString()));
            Comm.Parameters.Add(P2);

            int Eff = Comm.ExecuteNonQuery();
            if (Eff > 0)
            {
                MessageBox.Show("تم حذف الجلسة بنجاح", "تم");

                TxtDelDec.Text = "";
                TxtDelDemand.Text = "";
                CmbDelSessionCaseNo.Text = "";
            }
            else
            {
                MessageBox.Show("حدث خطأ فى عملية الحذف ، يرجى إعادة المحاولة","خطأ");
            }

            Conn.Close();

        }

        
            
    }
}
