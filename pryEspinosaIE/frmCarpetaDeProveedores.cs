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
using System.Xml.Linq;

namespace pryEspinosaIE
{
    public partial class frmCarpetaDeProveedores : Form
    {
        public frmCarpetaDeProveedores()
        {
            InitializeComponent();
        }


        private void CargarTreeView(string rutaCarpetaRaiz, string nombreCarpeta)
        {
            treeView1.Nodes.Clear();

            if (Directory.Exists(rutaCarpetaRaiz))
            {
                TreeNode NodoRaiz = new TreeNode("Proveedores");
                treeView1.Nodes.Add(NodoRaiz);
                TraerSubCarpetas(rutaCarpetaRaiz, NodoRaiz);
                TraerArchivos(rutaCarpetaRaiz, NodoRaiz);
            }
        }

        private void TraerSubCarpetas(string ruta, TreeNode nodoRaiz)
        {
            try
            {
                string[] subCarpetas = Directory.GetDirectories(ruta);

                foreach (string subDirectorio in subCarpetas)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(subDirectorio));
                    nodoRaiz.Nodes.Add(node);

                    //recursiva- se llama a si mismo para ver si hay màs carpetas
                    //buscar sub carpetas
                    TraerSubCarpetas(subDirectorio, node);
                    TraerArchivos(subDirectorio, node);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void TraerArchivos(string ruta, TreeNode nodoRaiz)
        {
            string[] archivos = Directory.GetFiles(ruta);

            foreach (string archivo in archivos)
            {
                TreeNode nodoArchivo = new TreeNode(Path.GetFileName(archivo));
                nodoRaiz.Nodes.Add(nodoArchivo);
            }

        }

        private void treeView1_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            //MessageBox.Show(e.Node.Text);

            lblContenido.Text = "";

            try
            {
                DirectoryInfo info = new DirectoryInfo(@"../..");

                string rutaArchivo = info.FullName + "\\" + e.Node.FullPath;

                StreamReader lectorArchivos = new StreamReader(rutaArchivo);

                if (lectorArchivos != null)
                {
                    while (!lectorArchivos.EndOfStream)
                    {
                        lblContenido.Text += lectorArchivos.ReadLine();
                    }
                }

                lectorArchivos.Close();
            }
            catch (Exception)
            {

            }
        }

        private void frmCarpetaDeProveedores_Load_1(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"../../");

            string ruta = info.FullName + "Proveedores";

            CargarTreeView(ruta, info.Name);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
