using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyon
{
    public partial class FrmVeliler : Form
    {
        public FrmVeliler()
        {
            InitializeComponent();
        }

        DbOkulEntities db = new DbOkulEntities();

        void listele()
        {
            var query = from item in db.TBL_VELILER
                        select new { item.VELIID, item.VELIANNE, item.VELIBABA, item.VELITEL1, item.VELITEL2, item.VELIMAIL };
            gridControl1.DataSource = query.ToList();
            //gridView1.Columns[6].Visible = false;
        }

        private void FrmVeliler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkayitet_Click(object sender, EventArgs e)
        {
            TBL_VELILER veli = new TBL_VELILER();
            veli.VELIANNE = txtannead.Text;
            veli.VELIBABA = txtbabaad.Text;
            veli.VELITEL1 = msktelefon1.Text;
            veli.VELITEL2 = msktelefon2.Text;
            veli.VELIMAIL = txtmail.Text;
            db.TBL_VELILER.Add(veli);
            db.SaveChanges();
            listele();
            temizle();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString();
            txtannead.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIANNE").ToString();
            txtbabaad.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIBABA").ToString();
            msktelefon1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL1").ToString();
            msktelefon2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL2").ToString();
            txtmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIMAIL").ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            var item = db.TBL_VELILER.Find(id);
            item.VELIANNE = txtannead.Text;
            item.VELIBABA = txtbabaad.Text;
            item.VELITEL1 = msktelefon1.Text;
            item.VELITEL2 = msktelefon2.Text;
            item.VELIMAIL = txtmail.Text;
            db.SaveChanges();
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            var item = db.TBL_VELILER.Find(id);
            db.TBL_VELILER.Remove(item);
            db.SaveChanges();
            listele();
        }

        void temizle()
        {

            txtid.Text = "";
            txtannead.Text = "";
            txtbabaad.Text = "";
            msktelefon1.Text = "";
            msktelefon2.Text = "";
            txtmail.Text = "";
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
