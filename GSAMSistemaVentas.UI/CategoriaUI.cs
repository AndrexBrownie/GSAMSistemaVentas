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
    public partial class CategoriaUI : Form
    {
        private static CategoriaUI instance = null;
        private CategoriaUI()
        {
            InitializeComponent();
        }
        public static CategoriaUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoriaUI();
                    instance.Disposed += new EventHandler(MyDisposed);
                }
                return instance;
            }
        }
        public static void MyDisposed(object sender, EventArgs e)
        {
            instance = null;
        }

        private void CategoriaUI_Load(object sender, EventArgs e)
        {
            chkEstado.Checked = true;
            MostrarDatos(new CategoriaLogic().GetAll(true));

        }

        private void MostrarDatos(List<Categoria> lista)
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
            dataGridView1.Columns["CategoriaID"].HeaderText = "ID";
            dataGridView1.Columns["CategoriaID"].DataPropertyName = "CategoriaID";
            dataGridView1.Columns["CategoriaID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["CategoriaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CategoriaID"].ReadOnly = true;

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


            dataGridView1.Columns["Estado"].DataPropertyName = "Estado";
            dataGridView1.Columns["Estado"].Visible = false;

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            MostrarDatos(new CategoriaLogic().GetAll(chkEstado.Checked));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var detalle = new CategoriaDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Insercion;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new CategoriaLogic().GetAll(true));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var detalle = new CategoriaDetalleUI();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.Operacion = MisConstantes.CRUD.Modificacion;

            detalle.lblID.Text = dataGridView1.CurrentRow.Cells["CategoriaID"].Value.ToString();
            detalle.txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            detalle.txtDesripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            detalle.chkEstado.Checked = (bool)dataGridView1.CurrentRow.Cells["Estado"].Value;

            var rpta = detalle.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                MostrarDatos(new CategoriaLogic().GetAll(true));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                DialogResult result =
                    MessageBox.Show("¿Esta seguro de eliminar la categoria " + nombre + "?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["CategoriaID"].Value;
                    int rpta = new CategoriaLogic().Delete(id);
                    if (rpta >= 1)
                    {
                        MessageBox.Show("Datos eliminados correctamente", "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        MostrarDatos(new CategoriaLogic().GetAll(true));
                    }
                }
            }
        }
    }
}
