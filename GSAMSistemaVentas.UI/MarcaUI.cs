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
    public partial class MarcaUI : Form
    {
        private static MarcaUI instance = null;
        private MarcaUI()
        {
            InitializeComponent();
        }

        public static MarcaUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MarcaUI();
                    instance.Disposed += new EventHandler(MyDisposed);
                }
                return instance;
            }
        }
        public static void MyDisposed(object sender, EventArgs e)
        {
            instance = null;
        }

        private void MarcaUI_Load(object sender, EventArgs e)
        {
            chkEstado.Checked = true;
            MostrarDatos(new MarcaLogic().GetAll(true));
        }

        private void MostrarDatos(List<Marca> lista)
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
            dataGridView1.Columns["MarcaID"].HeaderText = "ID";
            dataGridView1.Columns["MarcaID"].DataPropertyName = "MarcaID";
            dataGridView1.Columns["MarcaID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["MarcaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["MarcaID"].ReadOnly = true;

            dataGridView1.Columns["Nombres"].HeaderText = "NOMBRE";
            dataGridView1.Columns["Nombres"].DataPropertyName = "Nombres";
            dataGridView1.Columns["Nombres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Nombres"].ReadOnly = true;

            dataGridView1.Columns["Estado"].DataPropertyName = "Estado";
            dataGridView1.Columns["Estado"].Visible = false;

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            MostrarDatos(new MarcaLogic().GetAll(chkEstado.Checked));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var detalle = new MarcaDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Insercion;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new MarcaLogic().GetAll(true));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var detalle = new MarcaDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Modificacion;

            detalle.lblID.Text = dataGridView1.CurrentRow.Cells["MarcaID"].Value.ToString();
            detalle.txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
            detalle.chkEstado.Checked = (bool)dataGridView1.CurrentRow.Cells["Estado"].Value;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new MarcaLogic().GetAll(true));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                DialogResult result =
                    MessageBox.Show("¿Esta seguro de eliminar la marca " + nombre + "?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["MarcaID"].Value;
                    int rpta = new MarcaLogic().Delete(id);
                    if (rpta >= 1)
                    {
                        MessageBox.Show("Datos eliminados correctamente", "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        MostrarDatos(new MarcaLogic().GetAll(true));
                    }
                }
            }
        }
    }
}
