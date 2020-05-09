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
    class amanatclass
    {
        string stdID = "", bookID = "", tarikh_amanat = "", tarikh_bargasht = "";
        public string stdIDsg
        {set { stdID = value; }
          get { return stdID; }
         }
        public string bookIDsg
        {
            set { bookID = value; }
            get { return bookID; }
        }
        public string tarikh_amanatsg
        {
            set { tarikh_amanat = value; }
            get { return tarikh_amanat; }
        }
        public string tarikh_bargashtsg
        {
            set { tarikh_bargasht = value; }
            get { return tarikh_bargasht; }
        }


        public void insert_amanat()
        {
            SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert_amanat",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stdID", stdID);
            cmd.Parameters.AddWithValue("@bookID", bookID);
            cmd.Parameters.AddWithValue("@tarikh_amanat",tarikh_amanat);
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("کتاب مورد نظر به امانت داده شد");
            }
            catch(SqlException err)
            {
                MessageBox.Show(err.Message);

            }
            }
      public void update_amanat()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update_amanat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tarikh_bargasht", tarikh_bargasht);
            cmd.Parameters.AddWithValue("@stdID", stdID);
            cmd.Parameters.AddWithValue("@bookID", bookID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("کتاب مورد نظر برگشت داده شد","برگشت");

            }
            catch(SqlException err)
            {
                MessageBox.Show(err.Message);
            }

            }

        }

        }
    

