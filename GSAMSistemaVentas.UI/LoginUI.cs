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
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "")
            {
                if (txtContraseña.Text.Trim() !="")
                {
                    string mensaje = "";
                    
                }
            }

            PrincipalUI ventana1 = new PrincipalUI();
            this.Show();
            ventana1.ShowDialog();

            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
