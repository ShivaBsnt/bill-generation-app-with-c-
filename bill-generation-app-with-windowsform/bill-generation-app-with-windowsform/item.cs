using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gried_view_table
{
    class item
    {
        private int id;
        private string name;
        private string rate;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Rate { get => rate; set => rate = value; }


        public DataTable getmethod()

        {

            Connection con = new Connection();
            string qry = "SELECT * FROM item";
            DataTable dt = con.retrieve(qry);
            return dt;

        }
       

        public void update(int id)
        {
            Connection con = new Connection();
            con.manipulate("UPDATE item SET name='"+Name+"' ,price='"+Rate+"' WHERE itemid='"+id+"'");                
        }

        public void delete(int id)
        {
            Connection con = new Connection();
            con.manipulate("DELETE from item where itemid='"+id+"'");

        }



       
    }
}
