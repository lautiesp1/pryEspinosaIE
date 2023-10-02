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
                txtNumero.Text + ";" + txtDireccion + ";" +
                txtJuzg + ";" + txtJurisdiccion + ";" + txtLiquidador);

            objetoEscribeArchivo.Close();

            MessageBox.Show("Registro realizado");
        }
    }
}
