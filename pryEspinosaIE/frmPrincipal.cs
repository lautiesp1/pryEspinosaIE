using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//Manejo de Archivos/Librerias

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
            Reloj.Enabled = true;
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            if (BarraDeCarga.Value == 100)
            {
                //Apagado de Reloj
                Reloj.Enabled = false;
                frmSistemaGestion ventana = new frmSistemaGestion();
                ventana.ShowDialog();
                this.Hide();//Oculta la frmPrincipal
            }
            else
            {
                BarraDeCarga.Value += 5;//Incrementa la carga de reloj
            }
        }
    }
}
