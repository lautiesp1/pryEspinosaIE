﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEspinosaIE
{
    public partial class frmCargaProveedores : Form
    {
        //declaraciòn de variables globales
        StreamReader objetoLectorArchivo;
        StreamWriter objetoEscribeArchivo;
        string rutaArchivo;

        string leerLinea;
        string[] separadorTexto;

        public frmCargaProveedores()
        {
            InitializeComponent();
        }

        private void frmCargaProveedores_Load(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";

            objetoLectorArchivo = new StreamReader(rutaArchivo);

            while (!objetoLectorArchivo.EndOfStream)
            {
                leerLinea = objetoLectorArchivo.ReadLine();

                separadorTexto = leerLinea.Split(';');

                //lblDatos.Text+=objetoLectorArchivo.ReadLine();
                dgvDatos.Rows.Add(separadorTexto);
            }

            objetoLectorArchivo.Close();
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";

            objetoEscribeArchivo = new StreamWriter(rutaArchivo, true);

            objetoEscribeArchivo.WriteLine(txtApertura.Text + ";" +
                txtEntidad.Text + ";" + txtExpediente.Text + ";" +
                txtNumero.Text + ";" + txtDireccion.Text + ";" +
                cmbJuzg.Text + ";" + cmbJurisdicción.Text + ";" + cmbLiquidador.Text);

            objetoEscribeArchivo.Close();

            MessageBox.Show("Registro realizado");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDatos.SelectedRows)
            {
                dgvDatos.Rows.Remove(row);
            }
            
            
        }

        private void dgvDatos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lblDatos.Text = "hizo doble clic";

            txtEntidad.Text = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApertura.Text = dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExpediente.Text = dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumero.Text = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbJuzg.Text = dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbJurisdicción.Text = dgvDatos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbLiquidador.Text = dgvDatos.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void txtExpediente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtJuzg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
