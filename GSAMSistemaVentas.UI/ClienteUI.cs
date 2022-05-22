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
    public partial class ClienteUI : Form
    {
        private static ClienteUI instance = null;
        private ClienteUI()
        {
            InitializeComponent();
        }
        public static ClienteUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClienteUI();
                    instance.Disposed += new EventHandler(MyDisposed);
                }
                return instance;
            }
        }
        public static void MyDisposed(object sender, EventArgs e)
        {
            instance = null;
        }


        private void ClienteUI_Load(object sender, EventArgs e)
        {
            chkEstado.Checked = true;
            MostrarDatos(new ClienteLogic().GetAll(true));
        }

        private void MostrarDatos(List<Cliente> lista)
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
            dataGridView1.Columns["ClienteID"].HeaderText = "ID";
            dataGridView1.Columns["ClienteID"].DataPropertyName = "ClienteID";
            dataGridView1.Columns["ClienteID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ClienteID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ClienteID"].ReadOnly = true;

            dataGridView1.Columns["DocumentoID"].DataPropertyName = "DocumentoID";
            dataGridView1.Columns["DocumentoID"].Visible = false;

            dataGridView1.Columns["Nombres"].HeaderText = "NOMBRE";
            dataGridView1.Columns["Nombres"].DataPropertyName = "Nombres";
            dataGridView1.Columns["Nombres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Nombres"].ReadOnly = true;

            dataGridView1.Columns["Apellidos"].HeaderText = "APELLIDO";
            dataGridView1.Columns["Apellidos"].DataPropertyName = "Apellidos";
            dataGridView1.Columns["Apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Apellidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Apellidos"].ReadOnly = true;

            dataGridView1.Columns["TipoDocumento"].HeaderText = "TIPO DOCUMENTO";
            dataGridView1.Columns["TipoDocumento"].DataPropertyName = "TipoDocumento";
            dataGridView1.Columns["TipoDocumento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["TipoDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["TipoDocumento"].ReadOnly = true;


            dataGridView1.Columns["NumDoc"].HeaderText = "Num. Doc";
            dataGridView1.Columns["NumDoc"].DataPropertyName = "NumDoc";
            dataGridView1.Columns["NumDoc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["NumDoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["NumDoc"].ReadOnly = true;

            dataGridView1.Columns["RazonSocial"].HeaderText = "RAZON SOCIAL";
            dataGridView1.Columns["RazonSocial"].DataPropertyName = "RazonSocial";
            dataGridView1.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["RazonSocial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["RazonSocial"].ReadOnly = true;

            dataGridView1.Columns["Direccion"].HeaderText = "DIRECCION";
            dataGridView1.Columns["Direccion"].DataPropertyName = "Direccion";
            dataGridView1.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Direccion"].ReadOnly = true;

            dataGridView1.Columns["Estado"].DataPropertyName = "Estado";
            dataGridView1.Columns["Estado"].Visible = false;

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var detalle = new ClienteDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Insercion;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new ClienteLogic().GetAll(true));
            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ClienteLogic().GetAll(chkEstado.Checked);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var detalle = new ClienteDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Modificacion;

            detalle.lblID.Text = dataGridView1.CurrentRow.Cells["ClienteID"].Value.ToString();
            detalle.txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
            detalle.txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
            detalle.txtNumDoc.Text = dataGridView1.CurrentRow.Cells["NumDoc"].Value.ToString();
            detalle.txtRazonSocial.Text = dataGridView1.CurrentRow.Cells["RazonSocial"].Value.ToString();
            detalle.txtRUC.Text = dataGridView1.CurrentRow.Cells["RUC"].Value.ToString();
            detalle.txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            detalle.Documento = dataGridView1.CurrentRow.Cells["TipoDocumento"].Value.ToString();
            detalle.chkEstado.Checked = (bool)dataGridView1.CurrentRow.Cells["Estado"].Value;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new ClienteLogic().GetAll(true));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                DialogResult result =
                    MessageBox.Show("¿Esta seguro de eliminar al cliente " + nombre + "?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["ClienteID"].Value;
                    int rpta = new ClienteLogic().Delete(id);
                    if (rpta >= 1)
                    {
                        MessageBox.Show("Datos eliminados correctamente", "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        MostrarDatos(new ClienteLogic().GetAll(true));
                    }
                }
            }
        }
    }
}
