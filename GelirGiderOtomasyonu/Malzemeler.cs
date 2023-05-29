using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GelirGiderOtomasyonu
{
    public partial class Malzemeler : Form
    {
        public Malzemeler()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        void listele()
        {
            DataSet ds  = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Malzemeler",bgl.baglanti()) ;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];    

        }
        private void Malzemeler_Load(object sender, EventArgs e)
        {
            listele();
        }




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }      
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
        

            int hata = 0;
            if (gramajTxt.Text == string.Empty)
                hata = 1;
            if (enTxt.Text == string.Empty)
                hata = 1;
            if (boyTxt.Text == string.Empty)
                hata = 1;
            if (adTxt.Text == string.Empty)
                hata = 1;
            if (matTxt.Text == string.Empty)
                hata = 1;
            if (alisTxt.Text == string.Empty)
                hata = 1;
            if (satisTxt.Text == string.Empty)
                hata = 1;
            if (adetNud.Text == string.Empty)
                hata = 1;
            if (tarihMtb.Text == string.Empty)
                hata = 1;

            if (hata == 1)
                MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else 
            {
                SqlCommand cm = new SqlCommand("insert into Malzemeler (Gramaji,Eni,Boyu,Adi,MatMi,AlisFiyati,SatisFiyati,Adet,Tarih) values ('" + gramajTxt.Text + "','" + enTxt.Text + "','" + boyTxt.Text + "','" + adTxt.Text + "','" + matTxt.Text + "','" + alisTxt.Text + "','" + satisTxt.Text + "','" + adetNud.Text + "','" + tarihMtb.Text + "')", bgl.baglanti());
                int basari = cm.ExecuteNonQuery();
                bgl.baglanti().Close();

                if (basari == 1)
                    MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("KAYIT EKLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                listele();

                gramajTxt.Clear();
                enTxt.Clear();
                boyTxt.Clear();
                adTxt.Clear();
                matTxt.Clear();
                alisTxt.Clear();
                satisTxt.Clear();
                tarihMtb.Clear();
              


            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
           int  hata = 0;
            if (noTxt.Text == string.Empty)
                hata = 1;

            if (hata == 1) 
            MessageBox.Show("ALANI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SqlCommand komut = new SqlCommand("select * from MALZEMELER where No = '" + noTxt.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {                    
                        SqlCommand cm = new SqlCommand("delete from MALZEMELER where No=  '" + noTxt.Text + "'", bgl.baglanti());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            noTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            gramajTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            enTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            boyTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            adTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            matTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            alisTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            satisTxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            adetNud.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tarihMtb.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            
        }


        
private void guncelleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("update MALZEMELER set Gramaji=@p1,Eni=@p2,Boyu=@p3,Adi=@p4,MatMi=@p5,AlisFiyati=@p6,SatisFiyati=@p7,Adet=@p8,Tarih=@p9 where No=@p10",bgl.baglanti());
            cm.Parameters.AddWithValue("@p1", int.Parse(gramajTxt.Text));
            cm.Parameters.AddWithValue("@p2", int.Parse(enTxt.Text));
            cm.Parameters.AddWithValue("@p3", int.Parse(boyTxt.Text));
            cm.Parameters.AddWithValue("@p4", adTxt.Text);
            cm.Parameters.AddWithValue("@p5", matTxt.Text);
            cm.Parameters.AddWithValue("@p6", decimal.Parse(alisTxt.Text));
            cm.Parameters.AddWithValue("@p7", decimal.Parse(satisTxt.Text));
            cm.Parameters.AddWithValue("@p8", int.Parse(((adetNud.Value).ToString())));
            cm.Parameters.AddWithValue("@p9", tarihMtb.Text);
            cm.Parameters.AddWithValue("@p10", int.Parse(noTxt.Text));

            int basari = cm.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (basari == 1)
                MessageBox.Show("GÜNCELLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("GÜNCELLENEMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            listele();
                
            gramajTxt.Clear();
            enTxt.Clear();
            boyTxt.Clear();
            adTxt.Clear();
            matTxt.Clear();
            alisTxt.Clear();
            satisTxt.Clear();
            tarihMtb.Clear();
        }
    }
}
