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
    public partial class ClienteDetalleUI : Form
    {
        public MisConstantes.CRUD Operacion { get; set; }
        public string Documento { get; set; }

        public ClienteDetalleUI()
        {
            InitializeComponent();
        }

        private void ClienteDetalleUI_Load(object sender, EventArgs e)
        {
            //Llenamos el combo Documento
            cboDocumento.DataSource = new DocumentoLogic().Documento_Select_simple();
            cboDocumento.DisplayMember = "Tipo";
            cboDocumento.ValueMember = "DocumentoID";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var obj = new Cliente
            {
                ClienteID = lblID.Text.Length == 0 ? 0 : int.Parse(lblID.Text),
                Nombres = txtNombre.Text.Trim().ToUpper(),
                Apellidos = txtApellido.Text.Trim().ToUpper(),
                NumDoc = txtNumDoc.Text.Trim().ToUpper(),
                RazonSocial = txtRazonSocial.Text.Trim().ToUpper(),
                RUC = txtRUC.Text.Trim().ToUpper(),
                Direccion = txtDireccion.Text.Trim().ToUpper(),
                Estado = chkEstado.Checked,
                DocumentoID = Convert.ToInt32(cboDocumento.SelectedValue),

            };

            int rpta = 0;
            if (Operacion == MisConstantes.CRUD.Insercion)
            {
                rpta = new ClienteLogic().Insert(obj);
            }

            if (Operacion == MisConstantes.CRUD.Modificacion)
            {
                rpta = new ClienteLogic().Update(obj);
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
