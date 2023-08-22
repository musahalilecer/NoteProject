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

namespace NotProjesi
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VICMA4R\\SQLEXPRESS;Initial Catalog=OkulNotProjesi;Integrated Security=True");
        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {

            //    SqlCommand komut = new SqlCommand("select * from TblNotlar where OgrenciId=@p1", baglanti);
            //    komut.Parameters.AddWithValue("@p1", numara);
            //    this.Text = numara;
            //    SqlDataAdapter da = new SqlDataAdapter(komut);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;

            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TblNotlar where OgrenciId=@p1",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
