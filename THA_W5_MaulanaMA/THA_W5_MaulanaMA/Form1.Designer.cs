namespace THA_W5_MaulanaMA
{
    partial class Form1
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
            this.lblproduct = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.btnall = new System.Windows.Forms.Button();
            this.txtdetnama = new System.Windows.Forms.TextBox();
            this.lblnamacat = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblharga = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblnama = new System.Windows.Forms.Label();
            this.lbldetails = new System.Windows.Forms.Label();
            this.cmbdet = new System.Windows.Forms.ComboBox();
            this.btnremovecat = new System.Windows.Forms.Button();
            this.btnaddcat = new System.Windows.Forms.Button();
            this.btnremovepro = new System.Windows.Forms.Button();
            this.btneditpro = new System.Windows.Forms.Button();
            this.btnaddpro = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.txtdetharga = new System.Windows.Forms.TextBox();
            this.txtdetstock = new System.Windows.Forms.TextBox();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct.Location = new System.Drawing.Point(25, 11);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(119, 32);
            this.lblproduct.TabIndex = 0;
            this.lblproduct.Text = "Product";
            // 
            // DGV1
            // 
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(31, 46);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(451, 225);
            this.DGV1.TabIndex = 1;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(226, 15);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(54, 22);
            this.btnall.TabIndex = 2;
            this.btnall.Text = "All";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // txtdetnama
            // 
            this.txtdetnama.Location = new System.Drawing.Point(101, 322);
            this.txtdetnama.Name = "txtdetnama";
            this.txtdetnama.Size = new System.Drawing.Size(353, 22);
            this.txtdetnama.TabIndex = 4;
            this.txtdetnama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblnamacat
            // 
            this.lblnamacat.AutoSize = true;
            this.lblnamacat.Location = new System.Drawing.Point(30, 323);
            this.lblnamacat.Name = "lblnamacat";
            this.lblnamacat.Size = new System.Drawing.Size(50, 16);
            this.lblnamacat.TabIndex = 5;
            this.lblnamacat.Text = "Nama: ";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.Location = new System.Drawing.Point(518, 11);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(137, 32);
            this.lblcat.TabIndex = 6;
            this.lblcat.Text = "Category";
            this.lblcat.Click += new System.EventHandler(this.lblcat_Click);
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Location = new System.Drawing.Point(30, 412);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(44, 16);
            this.lblstock.TabIndex = 7;
            this.lblstock.Text = "Stock:";
            // 
            // lblharga
            // 
            this.lblharga.AutoSize = true;
            this.lblharga.Location = new System.Drawing.Point(30, 384);
            this.lblharga.Name = "lblharga";
            this.lblharga.Size = new System.Drawing.Size(48, 16);
            this.lblharga.TabIndex = 8;
            this.lblharga.Text = "Harga:";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(28, 353);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(65, 16);
            this.lblcategory.TabIndex = 9;
            this.lblcategory.Text = "Category:";
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Location = new System.Drawing.Point(521, 236);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(50, 16);
            this.lblnama.TabIndex = 10;
            this.lblnama.Text = "Nama: ";
            // 
            // lbldetails
            // 
            this.lbldetails.AutoSize = true;
            this.lbldetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetails.Location = new System.Drawing.Point(25, 279);
            this.lbldetails.Name = "lbldetails";
            this.lbldetails.Size = new System.Drawing.Size(109, 32);
            this.lbldetails.TabIndex = 11;
            this.lbldetails.Text = "Details";
            // 
            // cmbdet
            // 
            this.cmbdet.FormattingEnabled = true;
            this.cmbdet.Location = new System.Drawing.Point(101, 350);
            this.cmbdet.Name = "cmbdet";
            this.cmbdet.Size = new System.Drawing.Size(121, 24);
            this.cmbdet.TabIndex = 12;
            this.cmbdet.SelectedIndexChanged += new System.EventHandler(this.cmbdet_SelectedIndexChanged);
            // 
            // btnremovecat
            // 
            this.btnremovecat.Location = new System.Drawing.Point(700, 271);
            this.btnremovecat.Name = "btnremovecat";
            this.btnremovecat.Size = new System.Drawing.Size(75, 58);
            this.btnremovecat.TabIndex = 13;
            this.btnremovecat.Text = "Remove Category";
            this.btnremovecat.UseVisualStyleBackColor = true;
            this.btnremovecat.Click += new System.EventHandler(this.btnremovecat_Click);
            // 
            // btnaddcat
            // 
            this.btnaddcat.Location = new System.Drawing.Point(599, 271);
            this.btnaddcat.Name = "btnaddcat";
            this.btnaddcat.Size = new System.Drawing.Size(75, 55);
            this.btnaddcat.TabIndex = 14;
            this.btnaddcat.Text = "Add Category";
            this.btnaddcat.UseVisualStyleBackColor = true;
            this.btnaddcat.Click += new System.EventHandler(this.btnaddcat_Click);
            // 
            // btnremovepro
            // 
            this.btnremovepro.Location = new System.Drawing.Point(407, 368);
            this.btnremovepro.Name = "btnremovepro";
            this.btnremovepro.Size = new System.Drawing.Size(75, 55);
            this.btnremovepro.TabIndex = 15;
            this.btnremovepro.Text = "Remove Product";
            this.btnremovepro.UseVisualStyleBackColor = true;
            this.btnremovepro.Click += new System.EventHandler(this.btnremovepro_Click);
            // 
            // btneditpro
            // 
            this.btneditpro.Location = new System.Drawing.Point(326, 368);
            this.btneditpro.Name = "btneditpro";
            this.btneditpro.Size = new System.Drawing.Size(75, 55);
            this.btneditpro.TabIndex = 16;
            this.btneditpro.Text = "Edit Product";
            this.btneditpro.UseVisualStyleBackColor = true;
            this.btneditpro.Click += new System.EventHandler(this.btneditpro_Click);
            // 
            // btnaddpro
            // 
            this.btnaddpro.Location = new System.Drawing.Point(245, 368);
            this.btnaddpro.Name = "btnaddpro";
            this.btnaddpro.Size = new System.Drawing.Size(75, 55);
            this.btnaddpro.TabIndex = 17;
            this.btnaddpro.Text = "Add Product";
            this.btnaddpro.UseVisualStyleBackColor = true;
            this.btnaddpro.Click += new System.EventHandler(this.btnaddpro_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(286, 15);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(63, 22);
            this.btnfilter.TabIndex = 18;
            this.btnfilter.Text = "Filter:";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // txtdetharga
            // 
            this.txtdetharga.Location = new System.Drawing.Point(101, 381);
            this.txtdetharga.Name = "txtdetharga";
            this.txtdetharga.Size = new System.Drawing.Size(121, 22);
            this.txtdetharga.TabIndex = 19;
            this.txtdetharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdetharga_KeyPress);
            // 
            // txtdetstock
            // 
            this.txtdetstock.Location = new System.Drawing.Point(101, 409);
            this.txtdetstock.Name = "txtdetstock";
            this.txtdetstock.Size = new System.Drawing.Size(121, 22);
            this.txtdetstock.TabIndex = 20;
            this.txtdetstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdetstock_KeyPress);
            // 
            // DGV2
            // 
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Location = new System.Drawing.Point(524, 46);
            this.DGV2.Name = "DGV2";
            this.DGV2.RowHeadersVisible = false;
            this.DGV2.RowHeadersWidth = 51;
            this.DGV2.RowTemplate.Height = 24;
            this.DGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV2.Size = new System.Drawing.Size(251, 168);
            this.DGV2.TabIndex = 21;
            // 
            // txtcat
            // 
            this.txtcat.Location = new System.Drawing.Point(577, 233);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(198, 22);
            this.txtcat.TabIndex = 22;
            // 
            // cmbproduct
            // 
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(361, 13);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(121, 24);
            this.cmbproduct.TabIndex = 23;
            this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbproduct);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.DGV2);
            this.Controls.Add(this.txtdetstock);
            this.Controls.Add(this.txtdetharga);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.btnaddpro);
            this.Controls.Add(this.btneditpro);
            this.Controls.Add(this.btnremovepro);
            this.Controls.Add(this.btnaddcat);
            this.Controls.Add(this.btnremovecat);
            this.Controls.Add(this.cmbdet);
            this.Controls.Add(this.lbldetails);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lblharga);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lblnamacat);
            this.Controls.Add(this.txtdetnama);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.lblproduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.TextBox txtdetnama;
        private System.Windows.Forms.Label lblnamacat;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label lblharga;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label lbldetails;
        private System.Windows.Forms.ComboBox cmbdet;
        private System.Windows.Forms.Button btnremovecat;
        private System.Windows.Forms.Button btnaddcat;
        private System.Windows.Forms.Button btnremovepro;
        private System.Windows.Forms.Button btneditpro;
        private System.Windows.Forms.Button btnaddpro;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.TextBox txtdetharga;
        private System.Windows.Forms.TextBox txtdetstock;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.TextBox txtcat;
        private System.Windows.Forms.ComboBox cmbproduct;
    }
}

