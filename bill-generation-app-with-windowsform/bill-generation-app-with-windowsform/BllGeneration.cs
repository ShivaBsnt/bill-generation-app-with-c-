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
    public partial class BllGeneration : Form
    {
        public string currentuser;
       
        public double total;
        public double totalafvat;
        public double grandttl;
        public int currentid;

        DateTime today= DateTime.Now;
        Connection conn = new Connection();


        public BllGeneration(/*string n,  double ttl, double tft, double grand, int idforbill*/)
        {
            InitializeComponent();
            //this.currentuser = n;
           // this.total = ttl;
           // this.totalafvat = tft;
            //this.grandttl = grand;
           // this.currentid = idforbill;
            

        }

        private void BllGeneration_Load(object sender, EventArgs e)
        {
            cname.Text = currentuser;

           // ttl.Text = total.ToString();
    
           // gt.Text = grandttl.ToString();
           // staxt.Text = totalafvat.ToString();
           // currentdate.Text = today.ToShortDateString();

            Billing b = new Billing();
            DataTable bills = b.showBills();
            dataGridView2.DataSource = bills;

    
        
            


         
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string val = dataGridView2.SelectedCells[0].Value.ToString();
            if (val.Equals("show"))
            {
                int id = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
               ShowBill sb = new ShowBill(id);
               sb.ShowDialog();
            }
        }

        private void Employee(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            Billing b = new Billing();
            DataTable bills = b.searchBillsByCustomer(textBox1.Text);
            dataGridView2.DataSource = bills;
        }

        private void label11_Click(object sender, EventArgs e)
        {
                    }
    }
}
