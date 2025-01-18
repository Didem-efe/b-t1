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
using System.IO;
using DevExpress.XtraGrid;

namespace OkulOtomasyon
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //5.SINIF
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBL_OGRENCILER where OGRSINIF = '5.SINIF'", bgl.baglanti());
            da1.Fill(dt1);
            GrdCtrl5.DataSource = dt1;

            //6.SINIF
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBL_OGRENCILER where OGRSINIF = '6.SINIF'", bgl.baglanti());
            da2.Fill(dt2);
            GrdCtrl6.DataSource = dt2;

            //7.SINIF
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from TBL_OGRENCILER where OGRSINIF = '7.SINIF'", bgl.baglanti());
            da3.Fill(dt3);
            GrdCtrl7.DataSource = dt3;

            //8.SINIF
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("select * from TBL_OGRENCILER where OGRSINIF = '8.SINIF'", bgl.baglanti());
            da4.Fill(dt4);
            GrdCtrl8.DataSource = dt4;

        }

        void velilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select VELIID,(VELIANNE+' | '+VELIBABA) AS 'VELI ANNE BABA' from TBL_VELILER", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "VELIID";
            lookUpEdit1.Properties.DisplayMember = "VELI ANNE BABA";
            lookUpEdit1.Properties.DataSource = dt;
        }

        void sehirekle()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            mskogrencino.Text = "";
            msktc.Text = "";
            rdbtnerkek.Checked = false;
            rdbtnbayan.Checked = false;
            cmbsinif.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            dateEdit1.Text = "";
            rchadres.Text = "";
            pictureEdit1.Text = "";
        }

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            listele();
            sehirekle();
            temizle();
            velilistesi();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = "";

            SqlCommand komut = new SqlCommand("select * from TBL_ilceler where ilid = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex +1);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["OGRID"].ToString();
                txtad.Text = dr["OGRAD"].ToString();
                txtsoyad.Text = dr["OGRSOYAD"].ToString();
                msktc.Text = dr["OGRTC"].ToString();
                mskogrencino.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    rdbtnerkek.Checked = true;
                }
                else
                {
                    rdbtnbayan.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchadres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\bahar\\Desktop\\projeler\\proje1\\OkulOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                //lookUpEdit1.Text = dr["VELI ANNE BABA"].ToString();
            }
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["OGRID"].ToString();
                txtad.Text = dr["OGRAD"].ToString();
                txtsoyad.Text = dr["OGRSOYAD"].ToString();
                msktc.Text = dr["OGRTC"].ToString();
                mskogrencino.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    rdbtnerkek.Checked = true;
                }
                else
                {
                    rdbtnbayan.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchadres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\bahar\\Desktop\\projeler\\proje1\\OkulOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                //lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["OGRID"].ToString();
                txtad.Text = dr["OGRAD"].ToString();
                txtsoyad.Text = dr["OGRSOYAD"].ToString();
                msktc.Text = dr["OGRTC"].ToString();
                mskogrencino.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    rdbtnerkek.Checked = true;
                }
                else
                {
                    rdbtnbayan.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchadres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\bahar\\Desktop\\projeler\\proje1\\OkulOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                //lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["OGRID"].ToString();
                txtad.Text = dr["OGRAD"].ToString();
                txtsoyad.Text = dr["OGRSOYAD"].ToString();
                msktc.Text = dr["OGRTC"].ToString();
                mskogrencino.Text = dr["OGRNO"].ToString();
                cmbsinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    rdbtnerkek.Checked = true;
                }
                else
                {
                    rdbtnbayan.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchadres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\bahar\\Desktop\\projeler\\proje1\\OkulOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                //lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        public string cinsiyet;

        private void btnkayitet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRENCILER (OGRAD, OGRSOYAD, OGRNO, OGRSINIF, OGRDOGTAR, OGRCINSIYET, OGRTC, OGRIL, OGRILCE, OGRADRES, OGRFOTO, OGRVELIID) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11,@p12)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskogrencino.Text);
            komut.Parameters.AddWithValue("@p4", cmbsinif.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);
            if (rdbtnerkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "B");
            }
            komut.Parameters.AddWithValue("@p7", msktc.Text);
            komut.Parameters.AddWithValue("@p8", cmbil.Text);
            komut.Parameters.AddWithValue("@p9", cmbilce.Text);
            komut.Parameters.AddWithValue("@p10", rchadres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        public string yeniyol;
        private void btnresimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası | *.jpg; *.png; *.nef | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\bahar\\Desktop\\projeler\\proje1\\OkulOtomasyon" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureEdit1.Image = Image.FromFile(yeniyol);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRENCILER set OGRAD = @p1, OGRSOYAD = @p2, OGRNO = @p3, OGRSINIF = @p4, OGRDOGTAR = @p5, OGRCINSIYET = @p6, OGRTC = @p7, OGRIL = @p8, OGRILCE = @p9, OGRADRES = @p10, OGRFOTO = @p11, OGRVELIID = @p13 where OGRID = @p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskogrencino.Text);
            komut.Parameters.AddWithValue("@p4", cmbsinif.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);
            komut.Parameters.AddWithValue("@p13", lookUpEdit1.EditValue);
            if (rdbtnerkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "B");
            }
            komut.Parameters.AddWithValue("@p7", msktc.Text);
            komut.Parameters.AddWithValue("@p8", cmbil.Text);
            komut.Parameters.AddWithValue("@p9", cmbilce.Text);
            komut.Parameters.AddWithValue("@p10", rchadres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_OGRENCILER where OGRID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\bahar\\Desktop\\projeler\\proje1\\OkulOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
