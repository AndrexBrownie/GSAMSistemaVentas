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
    public partial class PrincipalUI : Form
    {
        public PrincipalUI()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoUI.Instance.MdiParent = this;
            ProductoUI.Instance.WindowState = FormWindowState.Maximized;
            ProductoUI.Instance.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            productosToolStripMenuItem_Click(sender, e);
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriaUI.Instance.MdiParent = this;
            CategoriaUI.Instance.WindowState = FormWindowState.Maximized;
            CategoriaUI.Instance.Show();
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            categoriasToolStripMenuItem1_Click(sender, e);
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcaUI.Instance.MdiParent = this;
            MarcaUI.Instance.WindowState = FormWindowState.Maximized;
            MarcaUI.Instance.Show();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            marcasToolStripMenuItem_Click(sender, e);
        }

        private void medidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UMedidaUI.Instance.MdiParent = this;
            UMedidaUI.Instance.WindowState = FormWindowState.Maximized;
            UMedidaUI.Instance.Show();
        }
        private void btnUMedida_Click(object sender, EventArgs e)
        {
            medidaToolStripMenuItem_Click(sender, e);
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorUI.Instance.MdiParent = this;
            ProveedorUI.Instance.WindowState = FormWindowState.Maximized;
            ProveedorUI.Instance.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            proveedoresToolStripMenuItem_Click(sender, e);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteUI.Instance.MdiParent = this;
            ClienteUI.Instance.WindowState = FormWindowState.Maximized;
            ClienteUI.Instance.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            clientesToolStripMenuItem_Click(sender, e);
        }

        private void PrincipalUI_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoUI.Instance.MdiParent = this;
            EmpleadoUI.Instance.WindowState = FormWindowState.Maximized;
            EmpleadoUI.Instance.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            empleadosToolStripMenuItem_Click(sender, e);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //AcercaDeUI.Instance.MdiParent = this;
            //AcercaDeUI.Instance.WindowState = FormWindowState.Maximized;
          //  AcercaDeUI.Instance.Show();

            AcercaDeUI ventana4 = new AcercaDeUI();
            this.Show();
            ventana4.ShowDialog();
        }
    }
    
}
