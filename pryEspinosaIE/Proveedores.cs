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
    public partial class frmSistemaGestion : Form
    {
        public frmSistemaGestion()
        {
            InitializeComponent();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaProveedores frmCargaProveedores = new frmCargaProveedores();
            frmCargaProveedores.ShowDialog();
        }

 

        private void frmSistemaGestion_Load(object sender, EventArgs e)
        {

        }

        private void carpetasDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarpetaDeProveedores frmCarpetaDeProveedores = new frmCarpetaDeProveedores();
            frmCarpetaDeProveedores.ShowDialog();
                
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
