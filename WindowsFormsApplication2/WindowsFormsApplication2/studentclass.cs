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
    class studentclass
    {
        string stdID = "", name = "", family = "", reshte_tahsily = "", jensiyat = "",
            taahol = "", tarikh_tavalod = "", code_melli = "", maghte_tahsily = "",
            name_pedar = "", address = "", code_posty = "", tedad_kamanati = "";
        public string stdIDsg
        { set { stdID = value; }
            get { return stdID; }
        }

        public string namesg
        {
            set { name = value; }
            get { return name; }
        }

        public string familysg
        {
            set { family = value; }
            get { return family; }
        }
        public string reshte_tahsilysg
        {
            set { reshte_tahsily = value; }
            get { return reshte_tahsily; }
        }
        public string jensiyatsg
        {
            set { jensiyat = value; }
            get { return jensiyat; }
        }
        public string taaholsg
        {
            set { taahol = value; }
            get { return taahol; }
        }
        public string tarikh_tavalodsg
        {
            set { tarikh_tavalod = value; }
            get { return tarikh_tavalod; }
        }
        public string code_mellisg
        {
            set { code_melli = value; }
            get { return code_melli; }
        }
        public string maghte_tahsilysg
        {
            set { maghte_tahsily = value; }
            get { return maghte_tahsily; }
        }
        public string name_pedarsg
        {
            set { name_pedar = value; }
            get { return name_pedar; }
        }
        public string addresssg
        {
            set { address = value; }
            get { return address; }
        }
        public string code_postysg
        {
            set { code_posty = value; }
            get { return code_posty; }
        }
        public string tedad_kamanatisg
        {
            set { tedad_kamanati = value; }
            get { return tedad_kamanati; }
        }
        public void update_student()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("edit_student", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stdID", stdID);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@family", family);
            cmd.Parameters.AddWithValue("@reshte_tahsily", reshte_tahsily);
            cmd.Parameters.AddWithValue("@jensiyat", jensiyat);
            cmd.Parameters.AddWithValue("@taahol", taahol);
            cmd.Parameters.AddWithValue("@tarikh_tavalod", tarikh_tavalod);
            cmd.Parameters.AddWithValue("@code_melli", code_melli);
            cmd.Parameters.AddWithValue("@maghte_tahsily", maghte_tahsily);
            cmd.Parameters.AddWithValue("@name_pedar", name_pedar);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@code_posty", code_posty);
            cmd.Parameters.AddWithValue("@tedad_kamanati", tedad_kamanati);

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
        public void insert_student()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert_student", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stdID", stdID);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@family", family);
            cmd.Parameters.AddWithValue("@reshte_tahsily", reshte_tahsily);
            cmd.Parameters.AddWithValue("@jensiyat", jensiyat);
            cmd.Parameters.AddWithValue("@taahol", taahol);
            cmd.Parameters.AddWithValue("@tarikh_tavalod", tarikh_tavalod);
            cmd.Parameters.AddWithValue("@code_melli", code_melli);
            cmd.Parameters.AddWithValue("@maghte_tahsily", maghte_tahsily);
            cmd.Parameters.AddWithValue("@name_pedar", name_pedar);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@code_posty", code_posty);
            cmd.Parameters.AddWithValue("@tedad_kamanati", tedad_kamanati);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد", "ثبت");
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void delete_student()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete_student", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stdID", stdID);

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
   
        public DataTable seaech_studend_ID()
        {

            SqlConnection con= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("search_student_Id", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@stdID", stdID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void update_amanat_student()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update_amanat_student", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tedad_kamanati", tedad_kamanati);
            cmd.Parameters.AddWithValue("@stdID", stdID);
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


    } }