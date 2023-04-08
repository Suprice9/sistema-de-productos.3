namespace sistema_de_productos
{
    partial class Form4_ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_ventas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnt_agregarlista = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.txt_producto_compra = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_cantidad_compra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_suplidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocompa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.txt_venta_compra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbSuplidor = new System.Windows.Forms.ComboBox();
            this.btnAgregarSuplidor = new System.Windows.Forms.Button();
            this.datatimeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra para abastecer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suplidor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // bnt_agregarlista
            // 
            this.bnt_agregarlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_agregarlista.Location = new System.Drawing.Point(16, 422);
            this.bnt_agregarlista.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_agregarlista.Name = "bnt_agregarlista";
            this.bnt_agregarlista.Size = new System.Drawing.Size(122, 31);
            this.bnt_agregarlista.TabIndex = 5;
            this.bnt_agregarlista.Text = "Agregar a la  lista";
            this.bnt_agregarlista.UseVisualStyleBackColor = true;
            this.bnt_agregarlista.Click += new System.EventHandler(this.bnt_agregarlista_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compra.Location = new System.Drawing.Point(162, 422);
            this.btn_compra.Margin = new System.Windows.Forms.Padding(2);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(122, 31);
            this.btn_compra.TabIndex = 6;
            this.btn_compra.Text = "Realizar Compra";
            this.btn_compra.UseVisualStyleBackColor = true;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // txt_producto_compra
            // 
            this.txt_producto_compra.Location = new System.Drawing.Point(104, 175);
            this.txt_producto_compra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_producto_compra.Name = "txt_producto_compra";
            this.txt_producto_compra.Size = new System.Drawing.Size(120, 20);
            this.txt_producto_compra.TabIndex = 8;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(114, 210);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(110, 20);
            this.txt_descripcion.TabIndex = 9;
            // 
            // txt_cantidad_compra
            // 
            this.txt_cantidad_compra.Location = new System.Drawing.Point(104, 250);
            this.txt_cantidad_compra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad_compra.Name = "txt_cantidad_compra";
            this.txt_cantidad_compra.Size = new System.Drawing.Size(120, 20);
            this.txt_cantidad_compra.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_suplidor,
            this.producto,
            this.descripcion,
            this.preciocompa,
            this.precioventa,
            this.fechavencimiento,
            this.cantidad});
            this.dataGridView1.Location = new System.Drawing.Point(379, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 465);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_suplidor
            // 
            this.id_suplidor.HeaderText = "id_suplidor";
            this.id_suplidor.MinimumWidth = 6;
            this.id_suplidor.Name = "id_suplidor";
            this.id_suplidor.Width = 125;
            // 
            // producto
            // 
            this.producto.HeaderText = "producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 125;
            // 
            // preciocompa
            // 
            this.preciocompa.HeaderText = "preciocompa";
            this.preciocompa.MinimumWidth = 6;
            this.preciocompa.Name = "preciocompa";
            this.preciocompa.Width = 125;
            // 
            // precioventa
            // 
            this.precioventa.HeaderText = "precioventa";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.Width = 125;
            // 
            // fechavencimiento
            // 
            this.fechavencimiento.HeaderText = "fechavencimiento";
            this.fechavencimiento.MinimumWidth = 6;
            this.fechavencimiento.Name = "fechavencimiento";
            this.fechavencimiento.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio de compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio de venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha de vencimiento";
            // 
            // txt_precio_compra
            // 
            this.txt_precio_compra.Location = new System.Drawing.Point(153, 287);
            this.txt_precio_compra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(102, 20);
            this.txt_precio_compra.TabIndex = 15;
            // 
            // txt_venta_compra
            // 
            this.txt_venta_compra.Location = new System.Drawing.Point(142, 319);
            this.txt_venta_compra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_venta_compra.Name = "txt_venta_compra";
            this.txt_venta_compra.Size = new System.Drawing.Size(102, 20);
            this.txt_venta_compra.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(588, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lista de compra de medicamentos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(914, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(968, 21);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(13, 17);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = ".";
            // 
            // cmbSuplidor
            // 
            this.cmbSuplidor.FormattingEnabled = true;
            this.cmbSuplidor.Location = new System.Drawing.Point(103, 144);
            this.cmbSuplidor.Name = "cmbSuplidor";
            this.cmbSuplidor.Size = new System.Drawing.Size(121, 21);
            this.cmbSuplidor.TabIndex = 21;
            this.cmbSuplidor.SelectedIndexChanged += new System.EventHandler(this.cmbSuplidor_SelectedIndexChanged);
            // 
            // btnAgregarSuplidor
            // 
            this.btnAgregarSuplidor.Location = new System.Drawing.Point(230, 142);
            this.btnAgregarSuplidor.Name = "btnAgregarSuplidor";
            this.btnAgregarSuplidor.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarSuplidor.TabIndex = 22;
            this.btnAgregarSuplidor.Text = "Agregar suplidor";
            this.btnAgregarSuplidor.UseVisualStyleBackColor = true;
            this.btnAgregarSuplidor.Click += new System.EventHandler(this.btnAgregarSuplidor_Click);
            // 
            // datatimeVencimiento
            // 
            this.datatimeVencimiento.Location = new System.Drawing.Point(191, 352);
            this.datatimeVencimiento.Name = "datatimeVencimiento";
            this.datatimeVencimiento.Size = new System.Drawing.Size(183, 20);
            this.datatimeVencimiento.TabIndex = 23;
            this.datatimeVencimiento.Value = new System.DateTime(2023, 4, 22, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datatimeVencimiento);
            this.Controls.Add(this.btnAgregarSuplidor);
            this.Controls.Add(this.cmbSuplidor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_venta_compra);
            this.Controls.Add(this.txt_precio_compra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cantidad_compra);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_producto_compra);
            this.Controls.Add(this.btn_compra);
            this.Controls.Add(this.bnt_agregarlista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4_ventas";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Form4_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bnt_agregarlista;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.TextBox txt_producto_compra;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_cantidad_compra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.TextBox txt_venta_compra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_suplidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocompa;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbSuplidor;
        private System.Windows.Forms.Button btnAgregarSuplidor;
        private System.Windows.Forms.DateTimePicker datatimeVencimiento;
        private System.Windows.Forms.Button button1;
    }
}