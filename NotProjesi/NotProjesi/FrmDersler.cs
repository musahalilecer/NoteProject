using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotProjesi
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TblDerslerTableAdapter ds = new DataSet1TableAdapters.TblDerslerTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            
        //    dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtAd.Text);
            MessageBox.Show("Ders Eklnedi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtAd.Text, byte.Parse(txtId.Text));
            MessageBox.Show("Ders Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(txtAd.Text);
        }
    }
}
