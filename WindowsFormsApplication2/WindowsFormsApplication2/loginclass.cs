using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class loginclass
    {
        string username = "", password = "", type = "";
        

        public string usernamesg
        {
            set {username = value; }
            get { return username; }
        }
        public string passwordsg
        {
            set { password = value; }
            get { return password; }
        }
         public string typesg
        {
            set { type = value; }
            get { return type; }
        }

        public DataTable login()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("login", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@username", username);
            da.SelectCommand.Parameters.AddWithValue("@password", password);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
