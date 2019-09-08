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
    public partial class DynamicButton : Form
    {
                public DynamicButton()
        {
            InitializeComponent();
        }

        public string rate6;
        public string rate1;
        public string rate2;
        public string rate3;
        public string rate4;
        public string rate5;
        
        public string name1;
        public string name2;
        public string name3;
        public string name4;
        public string name5;
        public string name6;
        public bool check;
        
        public string name;
        

        private void DynamicButton_Load(object sender, EventArgs e)
        {
            check = true;
            item obj = new item();
            DataTable dt = obj.getmethod();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Name = "button"+(i+1);
                string name = dt.Rows[i][1].ToString();
                string rate = dt.Rows[i][2].ToString();



                btn.Width = 100;
                btn.Height = 100;
                btn.Text = name;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += new EventHandler(this.button_click);






            }

            name1 = dt.Rows[0][1].ToString();
            
            name2 = dt.Rows[1][1].ToString();
            name3 = dt.Rows[2][1].ToString();
            name4 = dt.Rows[3][1].ToString();
            name5 = dt.Rows[4][1].ToString();
            name6 = dt.Rows[5][1].ToString();

            rate1 = dt.Rows[0][2].ToString();
             rate2 = dt.Rows[1][2].ToString();
             rate3 = dt.Rows[2][2].ToString();
             rate4 = dt.Rows[3][2].ToString();
             rate5= dt.Rows[4][2].ToString();
             rate6 = dt.Rows[5][2].ToString();







           


        }


        
        void button_click(object sender, EventArgs e)
        {
            
            Button b = sender as Button;
            if(b.Name=="button1")
            {
                

                if (check ==true)
                {
                    
                   
                    b.Text = rate1;
                    check = false;
                }
                else if (check==false)
                {
                    b.Text = name1;
                   
                    check = true;
                }
                

            }

            
           else if (b.Name == "button2")
            {

                if (check == true)
                {


                    b.Text = rate2;
                    check = false;
                }
                else if (check == false)
                {
                    b.Text = name2;

                    check = true;
                }
            }

            else if (b.Name == "button3")
            {

                if (check == true)
                {


                    b.Text = rate3;
                    check = false;
                }
                else if (check == false)
                {
                    b.Text = name3;

                    check = true;
                }
            }

            else if (b.Name == "button4")
            {

                if (check == true)
                {


                    b.Text = rate4;
                    check = false;
                }
                else if (check == false)
                {
                    b.Text = name4;

                    check = true;
                }
            }

            else if (b.Name == "button5")
            {

                if (check == true)
                {


                    b.Text = rate5;
                    check = false;
                }
                else if (check == false)
                {
                    b.Text = name5;

                    check = true;
                }
            }
            else if (b.Name == "button6")
            {

                if (check == true)
                {


                    b.Text = rate6;
                    check = false;
                }
                else if (check == false)
                {
                    b.Text = name6;

                    check = true;
                }
            }
        }

        
    }
    


    
}
