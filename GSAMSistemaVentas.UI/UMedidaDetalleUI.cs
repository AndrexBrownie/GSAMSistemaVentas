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
    public partial class UMedidaDetalleUI : Form
    {
        public MisConstantes.CRUD Operacion { get; set; }
        public UMedidaDetalleUI()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var obj = new UMedida
            {
                UMedidaID = lblID.Text.Length == 0 ? 0 : int.Parse(lblID.Text),
                Cod = txtCod.Text.Trim().ToUpper(),
                Nombre = txtNombre.Text.Trim().ToUpper(),
                Estado = chkEstado.Checked,
            };

            int rpta = 0;
            if (Operacion == MisConstantes.CRUD.Insercion)
            {
                rpta = new UMedidaLogic().Insert(obj);
            }

            if (Operacion == MisConstantes.CRUD.Modificacion)
            {
                rpta = new UMedidaLogic().Update(obj);
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
