namespace sistema_de_productos
{
    partial class Form2_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_productos));
            this.data_gv_listadoproduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_presentacion_buscar_product = new System.Windows.Forms.TextBox();
            this.txtbox_descripcion_buscar_product = new System.Windows.Forms.TextBox();
            this.btn_buscar_product = new System.Windows.Forms.Button();
            this.btn_sucursales = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv_listadoproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_gv_listadoproduct
            // 
            this.data_gv_listadoproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gv_listadoproduct.Location = new System.Drawing.Point(0, 51);
            this.data_gv_listadoproduct.Margin = new System.Windows.Forms.Padding(2);
            this.data_gv_listadoproduct.Name = "data_gv_listadoproduct";
            this.data_gv_listadoproduct.RowTemplate.Height = 24;
            this.data_gv_listadoproduct.Size = new System.Drawing.Size(710, 425);
            this.data_gv_listadoproduct.TabIndex = 1;
            this.data_gv_listadoproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gv_listadoproduct_CellClick);
            this.data_gv_listadoproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(776, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(814, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Buscar Productos";
            // 
            // txtbox_presentacion_buscar_product
            // 
            this.txtbox_presentacion_buscar_product.Location = new System.Drawing.Point(900, 127);
            this.txtbox_presentacion_buscar_product.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_presentacion_buscar_product.Name = "txtbox_presentacion_buscar_product";
            this.txtbox_presentacion_buscar_product.Size = new System.Drawing.Size(128, 20);
            this.txtbox_presentacion_buscar_product.TabIndex = 9;
            this.txtbox_presentacion_buscar_product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_presentacion_buscar_product_KeyPress);
            // 
            // txtbox_descripcion_buscar_product
            // 
            this.txtbox_descripcion_buscar_product.Location = new System.Drawing.Point(897, 180);
            this.txtbox_descripcion_buscar_product.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_descripcion_buscar_product.Name = "txtbox_descripcion_buscar_product";
            this.txtbox_descripcion_buscar_product.Size = new System.Drawing.Size(128, 20);
            this.txtbox_descripcion_buscar_product.TabIndex = 10;
            // 
            // btn_buscar_product
            // 
            this.btn_buscar_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_product.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_buscar_product.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_buscar_product.Location = new System.Drawing.Point(860, 252);
            this.btn_buscar_product.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar_product.Name = "btn_buscar_product";
            this.btn_buscar_product.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_buscar_product.Size = new System.Drawing.Size(180, 63);
            this.btn_buscar_product.TabIndex = 12;
            this.btn_buscar_product.Text = "Buscar";
            this.btn_buscar_product.UseVisualStyleBackColor = true;
            this.btn_buscar_product.Click += new System.EventHandler(this.btn_buscar_product_Click);
            // 
            // btn_sucursales
            // 
            this.btn_sucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sucursales.ForeColor = System.Drawing.Color.Red;
            this.btn_sucursales.Location = new System.Drawing.Point(886, 447);
            this.btn_sucursales.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sucursales.Name = "btn_sucursales";
            this.btn_sucursales.Size = new System.Drawing.Size(154, 77);
            this.btn_sucursales.TabIndex = 13;
            this.btn_sucursales.Text = "Establecimiento disponible";
            this.btn_sucursales.UseVisualStyleBackColor = true;
            this.btn_sucursales.Click += new System.EventHandler(this.btn_sucursales_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(881, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Otras Sucursales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1044, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 551);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_sucursales);
            this.Controls.Add(this.btn_buscar_product);
            this.Controls.Add(this.txtbox_descripcion_buscar_product);
            this.Controls.Add(this.txtbox_presentacion_buscar_product);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_gv_listadoproduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2_productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form2_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_gv_listadoproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView data_gv_listadoproduct;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtbox_presentacion_buscar_product;
        public System.Windows.Forms.TextBox txtbox_descripcion_buscar_product;
        public System.Windows.Forms.Button btn_buscar_product;
        public System.Windows.Forms.Button btn_sucursales;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}