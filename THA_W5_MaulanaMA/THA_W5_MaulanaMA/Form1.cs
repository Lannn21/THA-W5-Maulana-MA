using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_MaulanaMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        public string id = "";
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void lblcat_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbproduct.Enabled = false;
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dtProdukSimpan.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtProdukSimpan.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtProdukSimpan.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtProdukSimpan.Rows.Add("R001", "Rok mini", "82000", "26", "C3");
            dtProdukSimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProdukSimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProdukSimpan.Rows.Add("C002", "Cawat Blink-blink", "1000000", "1", "C5");
            dtProdukSimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");
            
            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");
            DGV2.DataSource = dtCategory;

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");
            /*
            dtProdukTampil.Rows.Add("J001", "Jas Hitam", "100900", "10", "C1");
            dtProdukTampil.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtProdukTampil.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtProdukTampil.Rows.Add("R001", "Rok mini", "82000", "26", "C3");
            dtProdukTampil.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProdukTampil.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProdukTampil.Rows.Add("C002", "Cawat Blink-blink", "1000000", "1", "C5");
            dtProdukTampil.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");
            
            DGV1.DataSource = dtProdukTampil;
            */
            DGV1.DataSource = dtProdukSimpan;
            cmbdet.DataSource = dtCategory;
            cmbdet.DisplayMember = "Nama Category";
            cmbdet.ValueMember = "ID Category";

          
        }

        private void btnaddcat_Click(object sender, EventArgs e)
        {
            int AngkaID = 0;
            string IDawal;
            int IDpanjang;
            string CategoryMasuk;
            bool sama = false;
            if (txtcat.Text == "")
            {
                MessageBox.Show("Tidak Boleh Kosong");
            }
            else
            {
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (txtcat.Text == dtCategory.Rows[i][1].ToString())
                    {
                        sama = true;
                    }
                }
                if (sama == false)
                {
                    if (dtCategory.Rows.Count > 0)
                    {
                        IDawal = dtCategory.Rows[dtCategory.Rows.Count - 1][0].ToString();
                        IDpanjang = IDawal.Length - 1;
                        AngkaID = Convert.ToInt32(IDawal.Substring(1, IDpanjang));
                    }
                    CategoryMasuk = txtcat.Text;
                    dtCategory.Rows.Add("C" + (AngkaID + 1), CategoryMasuk);
                }
                else
                {
                    MessageBox.Show("Nama Kategori Sama");
                }
            }
        }

        private void btnremovecat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if(dtProdukSimpan.Rows[i][4].ToString() == dtCategory.Rows[DGV2.CurrentCell.RowIndex][0].ToString())
                {
                    dtProdukSimpan.Rows.RemoveAt(i);
                    i -= 1;
                }
            }
            DGV2.Rows.RemoveAt(DGV2.CurrentCell.RowIndex);
            
        }

        private void btnremovepro_Click(object sender, EventArgs e)
        {
            DGV1.Rows.RemoveAt(DGV1.CurrentCell.RowIndex);
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            cmbproduct.Enabled = true;
            cmbproduct.DataSource = dtCategory;
            cmbproduct.ValueMember = "ID Category";
            cmbproduct.DisplayMember = "Nama Category";
            cmbproduct.DataSource = dtCategory;
        }


        private void cmbdet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtProdukTampil.Rows.Clear();

            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (dtProdukSimpan.Rows[i][4].ToString() == Convert.ToString(cmbproduct.SelectedValue))
                {
                    dtProdukTampil.Rows.Add(dtProdukSimpan.Rows[i][0] , dtProdukSimpan.Rows[i][1], dtProdukSimpan.Rows[i][2], dtProdukSimpan.Rows[i][3], dtProdukSimpan.Rows[i][4]);
                }
            }
            DGV1.DataSource = dtProdukTampil;
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            //dtProdukTampil.Rows.Clear();
            //for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            //{
                //dtProdukTampil.Rows.Add(dtProdukSimpan.Rows[i][0] , dtProdukSimpan.Rows[i][1], dtProdukSimpan.Rows[i][2], dtProdukSimpan.Rows[i][3], dtProdukSimpan.Rows[i][4]);
            //}
            DGV1.DataSource = dtProdukSimpan;
        }

        private void btnaddpro_Click(object sender, EventArgs e)
        {
            if (txtdetnama.Text == "" && txtdetharga.Text == "" && txtdetstock.Text == "" )
            {
                MessageBox.Show("Teks tidak boleh kosong");
            }
            else
            {
                dtProdukTampil.Rows.Clear ();
                string nomor = "";
                
                int penampung = 1;
                string pertama = txtdetnama.Text.Substring(0,1).ToUpper();
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][0].ToString().Contains(pertama))
                    {
                        penampung += 1;
                        for (int j = 0; j < dtProdukSimpan.Rows.Count; j++) //Mendeteksi angka 
                        {
                            if (Convert.ToInt32(dtProdukSimpan.Rows[j][0].ToString().Substring(1)) == penampung)
                            {
                                penampung = Convert.ToInt32(dtProdukSimpan.Rows[j][0].ToString().Substring(1));
                            }
                        }
                    }
                }
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i][1].ToString() == cmbdet.Text)
                    {
                        nomor = dtCategory.Rows[i][0].ToString();
                    }
                }
                string fin = penampung.ToString("D3");
                dtProdukSimpan.Rows.Add(pertama+fin,txtdetnama.Text,txtdetharga.Text,txtdetstock.Text,nomor);
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    dtProdukTampil.Rows.Add(dtProdukSimpan.Rows[i][0], dtProdukSimpan.Rows[i][1], dtProdukSimpan.Rows[i][2], dtProdukSimpan.Rows[i][3], dtProdukSimpan.Rows[i][4]);
                }
            }
        }

        private void txtdetharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar);
        }

        private void txtdetstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btneditpro_Click(object sender, EventArgs e)
        {
          
            if (txtdetnama.Text == "" && txtdetharga.Text == "" && txtdetstock.Text == "")
            {
                MessageBox.Show("Teks tidak boleh kosong");
            }
            else
            {
                string nomor = "";
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i][1].ToString() == cmbdet.Text)
                    {
                        nomor = dtCategory.Rows[i][0].ToString();
                    }
                }
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if(dtProdukSimpan.Rows[i][0].ToString() == id)
                    {
                        dtProdukSimpan.Rows[i][1] = txtdetnama.Text;
                        dtProdukSimpan.Rows[i][2] = txtdetharga.Text;
                        dtProdukSimpan.Rows[i][3] = txtdetstock.Text;
                        dtProdukSimpan.Rows[i][4] = nomor;
                    }
                }

            }
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtdetnama.Text = dtProdukSimpan.Rows[DGV1.CurrentCell.RowIndex][1].ToString();
            txtdetharga.Text = dtProdukSimpan.Rows[DGV1.CurrentCell.RowIndex][2].ToString();
            txtdetstock.Text = dtProdukSimpan.Rows[DGV1.CurrentCell.RowIndex][3].ToString();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][0] == dtProdukSimpan.Rows[DGV1.CurrentCell.RowIndex][4])
                {
                    cmbdet.Text = dtCategory.Rows[i][1].ToString();
                }
            }

        }
    }
}
