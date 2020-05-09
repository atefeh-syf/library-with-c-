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
    public partial class frm_ketabdar : Form
    {
        public frm_ketabdar()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentclass d = new studentclass();
            d.stdIDsg = txt_stdID.Text;
            d.namesg = txt_name.Text;
            d.familysg = txt_family.Text;
            d.reshte_tahsilysg = txt_reshte_tahsily.Text;
            d.tarikh_tavalodsg = txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text;
            d.code_mellisg = txt_codemelli.Text;
            d.maghte_tahsilysg = txt_maghte_tahsily.Text;
            d.name_pedarsg = txt_namepedar.Text;
            d.addresssg = txt_address.Text;
            d.code_postysg = txt_codeposty.Text;


            if (zan.Checked == true)
                d.jensiyatsg = "زن";
            else if (mard.Checked == true)
                d.jensiyatsg = "مرد";

            if (motahel.Checked == true)
                d.taaholsg = "متاهل";
            else if (mojarad.Checked == true)
                d.taaholsg = "مجرد";

            d.tedad_kamanatisg = "0";
            d.insert_student();

        }

        private void btnsavebook_Click(object sender, EventArgs e)
        {
            bookclass b = new bookclass();
            b.bookIdsg = txtbookId.Text;
            b.name_ketabsg = txtbookId.Text;
            b.name_nevisandesg = txtname_nevisande.Text;
            b.shabaksg = txtshabk.Text;
            b.mozoesg = txtmozoe.Text;
            b.nashersg = txtnasher.Text;
            b.moshakhsatsg = txtmoshakhsat.Text;
            b.noe_chapsg = txtnoe_chap.Text;
            b.sale_entesharsg = txtsale_enteshar.Text;
            b.tedad_kmojodsg = txttedad_kmojod.Text;
            b.insert_book();

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void lblmoshakhasat_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentclass s = new studentclass();
            s.stdIDsg = txt_stdID1.Text;
            s.namesg = txt_name1.Text;
            s.familysg = txt_family1.Text;
            s.reshte_tahsilysg = txt_reshte_tahsily1.Text;
            s.tarikh_tavalodsg = txtyear1.Text + "/" + txtmonth1.Text + "/" + txtday1.Text;
            s.code_mellisg = txt_codemelli1.Text;
            s.maghte_tahsilysg = txt_maghte_tahsily1.Text;
            s.name_pedarsg = txt_namepdar1.Text;
            s.addresssg = txt_address1.Text;
            s.code_postysg = txt_codeposty1.Text;


            if (zan1.Checked == true)
                s.jensiyatsg = "زن";
            else if (mard1.Checked == true)
                s.jensiyatsg = "مرد";

            if (motahel1.Checked == true)
                s.taaholsg = "متاهل";
            else if (mojarad1.Checked == true)
                s.taaholsg = "مجرد";

            s.tedad_kamanatisg = txt_kamanati.Text;
            s.update_student();
            txt_stdID1.Text = "";
            txt_name1.Text = "";
            txt_family1.Text = "";
            txt_reshte_tahsily1.Text = "";
            zan1.Checked = false;
            mard1.Checked = false;
            mojarad1.Checked = false;
            motahel1.Checked = false;
            txtyear1.Text = "";
            txtmonth1.Text = "";
            txtday1.Text = "";
            txt_codemelli1.Text = "";
            txt_maghte_tahsily1.Text = "";
            txt_namepdar1.Text = "";
            txt_address1.Text = "";
            txt_codeposty1.Text = "";
            txt_kamanati.Text = "";
            panel1.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentclass d = new studentclass();
            d.stdIDsg = txt_stdID1.Text;
            d.delete_student();
            txt_stdID1.Text = "";
            txt_name1.Text = "";
            txt_family1.Text = "";
            txt_reshte_tahsily1.Text = "";
            zan1.Checked = false;
            mard1.Checked = false;
            mojarad1.Checked = false;
            motahel1.Checked = false;
            txtyear1.Text = "";
            txtmonth1.Text = "";
            txtday1.Text = "";
            txt_codemelli1.Text = "";
            txt_maghte_tahsily1.Text = "";
            txt_namepdar1.Text = "";
            txt_address1.Text = "";
            txt_codeposty1.Text = "";
            txt_kamanati.Text = "";
            panel1.Enabled = false;
        }

        private void btneditbook_Click(object sender, EventArgs e)
        {
            bookclass b = new bookclass();
            b.bookIdsg = txtbookId1.Text;
            b.name_ketabsg = txtname_book1.Text;
            b.name_nevisandesg = txtname_nevisande1.Text;
            b.shabaksg = txtshabk1.Text;
            b.mozoesg = txtmozoe1.Text;
            b.nashersg = txtnasher1.Text;
            b.moshakhsatsg = txtmoshakhsat1.Text;
            b.noe_chapsg = txtnoe_chap1.Text;
            b.sale_entesharsg = txtsale_enteshar1.Text;
            b.tedad_kmojodsg = txttedad_kmojod1.Text;
            b.update_book();
            txtbookId1.Text = "";
            txtname_book1.Text = "";
            txtname_nevisande1.Text = "";
            txtshabk1.Text = "";
            txtmozoe1.Text = "";
            txtnasher1.Text = "";
            txtmoshakhsat1.Text = "";
            txtnoe_chap1.Text = "";
            txtsale_enteshar1.Text = "";
            txttedad_kmojod1.Text = "";
            panel2.Enabled = false;
        }

        private void btndeletbook_Click(object sender, EventArgs e)
        {
            bookclass b = new bookclass();
            b.bookIdsg = txtbookId1.Text;
            b.delete_book();
            txtbookId1.Text = "";
            txtname_book1.Text = "";
            txtname_nevisande1.Text = "";
            txtshabk1.Text = "";
            txtmozoe1.Text = "";
            txtnasher1.Text = "";
            txtmoshakhsat1.Text = "";
            txtnoe_chap1.Text = "";
            txtsale_enteshar1.Text = "";
            txttedad_kmojod1.Text = "";
            panel2.Enabled = false;




        }

        private void txtbookId1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnjostojoystudent_Click(object sender, EventArgs e)
        {

            studentclass d = new studentclass();
            d.stdIDsg = txt_stdID1.Text;
            DataTable dt = d.seaech_studend_ID();


            if (dt.Rows.Count == 0)
            {
                panel1.Enabled = false;
                txt_name1.Text = "";
                txt_name1.Text = "";
                txt_family1.Text = "";
                txt_reshte_tahsily1.Text = "";
                zan1.Checked = false; mard1.Checked = false;
                mojarad1.Checked = false;
                motahel1.Checked = false;
                txtyear1.Text = "";
                txtmonth1.Text = "";
                txtday1.Text = ""; ;

                txt_codemelli1.Text = "";
                txt_maghte_tahsily1.Text = "";
                txt_namepdar1.Text = "";
                txt_address1.Text = "";
                txt_codeposty1.Text = "";
                txt_kamanati.Text = "";
                MessageBox.Show("این دانشجو قبلا ثبت نام نکرده است");
            }
            else
            {
                panel1.Enabled = true;

                txt_name1.Text = dt.Rows[0]["name"].ToString();
                txt_family1.Text = dt.Rows[0]["family"].ToString();
                txt_reshte_tahsily1.Text = dt.Rows[0]["reshte_tahsily"].ToString();
                if (dt.Rows[0]["jensiyat"].ToString() == "زن")
                    zan1.Checked = true;
                else if (dt.Rows[0]["jensiyat"].ToString() == "مرد")
                    mard1.Checked = true;

                if (dt.Rows[0]["taahol"].ToString() == "مجرد")
                    mojarad1.Checked = true;
                else if (dt.Rows[0]["taahol"].ToString() == "متاهل")
                    motahel1.Checked = true;


                string[] bd = dt.Rows[0]["tarikh_tavalod"].ToString().Split('/');
                txtyear1.Text = bd[0];
                txtmonth1.Text = bd[1];
                txtday1.Text = bd[2];

                txt_codemelli1.Text = dt.Rows[0]["code_melli"].ToString();
                txt_maghte_tahsily1.Text = dt.Rows[0]["maghte_tahsily"].ToString();
                txt_namepdar1.Text = dt.Rows[0]["name_pedar"].ToString();
                txt_address1.Text = dt.Rows[0]["address"].ToString();
                txt_codeposty1.Text = dt.Rows[0]["code_posty"].ToString();
                txt_kamanati.Text = dt.Rows[0]["tedad_kamanati"].ToString();


            }






        }

        private void btnjostojo_Click(object sender, EventArgs e)
        {
            bookclass b = new bookclass();
            b.bookIdsg = txtbookId1.Text;
            DataTable dt = b.search_book_ID();
            if (dt.Rows.Count == 0)
            {
                panel2.Enabled = false;
                txtname_book1.Text = "";
                txtname_nevisande1.Text = "";
                txtshabk1.Text = "";
                txtmozoe1.Text = "";
                txtnasher1.Text = "";
                txtmoshakhsat1.Text = "";
                txtnoe_chap1.Text = "";
                txtsale_enteshar1.Text = "";
                txttedad_kmojod1.Text = "";
                MessageBox.Show("این کتاب قبلا ثبت نشده است");




            }
            else
            {
                panel2.Enabled = true;
                txtname_book1.Text = dt.Rows[0]["name_ketab"].ToString();
                txtname_nevisande1.Text = dt.Rows[0]["name_nevisande"].ToString();
                txtshabk1.Text = dt.Rows[0]["shabak"].ToString();
                txtmozoe1.Text = dt.Rows[0]["mozoe"].ToString();
                txtnasher1.Text = dt.Rows[0]["nasher"].ToString();
                txtmoshakhsat1.Text = dt.Rows[0]["moshakhsat"].ToString();
                txtnoe_chap1.Text = dt.Rows[0]["noe_chap"].ToString();
                txtsale_enteshar1.Text = dt.Rows[0]["sale_enteshar"].ToString();
                txttedad_kmojod1.Text = dt.Rows[0]["tedad_kmojod"].ToString();

            }


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }



        //////////////////////////////////////////amanat butten
        private void button1_Click_1(object sender, EventArgs e)
        {
            int tka = 0;
            studentclass d = new studentclass();
            d.stdIDsg = txt_stdID2.Text;
            DataTable df = d.seaech_studend_ID();
            if (df.Rows.Count == 0)
                MessageBox.Show("این دانشجو قبلا ثبت نام نکرده است ");
            else
                tka = Convert.ToInt32(df.Rows[0]["tedad_kamanati"].ToString());
             int tedad_ketab_mojod = 0;
            bookclass dd = new bookclass();
            dd.bookIdsg = txt_bookid2.Text;
            DataTable dtt = dd.search_book_ID();
            if (dtt.Rows.Count == 0)
                MessageBox.Show(" این کتاب موجود نیست");
            else

                tedad_ketab_mojod = Convert.ToInt32(dtt.Rows[0]["tedad_kmojod"].ToString());

            if (tka < 3 && tedad_ketab_mojod > 0)
            {
                d.stdIDsg = txt_stdID2.Text;
                d.tedad_kamanatisg = Convert.ToString(tka + 1);
                d.update_amanat_student();

                dd.bookIdsg = txt_bookid2.Text;
                dd.tedad_kmojodsg = Convert.ToString(tedad_ketab_mojod - 1);
                dd.update_amanat_book();

                amanatclass f = new amanatclass();
                f.stdIDsg = txt_stdID2.Text;
                f.bookIDsg = txt_bookid2.Text;
                f.tarikh_amanatsg = "13"+txtyearamanat.Text+"/"+txtmonthamanat.Text+"/"+txtdayamanat.Text;
                f.insert_amanat();
            }
            else
                MessageBox.Show("این دانشجو نمیتواند کتابی به امانت بگیرد");

            txt_stdID2.Text = "";
            txt_bookid2.Text = "";
            txtdayamanat.Text = "";
            txtmonthamanat.Text = "";
            txtyearamanat.Text = "";

            //////////////////////////////////////////amanat butten

        }
        
        //////////////////////////////////////////amanat butten

        private void txt_bookid2_TextChanged(object sender, EventArgs e)
        {

        }
        ///////////////////////////////////////////////////////insert studend button
        private void btnsavestudent_Click(object sender, EventArgs e)
        {
            studentclass d = new studentclass();
            d.stdIDsg = txt_stdID.Text;
            DataTable dt = d.seaech_studend_ID();
            if (dt.Rows.Count == 0)
            {

                d.namesg = txt_name.Text;
                d.familysg = txt_family.Text;
                d.reshte_tahsilysg = txt_reshte_tahsily.Text;
                if (zan.Checked == true)
                    d.jensiyatsg = "زن";
                else if (mard.Checked == true)
                    d.jensiyatsg = "مرد";
                if (motahel.Checked == true)
                    d.taaholsg = "متاهل";
                else if (mojarad.Checked == true)
                    d.taaholsg = "مجرد";

                d.tarikh_tavalodsg = txtyear.Text + "/" + txtmonth.Text + "/" + txtday.Text;
                d.code_mellisg = txt_codemelli.Text;
                d.maghte_tahsilysg = txt_maghte_tahsily.Text;
                d.name_pedarsg = txt_namepedar.Text;
                d.addresssg = txt_address.Text;
                d.code_postysg = txt_codeposty.Text;
                d.tedad_kamanatisg = "0";
                d.insert_student();
              
            }
            else
            {
                MessageBox.Show("این دانشجو قبلا ثبت نام کرده است");
              
            }
                 txt_stdID.Text = "";
                txt_name.Text = "";
                txt_family.Text = "";
                txt_reshte_tahsily.Text = "";
                zan.Checked = false;
                mard.Checked = false;
                mojarad.Checked = false;
                motahel.Checked = false;
                txtyear.Text = "";
                txtmonth.Text = "";
                txtday.Text = "";
                txt_codemelli.Text = "";
                txt_maghte_tahsily.Text = "";
                txt_namepedar.Text = "";
                txt_address.Text = "";
                txt_codeposty.Text = "";



                ///////////////////////////////////////////////////////insert studend button

            }
        ///////////////////////////////////////////////////////insert book button
        private void btnsavebook_Click_1(object sender, EventArgs e)
        {
            bookclass b = new bookclass();
            b.bookIdsg = txtbookId.Text;
           
            DataTable dt = b.search_book_ID();
            if (dt.Rows.Count == 0)
            {
                b.name_ketabsg = txtname_book.Text;
                b.name_nevisandesg = txtname_nevisande.Text;
                b.shabaksg = txtshabk.Text;
                b.mozoesg = txtmozoe.Text;
                b.nashersg = txtnasher.Text;
                b.moshakhsatsg = txtmoshakhsat.Text;
                b.noe_chapsg = txtnoe_chap.Text;
                b.sale_entesharsg = txtsale_enteshar.Text;
                b.tedad_kmojodsg = txttedad_kmojod.Text;
                b.insert_book();
            }
            else
            {
                MessageBox.Show("این کتاب قبلا ثبت شده است");
            }

            txtbookId.Text = "";
            txtname_book.Text = "";
            txtname_nevisande.Text = "";
            txtshabk.Text = "";
            txtmozoe.Text = "";
            txtnasher.Text = "";
            txtmoshakhsat.Text = "";
            txtnoe_chap.Text ="";
            txtsale_enteshar.Text= "";
            txttedad_kmojod.Text= "";


            ///////////////////////////////////////////////////////insert book button
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int teadad_ketab_amanati = 0;
            studentclass d = new studentclass();
            d.stdIDsg = txt_stdID3.Text;
            DataTable df = d.seaech_studend_ID();
            if (df.Rows.Count == 0)
            {
                MessageBox.Show("این دانشجو قبلا ثبت نام نکرده است");
            }
            else

                teadad_ketab_amanati = Convert.ToInt32(df.Rows[0]["tedad_kamanati"].ToString());

            int tedad_ketab_mojod = 0;
            bookclass dd = new bookclass();
            dd.bookIdsg = txt_bookid3.Text;
            DataTable dtt = dd.search_book_ID();
            if (dtt.Rows.Count == 0)
                MessageBox.Show("این کتاب موجود نیست");
            else
            {
                tedad_ketab_mojod = Convert.ToInt32(dtt.Rows[0]["tedad_kmojod"].ToString());

                d.stdIDsg = txt_stdID3.Text;
                d.tedad_kamanatisg = Convert.ToString(teadad_ketab_amanati - 1);
                d.update_amanat_student();

                dd.bookIdsg = txt_bookid3.Text;
                dd.tedad_kmojodsg = Convert.ToString(tedad_ketab_mojod + 1);
                dd.update_amanat_book();

                amanatclass f = new amanatclass();
                f.stdIDsg = txt_stdID3.Text;
                f.bookIDsg = txt_bookid3.Text;
                f.tarikh_bargashtsg = "13" + txtyearbargasht.Text+"/"+txtmonthbargasht.Text+"/"+txtdaybargasht.Text;
                f.update_amanat();
            }
            txt_stdID3.Text = "";
            txt_bookid3.Text = "";
            txtdaybargasht.Text = "";
            txtmonthbargasht.Text = "";
            txtyearbargasht.Text = "";

        }

        private void frm_ketabdar_Load(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_stdID1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}

