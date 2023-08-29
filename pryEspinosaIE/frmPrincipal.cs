using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEspinosaIE
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSistemaGestion frm = new frmSistemaGestion();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.logo_seguros;
        }
    }
}
