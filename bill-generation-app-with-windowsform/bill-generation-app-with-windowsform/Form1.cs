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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int ids;
        
        item it = new item();
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.SelectedCells[0].Value.ToString();
            if (value.Equals("Edit"))
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string rate = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                ids = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                

                TXT.Text = name;
                TXTRATE.Text = rate;

            }

            
            if (value.Equals("Delete"))
            {
                
                ids = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                

                
                it.delete(ids);
                MessageBox.Show("SUCESSFUL deleted your data id");
                loaddata();

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            item it = new item();
            it.Name = TXT.Text;
                it.Rate = TXTRATE.Text;
            //ids = int.Parse(idm);
            it.update(ids);
            
            MessageBox.Show("SUCESSFUL");
            loaddata();

        }
        public void loaddata()
        {
            item items = new item();
            DataTable dt = items.getmethod();
            dataGridView1.DataSource = dt;


        }

        private void del_Click(object sender, EventArgs e)
        {

           // it.Name = TXT.Text;
           // it.Rate = TXTRATE.Text;
          //  ids = int.Parse(idm);
           // it.delete(ids);

           // MessageBox.Show("SUCESSFUL deleted your data id" + "  "+ids);

        }
    }
}
