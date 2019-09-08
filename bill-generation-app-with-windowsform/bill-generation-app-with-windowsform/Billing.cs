using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gried_view_table
{
    class Billing
    {
        private string ename;
        private string cname;
        private String date;
        private double grandtotal;



        private int billid;
        private int itemid;
        private int qty;


        Connection con = new Connection();

        public string Ename { get => ename; set => ename = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Date { get => date; set => date = value; }
       
        public int Billid { get => billid; set => billid = value; }
        public int Itemid { get => itemid; set => itemid = value; }
        public double Grandtotal { get => grandtotal; set => grandtotal = value; }
        public int Qty { get => qty; set => qty = value; }

        public void addbill()

        {
            int totalforbill = Convert.ToInt32(grandtotal);
            
            try
            {
                con.manipulate("insert into bill (cname,ename,date,total) values ('"+ Cname +"','"+ Ename +"','"+ Date +"','"+ totalforbill +"')");

            }
        catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        
       
        
        }

        public void addordered()
        {
            try
            {
                con.manipulate("insert into orderss (Billid,itemid,qty) values ('" + Billid+"','"+Itemid+"','"+Qty+"')");
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }

        public int getbillid()
            {
            DataTable dt = con.retrieve("select*from bill");
            int billid = dt.Rows.Count ;
            return billid;

             }

        public DataTable billretrieve()
        {
            DataTable dt = con.retrieve("select name,price from bill where bi=bill_id");
                return dt;
        }
        public DataTable showBills()
        {
            DataTable dt = con.retrieve("SELECT Billid as Id,cname as Customer,ename as MadeBy, date as Date FROM bill");
            return dt;
        }

       public DataTable showBillsById(int id)
       {
            DataTable dt = con.retrieve("SELECT * FROM bill WHERE Billid='" + id + "'");
           return dt;
        }

       public DataTable showOrderedItemByBillId(int bid)
       {
            DataTable dt = con.retrieve("select name , qty , price  from item, orderss  where item.itemid = orderss.itemid and orderss.Billid = '" +bid+ "' ");
           return dt;
        }
    

        public DataTable searchBillsByCustomer(string cname)
        {
            DataTable dt = con.retrieve("SELECT Billid as Id, cname as Customer,ename as MadeBy, date as Date FROM bill WHERE cname LIKE '" + cname + "%'");
            return dt;
        }

        public DataTable searchBillsDate(/*string date*/)
        {
            DataTable dt = con.retrieve("SELECT id as Id,customer as Customer,employee as MadeBy, date as Date FROM bills WHERE date < '" + date + "'");
            return dt;
        }


    }

}