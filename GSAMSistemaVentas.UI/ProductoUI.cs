using GSAMSistemaVentas.Entity;
using GSAMSistemaVentas.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GSAMSistemaVentas.UI
{
    public partial class ProductoUI : Form
    {
        private static ProductoUI instance = null;

        private ProductoUI()
        {
            InitializeComponent();
        }

        public static ProductoUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductoUI();
                    instance.Disposed += new EventHandler(MyDisposed);
                }
                return instance;
            }
        }
        public static void MyDisposed(object sender, EventArgs e)
        {
            instance = null;
        }

        private void MostrarDatos(List<Producto> lista)
        {
            dataGridView1.DataSource = lista;

            //Configuración del estilo de las columnas
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font=new Font("Microsoft Sans Serif",10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Configuración del estilo de las filas
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

            //Configuración de los permisos para edición de filas
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;

            //Configuración el modo de selección de celdas
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            //Configuración de las columnas
            dataGridView1.Columns["ProductoID"].HeaderText = "ID";
            dataGridView1.Columns["ProductoID"].DataPropertyName = "ProductoID";
            dataGridView1.Columns["ProductoID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ProductoID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ProductoID"].ReadOnly = true;

            dataGridView1.Columns["CategoriaID"].DataPropertyName = "CategoriaID";
            dataGridView1.Columns["CategoriaID"].Visible = false;

            dataGridView1.Columns["UMedidaID"].DataPropertyName = "UMedidaID";
            dataGridView1.Columns["UMedidaID"].Visible = false;

            dataGridView1.Columns["MarcaID"].DataPropertyName = "MarcaID";
            dataGridView1.Columns["MarcaID"].Visible = false;

            dataGridView1.Columns["ProveedorID"].DataPropertyName = "ProveedorID";
            dataGridView1.Columns["ProveedorID"].Visible = false;

            dataGridView1.Columns["Nombre"].HeaderText = "NOMBRE";
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Nombre"].ReadOnly = true;

            dataGridView1.Columns["Descripcion"].HeaderText = "DESCRIPCIÓN";
            dataGridView1.Columns["Descripcion"].DataPropertyName = "Descripcion";
            dataGridView1.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Descripcion"].ReadOnly = true;

            dataGridView1.Columns["PrecioCosto"].HeaderText = "P. COSTO";
            dataGridView1.Columns["PrecioCosto"].DataPropertyName = "PrecioCosto";
            dataGridView1.Columns["PrecioCosto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["PrecioCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["PrecioCosto"].ReadOnly = true;

            dataGridView1.Columns["PrecioVenta"].HeaderText = "P. VENTA";
            dataGridView1.Columns["PrecioVenta"].DataPropertyName = "PrecioVenta";
            dataGridView1.Columns["PrecioVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["PrecioVenta"].ReadOnly = true;

            dataGridView1.Columns["Stock"].HeaderText = "STOCK";
            dataGridView1.Columns["Stock"].DataPropertyName = "Stock";
            dataGridView1.Columns["Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Stock"].ReadOnly = true;

            dataGridView1.Columns["StockMinimo"].HeaderText = "S. MIN";
            dataGridView1.Columns["StockMinimo"].DataPropertyName = "StockMinimo";
            dataGridView1.Columns["StockMinimo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["StockMinimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["StockMinimo"].ReadOnly = true;

            dataGridView1.Columns["Estado"].DataPropertyName = "Estado";
            dataGridView1.Columns["Estado"].Visible = false;

            dataGridView1.Columns["Categoria"].HeaderText = "CATEG.";
            dataGridView1.Columns["Categoria"].DataPropertyName = "Categoria";
            dataGridView1.Columns["Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Categoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Categoria"].ReadOnly = true;

            dataGridView1.Columns["UMedida"].DataPropertyName = "UMedida";
            dataGridView1.Columns["UMedida"].Visible = false;

            dataGridView1.Columns["Marca"].HeaderText = "MARCA";
            dataGridView1.Columns["Marca"].DataPropertyName = "Marca";
            dataGridView1.Columns["Marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Marca"].ReadOnly = true;

            dataGridView1.Columns["Proveedor"].DataPropertyName = "Proveedor";
            dataGridView1.Columns["Proveedor"].Visible = false;
        }


        private void ProductoUI_Load(object sender, EventArgs e)
        {
            chkEstado.Checked = true;
            MostrarDatos(new ProductoLogic().GetAll(true));
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ProductoLogic().GetAll(chkEstado.Checked);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var detalle = new ProductoDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Insercion;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK) 
            {
                MostrarDatos(new ProductoLogic().GetAll(true));
            }
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var detalle = new ProductoDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Modificacion;

            detalle.lblID.Text = dataGridView1.CurrentRow.Cells["ProductoID"].Value.ToString();
            detalle.txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            detalle.txtDesripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            detalle.nudPC.Value = (decimal)dataGridView1.CurrentRow.Cells["PrecioCosto"].Value;
            detalle.nudPV.Value = (decimal)dataGridView1.CurrentRow.Cells["PrecioVenta"].Value;
            detalle.nudStock.Value = (int)dataGridView1.CurrentRow.Cells["Stock"].Value;
            detalle.nudStockMin.Value = (int)dataGridView1.CurrentRow.Cells["StockMinimo"].Value;

            detalle.Categoria = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
            detalle.Marca = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
            detalle.Proveedor = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();
            detalle.UMedida = dataGridView1.CurrentRow.Cells["UMedida"].Value.ToString();
            detalle.chkEstado.Checked = (bool)dataGridView1.CurrentRow.Cells["Estado"].Value;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new ProductoLogic().GetAll(true));
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                DialogResult result =
                    MessageBox.Show("¿Esta seguro de eliminar el producto " + nombre + "?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["ProductoID"].Value;
                    int rpta = new ProductoLogic().Delete(id);
                    if (rpta >= 1)
                    {
                        MessageBox.Show("Datos eliminados correctamente", "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        MostrarDatos(new ProductoLogic().GetAll(true));
                    }
                }
            }
        }
    }
}
