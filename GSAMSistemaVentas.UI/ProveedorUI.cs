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
    public partial class ProveedorUI : Form
    {
        private static ProveedorUI instance = null;
        private ProveedorUI()
        {
            InitializeComponent();
        }
        public static ProveedorUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProveedorUI();
                    instance.Disposed += new EventHandler(MyDisposed);
                }
                return instance;
            }
        }
        public static void MyDisposed(object sender, EventArgs e)
        {
            instance = null;
        }
        private void ProveedorUI_Load(object sender, EventArgs e)
        {
            chkEstado.Checked = true;
            MostrarDatos(new ProveedorLogic().GetAll(true));
        }
        private void MostrarDatos(List<Proveedor> lista)
        {
            dataGridView1.DataSource = lista;

            //Configuración del estilo de las columnas
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
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
            dataGridView1.Columns["ProveedorID"].HeaderText = "ID";
            dataGridView1.Columns["ProveedorID"].DataPropertyName = "ProveedorID";
            dataGridView1.Columns["ProveedorID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ProveedorID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ProveedorID"].ReadOnly = true;

            dataGridView1.Columns["RazonSocial"].HeaderText = "RAZ. SOCIAL";
            dataGridView1.Columns["RazonSocial"].DataPropertyName = "RazonSocial";
            dataGridView1.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["RazonSocial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["RazonSocial"].ReadOnly = true;

            dataGridView1.Columns["RUC"].HeaderText = "RUC";
            dataGridView1.Columns["RUC"].DataPropertyName = "RUC";
            dataGridView1.Columns["RUC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["RUC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["RUC"].ReadOnly = true;

            dataGridView1.Columns["Direccion"].HeaderText = "DIRECCION";
            dataGridView1.Columns["Direccion"].DataPropertyName = "Direccion";
            dataGridView1.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Direccion"].ReadOnly = true;

            dataGridView1.Columns["Telf"].HeaderText = "TELEFONO";
            dataGridView1.Columns["Telf"].DataPropertyName = "Telf";
            dataGridView1.Columns["Telf"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Telf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Telf"].ReadOnly = true;

            dataGridView1.Columns["Mail"].HeaderText = "CORREO";
            dataGridView1.Columns["Mail"].DataPropertyName = "Mail";
            dataGridView1.Columns["Mail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Mail"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Mail"].ReadOnly = true;


            dataGridView1.Columns["Estado"].DataPropertyName = "Estado";
            dataGridView1.Columns["Estado"].Visible = false;

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            MostrarDatos(new ProveedorLogic().GetAll(chkEstado.Checked));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var detalle = new ProveedorDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Insercion;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new ProveedorLogic().GetAll(true));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var detalle = new ProveedorDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Modificacion;

            detalle.lblID.Text = dataGridView1.CurrentRow.Cells["ProveedorID"].Value.ToString();
            detalle.txtRazonSocial.Text = dataGridView1.CurrentRow.Cells["RazonSocial"].Value.ToString();
            detalle.txtRuc.Text = dataGridView1.CurrentRow.Cells["RUC"].Value.ToString();
            detalle.txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            detalle.txtTelf.Text = dataGridView1.CurrentRow.Cells["Telf"].Value.ToString();
            detalle.txtCorreo.Text = dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
            detalle.chkEstado.Checked = (bool)dataGridView1.CurrentRow.Cells["Estado"].Value;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new ProveedorLogic().GetAll(true));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.CurrentRow.Cells["RazonSocial"].Value.ToString();
                DialogResult result =
                    MessageBox.Show("¿Esta seguro de eliminar la categoria " + nombre + "?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["ProveedorID"].Value;
                    int rpta = new ProveedorLogic().Delete(id);
                    if (rpta >= 1)
                    {
                        MessageBox.Show("Datos eliminados correctamente", "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        MostrarDatos(new ProveedorLogic().GetAll(true));
                    }
                }
            }
        }
    }
}
