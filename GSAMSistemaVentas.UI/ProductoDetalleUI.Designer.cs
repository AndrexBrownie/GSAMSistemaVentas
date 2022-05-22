
namespace GSAMSistemaVentas.UI
{
    partial class ProductoDetalleUI
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
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.nudStockMin = new System.Windows.Forms.NumericUpDown();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.txtDesripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudPV = new System.Windows.Forms.NumericUpDown();
            this.nudPC = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPC)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(29, 405);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(75, 23);
            this.chkEstado.TabIndex = 51;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(144, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 27);
            this.lblID.TabIndex = 50;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(360, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 41);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar [Esc]";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(216, 395);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 41);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guadar [F12]";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.SystemColors.Menu;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(144, 55);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(347, 27);
            this.cboCategoria.TabIndex = 47;
            // 
            // nudStockMin
            // 
            this.nudStockMin.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockMin.Location = new System.Drawing.Point(377, 320);
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(114, 27);
            this.nudStockMin.TabIndex = 46;
            this.nudStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudStock
            // 
            this.nudStock.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStock.Location = new System.Drawing.Point(377, 288);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(114, 27);
            this.nudStock.TabIndex = 45;
            this.nudStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(281, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "STOCK:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "STOCK MIN:";
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProveedor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(144, 246);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(347, 27);
            this.cboProveedor.TabIndex = 42;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(144, 213);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(347, 27);
            this.cboMarca.TabIndex = 41;
            // 
            // cboUnidad
            // 
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnidad.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(144, 180);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(347, 27);
            this.cboUnidad.TabIndex = 40;
            // 
            // txtDesripcion
            // 
            this.txtDesripcion.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesripcion.Location = new System.Drawing.Point(144, 121);
            this.txtDesripcion.Multiline = true;
            this.txtDesripcion.Name = "txtDesripcion";
            this.txtDesripcion.Size = new System.Drawing.Size(347, 53);
            this.txtDesripcion.TabIndex = 39;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(144, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(347, 27);
            this.txtNombre.TabIndex = 38;
            // 
            // nudPV
            // 
            this.nudPV.DecimalPlaces = 2;
            this.nudPV.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPV.Location = new System.Drawing.Point(144, 322);
            this.nudPV.Name = "nudPV";
            this.nudPV.Size = new System.Drawing.Size(114, 27);
            this.nudPV.TabIndex = 37;
            this.nudPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPC
            // 
            this.nudPC.DecimalPlaces = 2;
            this.nudPC.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPC.Location = new System.Drawing.Point(144, 288);
            this.nudPC.Name = "nudPC";
            this.nudPC.Size = new System.Drawing.Size(114, 27);
            this.nudPC.TabIndex = 36;
            this.nudPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "PRECIO VENTA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "PRECIO COSTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "PROVEEDOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "MARCA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "UNIDAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "DESCRIPCION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "CATEGORIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            // 
            // ProductoDetalleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.nudStockMin);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboUnidad);
            this.Controls.Add(this.txtDesripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nudPV);
            this.Controls.Add(this.nudPC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductoDetalleUI";
            this.Text = "ProductoDetalleUI";
            this.Load += new System.EventHandler(this.ProductoDetalleUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkEstado;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ComboBox cboCategoria;
        public System.Windows.Forms.NumericUpDown nudStockMin;
        public System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cboProveedor;
        public System.Windows.Forms.ComboBox cboMarca;
        public System.Windows.Forms.ComboBox cboUnidad;
        public System.Windows.Forms.TextBox txtDesripcion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.NumericUpDown nudPV;
        public System.Windows.Forms.NumericUpDown nudPC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}