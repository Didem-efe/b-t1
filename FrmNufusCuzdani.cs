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
    public partial class FrmNufusCuzdani : Form
    {
        public FrmNufusCuzdani()
        {
            InitializeComponent();
        }

        public string ad, soyad, tc, cinsiyet, dogtarihi, uzanti;

        private void FrmNufusCuzdani_Load(object sender, EventArgs e)
        {
            lblad.Text = ad;
            lblsoyad.Text = soyad;
            lblcinsiyet.Text = cinsiyet;
            lbltc.Text = tc;
            lbldogtar.Text = dogtarihi;
            pictureEdit1.Image = Image.FromFile(uzanti);
        }
    }
}
