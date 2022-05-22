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
    public partial class EmpleadoDetalleUI : Form
    {
        public MisConstantes.CRUD Operacion { get; set; }
        public string Documento { get; set; }
        public string EmpleadoTipo { get; set; }
        public EmpleadoDetalleUI()
        {
            InitializeComponent();
        }

        private void EmpleadoDetalleUI_Load(object sender, EventArgs e)
        {
            //Llenamos el combo documento
            cboDocumento.DataSource = new DocumentoLogic().Documento_Select_simple();
            cboDocumento.DisplayMember = "Tipo";
            cboDocumento.ValueMember = "DocumentoID";

            //Llenamos el combo tipo de empleado
            cboTipoEmpleado.DataSource = new EmpleadoTipoLogic().EmpleadoTipo_Select_simple();
            cboTipoEmpleado.DisplayMember = "Nombre";
            cboTipoEmpleado.ValueMember = "EmpleadoTipoID";

            if (Operacion == MisConstantes.CRUD.Modificacion)
            {
                cboDocumento.Text = Documento;
                cboTipoEmpleado.Text = EmpleadoTipo;
                
            }
            if (Operacion == MisConstantes.CRUD.Insercion)
            {
               cboDocumento.Text = "";
               cboTipoEmpleado.Text = "";
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var obj = new Empleado
            {
                EmpleadoID = lblID.Text.Length == 0 ? 0 : int.Parse(lblID.Text),
                Nombres = txtNombre.Text.Trim().ToUpper(),
                Apellidos = txtApellidos.Text.Trim().ToUpper(),
                NumDoc = txtNumDoc.Text.Trim().ToUpper(),
                Direccion = txtdireccion.Text.Trim().ToUpper(),
                Ubigeo = txtUbigeo.Text.Trim().ToUpper(),
                Estado = chkEstado.Checked,
                DocumentoID = Convert.ToInt32(cboDocumento.SelectedValue),
                EmpleadoTipoID = Convert.ToInt32(cboTipoEmpleado.SelectedValue),
                
            };

            int rpta = 0;
            if (Operacion == MisConstantes.CRUD.Insercion)
            {
                rpta = new EmpleadoLogic().Insert(obj);
            }

            if (Operacion == MisConstantes.CRUD.Modificacion)
            {
                rpta = new EmpleadoLogic().Update(obj);
            }

            if (rpta > 0)
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
