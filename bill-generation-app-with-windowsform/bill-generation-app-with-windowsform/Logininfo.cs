using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gried_view_table
{
    class Logininfo
    {
        private string  userid;
        private string password;
        private string useridlogin;
        private string passwordlogin;
        private string usertype;


        public string Userid { get => userid; set => userid = value; }
        public string Password { get => password; set => password = value; }
        public string Useridlogin { get => useridlogin; set => useridlogin = value; }
        public string Passwordlogin { get => passwordlogin; set => passwordlogin = value; }
        public string Usertype { get => usertype; set => usertype = value; }

        ConnectionForLogin connect = new ConnectionForLogin();
        public void Storeinfo()
        {
           
     
            
            string qry= "INSERT INTO userdetailss(userid,passwords,usertype) VALUES( '" + Userid + "',' " + Password + "','"+Usertype+"' )";


            connect.manipulate(qry);

        }
        public DataTable loginuser()
        {

            ConnectionForLogin connect = new ConnectionForLogin();

            string qry = "SELECT * FROM userdetails where userid='" + Useridlogin + "' ";
            DataTable dt = connect.retrieve(qry);
            return dt;
        }
     

    }
}
