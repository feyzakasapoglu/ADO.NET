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
    public partial class Urunler : Form
    {
         List<Products> Products = new List<Products>();

        SqlDbContext dbContext = new SqlDbContext();
        StringBuilder sql = new StringBuilder();
        public Urunler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txturunadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsupplier.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtkategori.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtfiyat .Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtquantity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtunitsock.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtunitsock.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtunirorder.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtreorder.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtdiscontinued.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            dbContext.SqlBaglatiAc();
            label1.Text = dbContext.SqlBaglantiDurumu();
           
            string sql = "Select * from Products";

            SqlDataReader rdr = dbContext.SorguCalistir(sql);
            Products.Clear();




            while (rdr.Read())
            
           {

               
                Products pr = new Products();
                pr.ProductID = Convert.ToInt32(rdr[0]);
                pr.ProductName = rdr[1].ToString();
                pr.SupplierID = Convert.ToInt32(rdr[2]);
                pr.CategoryID = Convert.ToInt32(rdr["CategoryID"]);
                pr.UnitPrice = Convert.ToDecimal(rdr["UnitPrice"]);
                pr.QuantityPerUnit = rdr["QuantityPerUnit"].ToString();
                pr.UnitslnStock = Convert.ToInt32(rdr[6]);
                pr.UnitOnOrder = Convert.ToInt32(rdr[7]);
                pr.ReorderLevel = Convert.ToInt32(rdr[8]);
                pr.Discontinued = Convert.ToInt32(rdr[9]);
               


                Products.Add(pr);


                // Listemizi datagrid'e basiyoruz
                dataGridView1.DataSource = Products.ToList();
            }
        }
    }

}
