using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection mycn = new SqlConnection("Server=.;Database=MyData;Trusted_Connection=True;");

        private void btnGetir_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Insanlar", mycn);
            adp.Fill(ds, "Insanlar");
            dgwGetir.DataSource = ds.Tables[0];
            ds.Dispose();
            label1.Visible = true;
            btnYas.Visible = true;
            txtSoyad.Visible = true; 
        }

        private void btnYas_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("YasAl", mycn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            mycn.Open();
            MessageBox.Show("Yaşınız : " + cmd.ExecuteScalar().ToString(), "YAŞ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mycn.Close();
        }
    }
}
