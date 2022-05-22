using GSAMSistemaVentas.Entity;
using GSAMSistemaVentas.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSAMSistemaVentas.UI
{
    public partial class ProductoDetalleUI : Form
    {
        public MisConstantes.CRUD Operacion { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
        public string UMedida { get; set; }
        public ProductoDetalleUI()
        {
            InitializeComponent();
        }

        private void ProductoDetalleUI_Load(object sender, EventArgs e)
        {
            //Llenamos el combo Categoria
            cboCategoria.DataSource = new CategoriaLogic().Categoria_Select_simple();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "CategoriaID";

            //Llenamos el combo Unidad de Medida
            cboUnidad.DataSource = new UMedidaLogic().UMedida_Select_simple();
            cboUnidad.DisplayMember = "Nombre";
            cboUnidad.ValueMember = "UMedidaID";

            //Llenamos el combo Marca
            cboMarca.DataSource = new MarcaLogic().Marca_Select_simple();
            cboMarca.DisplayMember = "Nombres";
            cboMarca.ValueMember = "MarcaID";

            //Llenamos el combo Proveedor
            cboProveedor.DataSource = new ProveedorLogic().Proveedor_Select_simple();
            cboProveedor.DisplayMember = "RazonSocial";
            cboProveedor.ValueMember = "ProveedorID";

            if (Operacion == MisConstantes.CRUD.Modificacion)
            {
                cboCategoria.Text = Categoria;
                cboMarca.Text = Marca;
                cboProveedor.Text = Proveedor;
                cboUnidad.Text = UMedida;
            }
            if (Operacion == MisConstantes.CRUD.Insercion)
            {
                cboCategoria.Text = "";
                cboMarca.Text = "";
                cboProveedor.Text = "";
                cboUnidad.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var obj = new Producto
            {
                ProductoID = lblID.Text.Length == 0 ? 0 : int.Parse(lblID.Text),
                Nombre = txtNombre.Text.Trim().ToUpper(),
                Descripcion = txtDesripcion.Text.Trim().ToUpper(),
                Estado = chkEstado.Checked,
                CategoriaID = Convert.ToInt32(cboCategoria.SelectedValue),
                ProveedorID = Convert.ToInt32(cboProveedor.SelectedValue),
                MarcaID = Convert.ToInt32(cboMarca.SelectedValue),
                UMedidaID = Convert.ToInt32(cboUnidad.SelectedValue),
                PrecioCosto = nudPC.Value,
                PrecioVenta = nudPV.Value,
                Stock = (int)nudStock.Value,
                StockMinimo = (int)nudStockMin.Value
            };

            int rpta = 0;
            if (Operacion == MisConstantes.CRUD.Insercion)
            {
                rpta = new ProductoLogic().Insert(obj);
            }

            if (Operacion==MisConstantes.CRUD.Modificacion)
            {
                rpta = new ProductoLogic().Update(obj);
            }

            if (rpta > 0 )
            {
                MessageBox.Show("Operacion Exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
