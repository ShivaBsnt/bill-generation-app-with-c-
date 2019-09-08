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
    public partial class Bill : Form
    {
        public int idm;
        public string name;
        public string rate;
       
       
        public double total=0;
        double totalaftervat;
        double grandtotal;
        
        public double amount;
        public string usrname;
        public double countr;
        public int totalforbill;
        List<int> items = new List<int>();
        List<int> quantity = new List<int>();
        public int bill_id;
        public int qty;


        public Bill(string n)
        {
            InitializeComponent();
            this.usrname = n;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            item items = new item();
            DataTable dt = items.getmethod();
            dataGridView1.DataSource = dt;
            DateTime today = DateTime.Now;
            datenow.Text = today.ToShortDateString();
            empname.Text = usrname;
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.SelectedCells[0].Value.ToString();
            if (value.Equals("Add"))
            {

               
                this.name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               this.rate = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
               
               this.idm =int.Parse( dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());


                textBox1.Text = name;



            }
            textBox2.Focus();

               


            }

        private void button1_Click(object sender, EventArgs e)
        {


         

            Label lblN = new Label();
            lblN.Text = name;
            lblN.Width = 120;
            flowLayoutPanel1.Controls.Add(lblN);

            Label lbq = new Label();
            lbq.Text = textBox2.Text;
            
            lbq.Width = 40;
            flowLayoutPanel1.Controls.Add(lbq);
                        Label lbr = new Label();
            lbr.Text = rate;
            lbr.Width = 40;
            flowLayoutPanel1.Controls.Add(lbr);

             qty = int.Parse(textBox2.Text);
           
            
            double r = double.Parse(rate);
            amount = qty * r;
            Label lba = new Label();
            lba.Text = amount.ToString();
            lba.Width = 40;
            flowLayoutPanel1.Controls.Add(lba);

            total += amount;
            totalqty.Text = total.ToString();

            total = double.Parse(totalqty.Text);
            double vat = 0.13 * total;
            lblVat.Text = vat.ToString();
            totalaftervat = total + vat;


            double sertax = 0.10 * totalaftervat;
            lblServicetax.Text = sertax.ToString();

            grandtotal = totalaftervat + sertax;
            lblgrandtotal.Text = grandtotal.ToString();
            items.Add(idm);
            quantity.Add(qty);
            textBox2.Text = "";











        }


        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            lblgrandtotal.Text = "0.0";
            lblServicetax.Text = "0.0";
            totalqty.Text = "0.0";
            lblVat.Text = "0.0";
            textBox1.Text = "";
            textBox2.Text = "";
            total = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           


            //   BllGeneration bills = new BllGeneration (usrname,countr,total,totalaftervat,grandtotal);
            //  MessageBox.Show(usrname + " " +   countr + "   "+total + "   "+totalaftervat +"  "+ grandtotal);
            //  bills.ShowDialog();

            Billing bill = new Billing();
            bill.Cname = customername.Text;
            bill.Ename = empname.Text;
                bill.Date = datenow.Text;
            bill.Grandtotal = grandtotal;

            bill.addbill();

             bill_id = bill.getbillid();
           

            for (int i=0; i<items.Count; i++)
            {

                bill.Itemid = items[i];
                bill.Qty = quantity[i];
                bill.Billid = bill_id;
                bill.addordered();
            }

            BllGeneration customerbill = new BllGeneration(/*usrname,total,totalaftervat,grandtotal,bill_id*/);

            customerbill.ShowDialog();
          

        }
    }

   
}
