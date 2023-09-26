namespace pryEspinosaIE
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.BarraDeCarga = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Reloj
            // 
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // BarraDeCarga
            // 
            this.BarraDeCarga.Location = new System.Drawing.Point(179, 394);
            this.BarraDeCarga.Name = "BarraDeCarga";
            this.BarraDeCarga.Size = new System.Drawing.Size(275, 23);
            this.BarraDeCarga.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEspinosaIE.Properties.Resources.logo_seguros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 469);
            this.Controls.Add(this.BarraDeCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.ProgressBar BarraDeCarga;
    }
}

