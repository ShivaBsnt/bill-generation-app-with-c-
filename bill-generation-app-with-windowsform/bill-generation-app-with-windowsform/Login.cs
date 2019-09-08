using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gried_view_table
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        Logininfo log = new Logininfo();
        private void button2_Click(object sender, EventArgs e)
        {
            log.Usertype = usrtype.Text;
            log.Userid = usr.Text;
            log.Password = psw.Text;

            log.Storeinfo();
            MessageBox.Show("sucessfully registered");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Logininfo log = new Logininfo();
            log.Useridlogin = usr.Text;
            log.Passwordlogin = psw.Text;
          //  MessageBox.Show(log.Useridlogin + log.Passwordlogin);

            DataTable dt = log.loginuser();
            

            if (dt.Rows.Count > 0)
            {
                int idforuser = int.Parse(dt.Rows[0][0].ToString());
                string usertype = dt.Rows[0][2].ToString();
                Dashboard db = new Dashboard(log.Useridlogin,usertype);
                db.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("forget password?");
            }
        }
    }
}
