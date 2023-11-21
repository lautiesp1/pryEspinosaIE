namespace pryEspinosaIE
{
    partial class frmCarpetaDeProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarpetaDeProveedores));
            this.lblContenido = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblContenido
            // 
            this.lblContenido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblContenido.Location = new System.Drawing.Point(243, 46);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(270, 221);
            this.lblContenido.TabIndex = 8;
            this.lblContenido.Text = "---";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 46);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(174, 221);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick_1);
            // 
            // frmCarpetaDeProveedores
            // 
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarpetaDeProveedores";
            this.Text = "CarpetaDeProveedores";
            this.Load += new System.EventHandler(this.frmCarpetaDeProveedores_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TreeView twCarpetasProvedores;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.TreeView treeView1;
    }
}