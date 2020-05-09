using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frm_student : Form
    {
        string std_id_sarasari;
        public frm_student()
        {
            InitializeComponent();
        }
        public frm_student(string std_id_ersali)
        {
            InitializeComponent();
            std_id_sarasari = std_id_ersali;
        }

        private void frm_student_Load(object sender, EventArgs e)
        {
            studentclass s = new studentclass();
            s.stdIDsg = std_id_sarasari;
            DataTable dt = s.seaech_studend_ID();
            if (dt.Rows[0]["jensiyat"].ToString() == "زن")
                
             this.Text = "welcome mrs" + " " + dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["family"].ToString();
           else 
             this.Text = "welcome mr" + " " + dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["family"].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookclass b = new bookclass();
            b.name_ketabsg = txt_nameketab3.Text;
            b.name_nevisandesg = txt_namenevisande3.Text;
            DataSet ds = b.search_book_name();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables["tblbook"];

        }
    }
}
