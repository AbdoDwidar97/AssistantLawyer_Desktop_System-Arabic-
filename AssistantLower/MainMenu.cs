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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            Client Cl = new Client();
            Cl.TopLevel = false;
            TbClient.Controls.Add(Cl);
            Cl.Show();

            Opponent Opp = new Opponent();
            Opp.TopLevel = false;
            TbOppo.Controls.Add(Opp);
            Opp.Show();

            Case Ca = new Case();
            Ca.TopLevel = false;
            TbCase.Controls.Add(Ca);
            Ca.Show();

            SearchForm Sf = new SearchForm();
            Sf.TopLevel = false;
            TbSearch.Controls.Add(Sf);
            Sf.Show();

        }

              
        
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {


                DialogResult msg = MessageBox.Show("Do You Really Want To Exit ?", "Exit", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    Application.Exit();

                }
                else
                {
                    e.Cancel = true;
                }


            }
            catch { }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        
        
    }
}
