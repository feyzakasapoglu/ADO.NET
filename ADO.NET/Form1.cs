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

namespace ADO.NET
{

    public partial class Form1 : Form
    {
        private List<Shipper> Shippers = new List<Shipper>();

        SqlDbContext dbContext = new SqlDbContext();
        StringBuilder sql = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtfirma.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Refresh()
        {
            dbContext.SqlBaglatiAc();
            label1.Text = dbContext.SqlBaglantiDurumu();
            // Sorgumuzu olusturuyoruz
            string sql = "Select * from Shippers";

            SqlDataReader rdr = dbContext.SorguCalistir(sql);
            Shippers.Clear();
            // Gelen Datalarin uzerinde tek tek geciyoruz
            while (rdr.Read())
            {

                // Gelen veriyi modelime uygun sekile ceviriyoruz
                Shipper sp = new Shipper();
                sp.ShipperId = Convert.ToInt32(rdr[0]);
                sp.CompanyName = rdr[1].ToString();
                sp.Phone = rdr[2].ToString();

                Shippers.Add(sp);

            }
            rdr.Close();

            // Listemizi datagrid'e basiyoruz
            dataGridView1.DataSource = Shippers.ToList();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "0")
            {

                sql.Append("Update Shippers  ");
                sql.Append($" Set CompanyName='{txtfirma.Text}' ");
                sql.Append($" , Phone='{txttelefon.Text}' ");
                sql.Append(" Where ShipperId=" + lblID.Text);
            }
            else
            {
                sql.Append("Insert into Shippers ");
                sql.Append(" (CompanyName , Phone)  ");
                sql.Append($" Values ('{txtfirma.Text}' ,'{txttelefon.Text}' ) ");
            }
            int row = dbContext.Guncelle(sql.ToString());

            if (row > 0)
            {
                MessageBox.Show("Kayit Basarili Şekilde guncellenmistir");
            }
            else
            {
                MessageBox.Show("Beklenmedik bir durum olustu. Daha sonra deneyiniz");

            }
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediginizden Eminmisiniz", "Uyari",
         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                sql.Append("Delete from Shippers where ShipperId=" + lblID.Text);
                dbContext.Guncelle(sql.ToString());
                Refresh();
            }
        }

        private void btnyenikayıt_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            lblID.Text = "0";
            txtfirma.Text = "";
            txttelefon.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
    }
