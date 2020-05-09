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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodbook_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsaleenteshar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginclass l = new loginclass();
            l.usernamesg = username.Text;
            l.passwordsg = password.Text;
            DataTable dt = l.login();
            if (dt.Rows.Count == 0)
                MessageBox.Show("نام کاربری یا پسورد اشتباه است");
            else if (dt.Rows[0]["type"].ToString() == "کتابدار")
            {
                frm_ketabdar f = new frm_ketabdar();
                f.Show();
            }
            else if (dt.Rows[0]["type"].ToString() == "دانشجو")
            {
                frm_student d = new frm_student(username.Text);
                d.Show();
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
