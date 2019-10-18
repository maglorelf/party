namespace party
{
    partial class Asistencia
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
            this.QRText = new System.Windows.Forms.TextBox();
            this.CheckQR = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QRText
            // 
            this.QRText.Location = new System.Drawing.Point(57, 80);
            this.QRText.Name = "QRText";
            this.QRText.Size = new System.Drawing.Size(100, 20);
            this.QRText.TabIndex = 0;
            // 
            // CheckQR
            // 
            this.CheckQR.Location = new System.Drawing.Point(163, 77);
            this.CheckQR.Name = "CheckQR";
            this.CheckQR.Size = new System.Drawing.Size(75, 23);
            this.CheckQR.TabIndex = 1;
            this.CheckQR.Text = "Validar";
            this.CheckQR.UseVisualStyleBackColor = true;
            this.CheckQR.Click += new System.EventHandler(this.checkQR_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarFicheroToolStripMenuItem,
            this.descargarAsistenciaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarFicheroToolStripMenuItem
            // 
            this.cargarFicheroToolStripMenuItem.Name = "cargarFicheroToolStripMenuItem";
            this.cargarFicheroToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cargarFicheroToolStripMenuItem.Text = "Cargar Fichero Invitados";
            // 
            // descargarAsistenciaToolStripMenuItem
            // 
            this.descargarAsistenciaToolStripMenuItem.Name = "descargarAsistenciaToolStripMenuItem";
            this.descargarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.descargarAsistenciaToolStripMenuItem.Text = "Descargar Asistencia";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // panelResultado
            // 
            this.panelResultado.Location = new System.Drawing.Point(443, 87);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(239, 255);
            this.panelResultado.TabIndex = 3;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.CheckQR);
            this.Controls.Add(this.QRText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Asistencia";
            this.Text = "Altia Party";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QRText;
        private System.Windows.Forms.Button CheckQR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFicheroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panelResultado;
    }
}

