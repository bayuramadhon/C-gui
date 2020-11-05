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

namespace Projek_3
{
    public partial class FormSummary : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-36P79TD\\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True;User ID=sa;Password=budi6501;");
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-36P79TD\\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True;User ID=sa;Password=budi6501;");

        string varKondisi = "0";
        string varKodeBarang; string varNamaBarang; string varJenisBarang;
        int totBarang;

        public FormSummary()
        {
            InitializeComponent();
        }

        private void Proses_Click(object sender, EventArgs e)
        {
            con.Open();

            string queryString = "SELECT * From TblMasukBarang WHERE tglmasuk < '"+ tglsummary.Text+"'";
            SqlCommand command = new SqlCommand(queryString, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (varKondisi == "0")
                    {
                        varKodeBarang = reader["kodebarang"].ToString();
                        varNamaBarang = reader["namabarang"].ToString();
                        varJenisBarang = reader["jenisbarang"].ToString();
                        varKondisi = "1";
                    }
                    if (varKodeBarang == reader["kodebarang"].ToString())
                    {
                        totBarang += Int32.Parse(reader["jumlahbarang"].ToString());
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into TblSumMasukBarang(kodebarang,tglsummary,namabarang,jenisbarang,jumlahbarang) values(@kodebarang,@tglsummary,@namabarang,@jenisbarang,@jumlahbarang)", con2);
                        con2.Open();
                        cmd.Parameters.AddWithValue("@kodebarang", varKodeBarang);
                        cmd.Parameters.AddWithValue("@tglsummary", tglsummary.Text);
                        cmd.Parameters.AddWithValue("@namabarang", varNamaBarang);
                        cmd.Parameters.AddWithValue("@jenisbarang", varJenisBarang);
                        cmd.Parameters.AddWithValue("@jumlahbarang", totBarang);
                        cmd.ExecuteNonQuery();
                        con2.Close();

                        totBarang = 0;
                        totBarang = Int32.Parse(reader["jumlahbarang"].ToString());
                        varKodeBarang = reader["kodebarang"].ToString();
                        varNamaBarang = reader["namabarang"].ToString();
                        varJenisBarang = reader["jenisbarang"].ToString();
                    }
                }
            }
            
            cmd = new SqlCommand("insert into TblSumMasukBarang(kodebarang,tglsummary,namabarang,jenisbarang,jumlahbarang) values(@kodebarang,@tglsummary,@namabarang,@jenisbarang,@jumlahbarang)", con2);
            con2.Open();
            cmd.Parameters.AddWithValue("@kodebarang", varKodeBarang);
            cmd.Parameters.AddWithValue("@tglsummary", tglsummary.Text);
            cmd.Parameters.AddWithValue("@namabarang", varNamaBarang);
            cmd.Parameters.AddWithValue("@jenisbarang", varJenisBarang);
            cmd.Parameters.AddWithValue("@jumlahbarang", totBarang);
            cmd.ExecuteNonQuery();
            con2.Close();

            // Call Close when done reading.
            reader.Close();
            con.Close();

            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void tglsummary_ValueChanged(object sender, EventArgs e)
        {
            tglsummary.CustomFormat = "yyyy-MM-dd";
        }

        private void tglsummary_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                {
                    tglsummary.CustomFormat = " ";
                }
            }
        }
    }
}
