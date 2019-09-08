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
    public partial class Dashboard : Form
    {
        public string name;
        public string type;
        public Dashboard(string n, string user)
        {
            InitializeComponent();
            this.name = n;
            this.type = user;
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 itemss = new Form1();
            itemss.Show();

        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill billobj = new Bill(name);
            billobj.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //if (type == "admin")
           // {
            //    itemsToolStripMenuItem.Visible = true;

          //  }
           // else
           // {
               // itemsToolStripMenuItem.Visible = false;

            //}
        }

       

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
            login logout = new login();
            logout.ShowDialog();
        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BllGeneration b = new BllGeneration();
            b.ShowDialog();

        }
    }
}
