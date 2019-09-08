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
    public partial class ShowBill : Form
    {
        public int billid;
        public ShowBill(int id)
        {
            InitializeComponent();
            this.billid=id;
        }

        private void ShowBill_Load(object sender, EventArgs e)
        {
            Billing bil = new Billing();
            DataTable bill = bil.showBillsById(billid);
            label1.Text = bill.Rows[0][1].ToString();
            label2.Text = bill.Rows[0][2].ToString();
            lblDate.Text = bill.Rows[0][3].ToString();
            lblTotal.Text = bill.Rows[0][4].ToString();



            DataTable ordered = bil.showOrderedItemByBillId(billid);
            //MessageBox.Show(ordered.Rows.Count.ToString());
            for (int i = 0; i < ordered.Rows.Count; i++)
            {
                Label lbln = new Label();
                lbln.Width = 100;
                lbln.Text = ordered.Rows[i][0].ToString();
                flowLayoutPanel1.Controls.Add(lbln);

                Label lblq = new Label();
                lblq.Width = 50;
                lblq.Text = ordered.Rows[i][1].ToString();
                flowLayoutPanel1.Controls.Add(lblq);

                Label lblr = new Label();
                lblr.Width = 50;
                lblr.Text = ordered.Rows[i][2].ToString();
                flowLayoutPanel1.Controls.Add(lblr);

                int rate = int.Parse(lblr.Text);
                int qty = int.Parse(lblq.Text);
                int amt = rate * qty;
                Label lbla = new Label();
                lbla.Width = 100;
                lbla.Text = amt.ToString();
                flowLayoutPanel1.Controls.Add(lbla);
            }
        }

    }
    }

