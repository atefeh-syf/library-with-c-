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
    class bookclass
    {
    
            string bookId = "", name_ketab = "", name_nevisande = "", shabak = "", mozoe = "",
                nasher = "", moshakhsat = "", noe_chap = "", sale_enteshar = "",
                tedad_kmojod = "";
            public string bookIdsg
            {
                set { bookId = value; }
                get { return bookId; }
            }

            public string name_ketabsg
            {
                set { name_ketab = value; }
                get { return name_ketab; }
            }

            public string name_nevisandesg
            {
                set { name_nevisande = value; }
                get { return name_nevisande; }
            }
            public string shabaksg
            {
                set { shabak = value; }
                get { return shabak; }
            }
            public string mozoesg
            {
                set { mozoe = value; }
                get { return mozoe; }
            }
            public string nashersg
            {
                set { nasher = value; }
                get { return nasher; }
            }
            public string moshakhsatsg
            {
                set { moshakhsat = value; }
                get { return moshakhsat; }
            }
            public string noe_chapsg
            {
                set { noe_chap = value; }
                get { return noe_chap; }
            }
            public string sale_entesharsg
            {
                set { sale_enteshar = value; }
                get { return sale_enteshar; }
            }
            public string tedad_kmojodsg
            {
                set { tedad_kmojod = value; }
                get { return tedad_kmojod; }
            }
          
            public void insert_book()
            {
                SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
                SqlCommand cmd1 = new SqlCommand("insert_book", con1);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.AddWithValue("@bookId", bookId);
                cmd1.Parameters.AddWithValue("@name_ketab", name_ketab);
                cmd1.Parameters.AddWithValue("@name_nevisande", name_nevisande);
                cmd1.Parameters.AddWithValue("@shabak", shabak);
                cmd1.Parameters.AddWithValue("@mozoe", mozoe);
                cmd1.Parameters.AddWithValue("@nasher", nasher);
                cmd1.Parameters.AddWithValue("@moshakhsat", moshakhsat);
                cmd1.Parameters.AddWithValue("@noe_chap", noe_chap);
                cmd1.Parameters.AddWithValue("@sale_enteshar", sale_enteshar);
                cmd1.Parameters.AddWithValue("@tedad_kmojod", tedad_kmojod);
               

                try
                {
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    con1.Close();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "ثبت");
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message);
                }
            
            }
        public void update_book()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("edit_book",con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bookId", bookId);
            cmd.Parameters.AddWithValue("@name_ketab", name_ketab);
            cmd.Parameters.AddWithValue("@name_nevisande", name_nevisande);
            cmd.Parameters.AddWithValue("@shabak", shabak);
            cmd.Parameters.AddWithValue("@mozoe", mozoe);
            cmd.Parameters.AddWithValue("@nasher", nasher);
            cmd.Parameters.AddWithValue("@moshakhsat", moshakhsat);
            cmd.Parameters.AddWithValue("@noe_chap", noe_chap);
            cmd.Parameters.AddWithValue("@sale_enteshar", sale_enteshar);
            cmd.Parameters.AddWithValue("@tedad_kmojod", tedad_kmojod);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "ویرایش");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }


        }
        

        public void delete_book()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete_book", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bookId", bookId);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات با موفقیت حذف شد", "حذف");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }


        }
        public DataTable search_book_ID()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("search_book_Id", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@bookId", bookId);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataSet search_book_name()
        {SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("search_book_name", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@name_ketab", name_ketab);
            da.SelectCommand.Parameters.AddWithValue("@name_nevisande", name_nevisande);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblbook");
            return ds;

        }
        public void update_amanat_book()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update_amanat_book", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tedad_kmojod", tedad_kmojod);
            cmd.Parameters.AddWithValue("@bookId", bookId);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch(SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
