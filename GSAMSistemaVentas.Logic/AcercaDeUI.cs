using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSAMSistemaVentas.Logic
{
    public partial class AcercaDeUI : Form
    {
        private static AcercaDeUI instance = null;
        private AcercaDeUI()
        {
            InitializeComponent();
        }

        public static AcercaDeUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AcercaDeUI();
                    instance.Disposed += new EventHandler(MyDisposed);
                }
                return instance;
            }
        }
        public static void MyDisposed(object sender, EventArgs e)
        {
            instance = null;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
