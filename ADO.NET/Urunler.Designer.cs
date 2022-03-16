
namespace ADO.NET
{
    partial class Urunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUrunler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbx_urunler = new System.Windows.Forms.GroupBox();
            this.txtdiscontinued = new System.Windows.Forms.TextBox();
            this.txtreorder = new System.Windows.Forms.TextBox();
            this.txtunirorder = new System.Windows.Forms.TextBox();
            this.txtunitsock = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.lbldiscontinued = new System.Windows.Forms.Label();
            this.lblreorder = new System.Windows.Forms.Label();
            this.lblunitonorder = new System.Windows.Forms.Label();
            this.llbunitstock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblkategori = new System.Windows.Forms.Label();
            this.lblsuppiler = new System.Windows.Forms.Label();
            this.lblurunadi = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbx_urunler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(42, 44);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(96, 28);
            this.btnUrunler.TabIndex = 0;
            this.btnUrunler.Text = "Bağlan";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(424, 326);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbx_urunler
            // 
            this.grbx_urunler.Controls.Add(this.txtdiscontinued);
            this.grbx_urunler.Controls.Add(this.txtreorder);
            this.grbx_urunler.Controls.Add(this.txtunirorder);
            this.grbx_urunler.Controls.Add(this.txtunitsock);
            this.grbx_urunler.Controls.Add(this.txtquantity);
            this.grbx_urunler.Controls.Add(this.txtfiyat);
            this.grbx_urunler.Controls.Add(this.txtkategori);
            this.grbx_urunler.Controls.Add(this.txtsupplier);
            this.grbx_urunler.Controls.Add(this.txturunadi);
            this.grbx_urunler.Controls.Add(this.lbldiscontinued);
            this.grbx_urunler.Controls.Add(this.lblreorder);
            this.grbx_urunler.Controls.Add(this.lblunitonorder);
            this.grbx_urunler.Controls.Add(this.llbunitstock);
            this.grbx_urunler.Controls.Add(this.lblQuantity);
            this.grbx_urunler.Controls.Add(this.lblfiyat);
            this.grbx_urunler.Controls.Add(this.lblkategori);
            this.grbx_urunler.Controls.Add(this.lblsuppiler);
            this.grbx_urunler.Controls.Add(this.lblurunadi);
            this.grbx_urunler.Controls.Add(this.lblID);
            this.grbx_urunler.Location = new System.Drawing.Point(492, 31);
            this.grbx_urunler.Margin = new System.Windows.Forms.Padding(4);
            this.grbx_urunler.Name = "grbx_urunler";
            this.grbx_urunler.Padding = new System.Windows.Forms.Padding(4);
            this.grbx_urunler.Size = new System.Drawing.Size(455, 458);
            this.grbx_urunler.TabIndex = 2;
            this.grbx_urunler.TabStop = false;
            this.grbx_urunler.Text = "Ürünler";
            // 
            // txtdiscontinued
            // 
            this.txtdiscontinued.Location = new System.Drawing.Point(117, 398);
            this.txtdiscontinued.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiscontinued.Name = "txtdiscontinued";
            this.txtdiscontinued.Size = new System.Drawing.Size(127, 25);
            this.txtdiscontinued.TabIndex = 19;
            // 
            // txtreorder
            // 
            this.txtreorder.Location = new System.Drawing.Point(117, 362);
            this.txtreorder.Margin = new System.Windows.Forms.Padding(4);
            this.txtreorder.Name = "txtreorder";
            this.txtreorder.Size = new System.Drawing.Size(127, 25);
            this.txtreorder.TabIndex = 18;
            // 
            // txtunirorder
            // 
            this.txtunirorder.Location = new System.Drawing.Point(117, 328);
            this.txtunirorder.Margin = new System.Windows.Forms.Padding(4);
            this.txtunirorder.Name = "txtunirorder";
            this.txtunirorder.Size = new System.Drawing.Size(127, 25);
            this.txtunirorder.TabIndex = 17;
            // 
            // txtunitsock
            // 
            this.txtunitsock.Location = new System.Drawing.Point(117, 296);
            this.txtunitsock.Margin = new System.Windows.Forms.Padding(4);
            this.txtunitsock.Name = "txtunitsock";
            this.txtunitsock.Size = new System.Drawing.Size(127, 25);
            this.txtunitsock.TabIndex = 16;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(129, 257);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(127, 25);
            this.txtquantity.TabIndex = 15;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(117, 220);
            this.txtfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(127, 25);
            this.txtfiyat.TabIndex = 14;
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(117, 168);
            this.txtkategori.Margin = new System.Windows.Forms.Padding(4);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(127, 25);
            this.txtkategori.TabIndex = 13;
            // 
            // txtsupplier
            // 
            this.txtsupplier.Location = new System.Drawing.Point(117, 120);
            this.txtsupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(127, 25);
            this.txtsupplier.TabIndex = 12;
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(117, 78);
            this.txturunadi.Margin = new System.Windows.Forms.Padding(4);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(127, 25);
            this.txturunadi.TabIndex = 11;
            // 
            // lbldiscontinued
            // 
            this.lbldiscontinued.AutoSize = true;
            this.lbldiscontinued.Location = new System.Drawing.Point(9, 409);
            this.lbldiscontinued.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiscontinued.Name = "lbldiscontinued";
            this.lbldiscontinued.Size = new System.Drawing.Size(102, 18);
            this.lbldiscontinued.TabIndex = 9;
            this.lbldiscontinued.Text = "Discontinued";
            // 
            // lblreorder
            // 
            this.lblreorder.AutoSize = true;
            this.lblreorder.Location = new System.Drawing.Point(9, 370);
            this.lblreorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblreorder.Name = "lblreorder";
            this.lblreorder.Size = new System.Drawing.Size(107, 18);
            this.lblreorder.TabIndex = 8;
            this.lblreorder.Text = "ReorderLevel";
            // 
            // lblunitonorder
            // 
            this.lblunitonorder.AutoSize = true;
            this.lblunitonorder.Location = new System.Drawing.Point(9, 337);
            this.lblunitonorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblunitonorder.Name = "lblunitonorder";
            this.lblunitonorder.Size = new System.Drawing.Size(108, 18);
            this.lblunitonorder.TabIndex = 7;
            this.lblunitonorder.Text = "UnitsOnOrder";
            // 
            // llbunitstock
            // 
            this.llbunitstock.AutoSize = true;
            this.llbunitstock.Location = new System.Drawing.Point(9, 296);
            this.llbunitstock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbunitstock.Name = "llbunitstock";
            this.llbunitstock.Size = new System.Drawing.Size(98, 18);
            this.llbunitstock.TabIndex = 6;
            this.llbunitstock.Text = "UnitsInStock";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(9, 260);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(121, 18);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "QuantityPerUnit";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(9, 220);
            this.lblfiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(41, 18);
            this.lblfiyat.TabIndex = 4;
            this.lblfiyat.Text = "Fiyat";
            // 
            // lblkategori
            // 
            this.lblkategori.AutoSize = true;
            this.lblkategori.Location = new System.Drawing.Point(8, 168);
            this.lblkategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkategori.Name = "lblkategori";
            this.lblkategori.Size = new System.Drawing.Size(69, 18);
            this.lblkategori.TabIndex = 3;
            this.lblkategori.Text = "Kategori";
            // 
            // lblsuppiler
            // 
            this.lblsuppiler.AutoSize = true;
            this.lblsuppiler.Location = new System.Drawing.Point(9, 131);
            this.lblsuppiler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsuppiler.Name = "lblsuppiler";
            this.lblsuppiler.Size = new System.Drawing.Size(91, 18);
            this.lblsuppiler.TabIndex = 2;
            this.lblsuppiler.Text = "Supplier ID:";
            // 
            // lblurunadi
            // 
            this.lblurunadi.AutoSize = true;
            this.lblurunadi.Location = new System.Drawing.Point(9, 89);
            this.lblurunadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblurunadi.Name = "lblurunadi";
            this.lblurunadi.Size = new System.Drawing.Size(72, 18);
            this.lblurunadi.TabIndex = 1;
            this.lblurunadi.Text = "Ürün Adi:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 50);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbx_urunler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUrunler);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Urunler";
            this.Text = "Urunler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbx_urunler.ResumeLayout(false);
            this.grbx_urunler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbx_urunler;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblkategori;
        private System.Windows.Forms.Label lblsuppiler;
        private System.Windows.Forms.Label lblurunadi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtdiscontinued;
        private System.Windows.Forms.TextBox txtreorder;
        private System.Windows.Forms.TextBox txtunirorder;
        private System.Windows.Forms.TextBox txtunitsock;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.Label lbldiscontinued;
        private System.Windows.Forms.Label lblreorder;
        private System.Windows.Forms.Label lblunitonorder;
        private System.Windows.Forms.Label llbunitstock;
        private System.Windows.Forms.Label label1;
    }
}