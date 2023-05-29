using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GelirGiderOtomasyonu
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        void listele()
        {

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Giderler", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void Giderler_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void kaydetBtn_Click(object sender, EventArgs e)
        {


            int hata = 0;
            if (alinanTxt.Text == string.Empty)
                hata = 1;
            if (alisTxt.Text == string.Empty)
                hata = 1;
            if (tarihMtb.Text == string.Empty)
                hata = 1;

            if (hata == 1)
                MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SqlCommand cm = new SqlCommand("insert into Giderler (Alinan,AlisFiyati,Tarih) values ('" + alinanTxt.Text + "','" + alisTxt.Text + "','" + tarihMtb.Text + "')", bgl.baglanti());
                var basari = cm.ExecuteNonQuery();
                bgl.baglanti().Close();

                if (basari == 1)
                    MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("KAYIT EKLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                listele();

                alinanTxt.Clear();
                alisTxt.Clear();
                tarihMtb.Clear();



            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (noTxt.Text == string.Empty)
                hata = 1;

            if (hata == 1)
                MessageBox.Show("ALANI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SqlCommand komut = new SqlCommand("select * from Giderler where No = '" + noTxt.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand cm = new SqlCommand("delete from Giderler where No=  '" + noTxt.Text + "'", bgl.baglanti());
                    int basari = cm.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    if (basari == 1)
                        MessageBox.Show("MALZEME SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("MALZEME SİLİNMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("BÖYLE BİR MALZEME BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            noTxt.Clear();
            listele();
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            noTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            alinanTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            alisTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tarihMtb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }



        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (noTxt.Text == string.Empty)
                hata = 1;
            if (alinanTxt.Text == string.Empty)
                hata = 1;
            if (alisTxt.Text == string.Empty)
                hata = 1;
            if (tarihMtb.Text == string.Empty)
                hata = 1;

            if (hata == 1)
            {
                MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SqlCommand cm = new SqlCommand("UPDATE Giderler SET Alinan=@p1, AlisFiyati=@p2, Tarih=@p3 WHERE No=@p4", bgl.baglanti());
            cm.Parameters.AddWithValue("@p1", alinanTxt.Text);
            cm.Parameters.AddWithValue("@p2", decimal.Parse(alisTxt.Text));
            cm.Parameters.AddWithValue("@p3", DateTime.ParseExact(tarihMtb.Text, "dd.MM.yyyy", null));
            cm.Parameters.AddWithValue("@p4", int.Parse(noTxt.Text));

            int basari = cm.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (basari == 1)
            {
                MessageBox.Show("GÜNCELLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                alinanTxt.Clear();
                alisTxt.Clear();
                tarihMtb.Clear();
            }
            else
            {
                MessageBox.Show("GÜNCELLENEMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

    }
}