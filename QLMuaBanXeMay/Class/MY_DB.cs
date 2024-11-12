using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.Class
{
    public class MY_DB
    {


<<<<<<< HEAD
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q1R3HVB;Initial Catalog=QLXePT;Integrated Security=True;Encrypt=False");
        
        //static SqlConnection con = new SqlConnection(@"Data Source=DAN\SQLEXPRESS;Initial Catalog=QLXePT;Integrated Security=True");
=======
        //static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q1R3HVB;Initial Catalog=QLXePT;Integrated Security=True;Encrypt=False");
        //static SqlConnection con = new SqlConnection(@"Data Source=DAN\SQLEXPRESS;Initial Catalog=QLXePT;Integrated Security=True");
        static SqlConnection con = new SqlConnection(@"Data Source=MINHTRI\SQLEXPRESS;Initial Catalog=QLXePT;Integrated Security=True;TrustServerCertificate=True");
>>>>>>> ca2d574d76956850bffe7ddb657e8aa6a0a81370

        static public SqlConnection getConnection()
        {
           
             return con;
        }
        static public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        static public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        static public void setConnectionNV()
        {
            con=new SqlConnection(@"Data Source=DESKTOP-Q1R3HVB;Initial Catalog=QLXePT;User Id=" + DangNhap.username + ";Password=" + DangNhap.password + ";");
        }
    }
}
