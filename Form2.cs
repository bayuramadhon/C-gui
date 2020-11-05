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
namespace Projek_3
{
    public partial class Form2 : Form
    {

        SqlCommand cmd;
            
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-36P79TD\\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True;User ID=sa;Password=budi6501;");
        
        public Form2()
        {

            InitializeComponent();

        }

        private void tglmasuk_ValueChanged(object sender, EventArgs e)
        {
            tglmasuk.CustomFormat = "yyyy-MM-dd";
        }

        private void tglmasuk_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                {
                    tglmasuk.CustomFormat = " ";
                }
            }
        }

        private void simpan_Click_1(object sender, EventArgs e)
        {
            if (namabarang.Text != "")
            {
                cmd = new SqlCommand("insert into TblMasukBarang(kodebarang,tglmasuk,namabarang,jenisbarang,jumlahbarang) values(@kodebarang,@tglmasuk,@namabarang,@jenisbarang,@jumlahbarang)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@kodebarang", kodebarang.Text);
                cmd.Parameters.AddWithValue("@tglmasuk", tglmasuk.Text);
                cmd.Parameters.AddWithValue("@namabarang", namabarang.Text);
                cmd.Parameters.AddWithValue("@jenisbarang", jenisbarang.Text);
                cmd.Parameters.AddWithValue("@jumlahbarang", jumlahbarang.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSummary fmSum = new FormSummary();
            fmSum.Show();
        }

    }
}