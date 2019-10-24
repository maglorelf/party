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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            this.QRText = new System.Windows.Forms.TextBox();
            this.CheckQR = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicializarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.Evento = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QRText
            // 
            this.QRText.Location = new System.Drawing.Point(37, 298);
            this.QRText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QRText.Name = "QRText";
            this.QRText.Size = new System.Drawing.Size(304, 20);
            this.QRText.TabIndex = 0;
            // 
            // CheckQR
            // 
            this.CheckQR.Location = new System.Drawing.Point(347, 298);
            this.CheckQR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckQR.Name = "CheckQR";
            this.CheckQR.Size = new System.Drawing.Size(75, 28);
            this.CheckQR.TabIndex = 1;
            this.CheckQR.Text = "Validar";
            this.CheckQR.UseVisualStyleBackColor = true;
            this.CheckQR.Click += new System.EventHandler(this.checkQR_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem1});
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
            this.cargarFicheroToolStripMenuItem.Click += new System.EventHandler(this.cargarFicheroToolStripMenuItem_Click);
            // 
            // descargarAsistenciaToolStripMenuItem
            // 
            this.descargarAsistenciaToolStripMenuItem.Name = "descargarAsistenciaToolStripMenuItem";
            this.descargarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.descargarAsistenciaToolStripMenuItem.Text = "Descargar Asistencia";
            this.descargarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.descargarAsistenciaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem1
            // 
            this.configuraciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem,
            this.textosToolStripMenuItem,
            this.inicializarTodoToolStripMenuItem});
            this.configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            this.configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem1.Text = "Configuración";
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // textosToolStripMenuItem
            // 
            this.textosToolStripMenuItem.Name = "textosToolStripMenuItem";
            this.textosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.textosToolStripMenuItem.Text = "Textos";
            // 
            // inicializarTodoToolStripMenuItem
            // 
            this.inicializarTodoToolStripMenuItem.Name = "inicializarTodoToolStripMenuItem";
            this.inicializarTodoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.inicializarTodoToolStripMenuItem.Text = "Inicializar";
            this.inicializarTodoToolStripMenuItem.Click += new System.EventHandler(this.inicializarTodoToolStripMenuItem_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.Location = new System.Drawing.Point(443, 107);
            this.panelResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(239, 314);
            this.panelResultado.TabIndex = 3;
            // 
            // Evento
            // 
            this.Evento.AutoSize = true;
            this.Evento.BackColor = System.Drawing.Color.Transparent;
            this.Evento.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evento.ForeColor = System.Drawing.SystemColors.Window;
            this.Evento.Location = new System.Drawing.Point(13, 34);
            this.Evento.Name = "Evento";
            this.Evento.Size = new System.Drawing.Size(0, 29);
            this.Evento.TabIndex = 4;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.Evento);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.CheckQR);
            this.Controls.Add(this.QRText);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicializarTodoToolStripMenuItem;
        private System.Windows.Forms.Label Evento;
    }
}

