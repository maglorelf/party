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
            this.Evento = new System.Windows.Forms.Label();
            this.panelNoExiste = new System.Windows.Forms.Panel();
            this.QRErrorLabel = new System.Windows.Forms.Label();
            this.NoExisteInfoLabel = new System.Windows.Forms.Label();
            this.panelConfirmacionEntrada = new System.Windows.Forms.Panel();
            this.buttonNoVerificado = new System.Windows.Forms.Button();
            this.buttonVerificado = new System.Windows.Forms.Button();
            this.InvitadoDatosLabel = new System.Windows.Forms.Label();
            this.LecturaCorrectaLabel = new System.Windows.Forms.Label();
            this.panelAsistenciaRegistrada = new System.Windows.Forms.Panel();
            this.AsistenteDatosLabel = new System.Windows.Forms.Label();
            this.AsistenteYaRegistradoLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelNoExiste.SuspendLayout();
            this.panelConfirmacionEntrada.SuspendLayout();
            this.panelAsistenciaRegistrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // QRText
            // 
            this.QRText.Location = new System.Drawing.Point(19, 88);
            this.QRText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QRText.Multiline = true;
            this.QRText.Name = "QRText";
            this.QRText.Size = new System.Drawing.Size(304, 20);
            this.QRText.TabIndex = 0;
            // 
            // CheckQR
            // 
            this.CheckQR.Location = new System.Drawing.Point(248, 116);
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
            this.menuStrip1.Size = new System.Drawing.Size(1374, 24);
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
            // panelNoExiste
            // 
            this.panelNoExiste.BackColor = System.Drawing.Color.DarkRed;
            this.panelNoExiste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNoExiste.Controls.Add(this.QRErrorLabel);
            this.panelNoExiste.Controls.Add(this.NoExisteInfoLabel);
            this.panelNoExiste.ForeColor = System.Drawing.SystemColors.Info;
            this.panelNoExiste.Location = new System.Drawing.Point(487, 50);
            this.panelNoExiste.Name = "panelNoExiste";
            this.panelNoExiste.Size = new System.Drawing.Size(700, 400);
            this.panelNoExiste.TabIndex = 6;
            // 
            // QRErrorLabel
            // 
            this.QRErrorLabel.AutoSize = true;
            this.QRErrorLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRErrorLabel.Location = new System.Drawing.Point(22, 59);
            this.QRErrorLabel.Name = "QRErrorLabel";
            this.QRErrorLabel.Size = new System.Drawing.Size(93, 18);
            this.QRErrorLabel.TabIndex = 4;
            this.QRErrorLabel.Text = "QR COMPLETO";
            this.QRErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoExisteInfoLabel
            // 
            this.NoExisteInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoExisteInfoLabel.AutoSize = true;
            this.NoExisteInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoExisteInfoLabel.Location = new System.Drawing.Point(30, 17);
            this.NoExisteInfoLabel.Name = "NoExisteInfoLabel";
            this.NoExisteInfoLabel.Size = new System.Drawing.Size(387, 24);
            this.NoExisteInfoLabel.TabIndex = 1;
            this.NoExisteInfoLabel.Text = "El QR no se reconoce en la lista de invitados";
            // 
            // panelConfirmacionEntrada
            // 
            this.panelConfirmacionEntrada.BackColor = System.Drawing.Color.OliveDrab;
            this.panelConfirmacionEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfirmacionEntrada.Controls.Add(this.buttonNoVerificado);
            this.panelConfirmacionEntrada.Controls.Add(this.buttonVerificado);
            this.panelConfirmacionEntrada.Controls.Add(this.InvitadoDatosLabel);
            this.panelConfirmacionEntrada.Controls.Add(this.LecturaCorrectaLabel);
            this.panelConfirmacionEntrada.ForeColor = System.Drawing.SystemColors.Info;
            this.panelConfirmacionEntrada.Location = new System.Drawing.Point(487, 50);
            this.panelConfirmacionEntrada.Name = "panelConfirmacionEntrada";
            this.panelConfirmacionEntrada.Size = new System.Drawing.Size(700, 400);
            this.panelConfirmacionEntrada.TabIndex = 7;
            // 
            // buttonNoVerificado
            // 
            this.buttonNoVerificado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonNoVerificado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNoVerificado.Location = new System.Drawing.Point(137, 230);
            this.buttonNoVerificado.Name = "buttonNoVerificado";
            this.buttonNoVerificado.Size = new System.Drawing.Size(152, 39);
            this.buttonNoVerificado.TabIndex = 6;
            this.buttonNoVerificado.Text = "Datos incorrectos";
            this.buttonNoVerificado.UseVisualStyleBackColor = false;
            this.buttonNoVerificado.Click += new System.EventHandler(this.buttonNoVerificado_Click);
            // 
            // buttonVerificado
            // 
            this.buttonVerificado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonVerificado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerificado.Location = new System.Drawing.Point(25, 230);
            this.buttonVerificado.Name = "buttonVerificado";
            this.buttonVerificado.Size = new System.Drawing.Size(106, 39);
            this.buttonVerificado.TabIndex = 5;
            this.buttonVerificado.Text = "Verificado";
            this.buttonVerificado.UseVisualStyleBackColor = false;
            this.buttonVerificado.Click += new System.EventHandler(this.buttonVerificado_Click);
            // 
            // InvitadoDatosLabel
            // 
            this.InvitadoDatosLabel.AutoSize = true;
            this.InvitadoDatosLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvitadoDatosLabel.Location = new System.Drawing.Point(22, 59);
            this.InvitadoDatosLabel.Name = "InvitadoDatosLabel";
            this.InvitadoDatosLabel.Size = new System.Drawing.Size(99, 18);
            this.InvitadoDatosLabel.TabIndex = 4;
            this.InvitadoDatosLabel.Text = "Datos asistente";
            this.InvitadoDatosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LecturaCorrectaLabel
            // 
            this.LecturaCorrectaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LecturaCorrectaLabel.AutoSize = true;
            this.LecturaCorrectaLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturaCorrectaLabel.Location = new System.Drawing.Point(30, 17);
            this.LecturaCorrectaLabel.Name = "LecturaCorrectaLabel";
            this.LecturaCorrectaLabel.Size = new System.Drawing.Size(150, 24);
            this.LecturaCorrectaLabel.TabIndex = 1;
            this.LecturaCorrectaLabel.Text = "Lectura correcta";
            // 
            // panelAsistenciaRegistrada
            // 
            this.panelAsistenciaRegistrada.BackColor = System.Drawing.Color.Coral;
            this.panelAsistenciaRegistrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAsistenciaRegistrada.Controls.Add(this.AsistenteDatosLabel);
            this.panelAsistenciaRegistrada.Controls.Add(this.AsistenteYaRegistradoLabel);
            this.panelAsistenciaRegistrada.ForeColor = System.Drawing.SystemColors.Info;
            this.panelAsistenciaRegistrada.Location = new System.Drawing.Point(487, 50);
            this.panelAsistenciaRegistrada.Name = "panelAsistenciaRegistrada";
            this.panelAsistenciaRegistrada.Size = new System.Drawing.Size(700, 400);
            this.panelAsistenciaRegistrada.TabIndex = 8;
            // 
            // AsistenteDatosLabel
            // 
            this.AsistenteDatosLabel.AutoSize = true;
            this.AsistenteDatosLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsistenteDatosLabel.Location = new System.Drawing.Point(22, 59);
            this.AsistenteDatosLabel.Name = "AsistenteDatosLabel";
            this.AsistenteDatosLabel.Size = new System.Drawing.Size(93, 18);
            this.AsistenteDatosLabel.TabIndex = 4;
            this.AsistenteDatosLabel.Text = "QR COMPLETO";
            this.AsistenteDatosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AsistenteYaRegistradoLabel
            // 
            this.AsistenteYaRegistradoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsistenteYaRegistradoLabel.AutoSize = true;
            this.AsistenteYaRegistradoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsistenteYaRegistradoLabel.Location = new System.Drawing.Point(30, 17);
            this.AsistenteYaRegistradoLabel.Name = "AsistenteYaRegistradoLabel";
            this.AsistenteYaRegistradoLabel.Size = new System.Drawing.Size(404, 24);
            this.AsistenteYaRegistradoLabel.TabIndex = 1;
            this.AsistenteYaRegistradoLabel.Text = "El asistente ya ha sido registrado previamente";
            // 
            // Asistencia
            // 
            this.AcceptButton = this.CheckQR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 568);
            this.Controls.Add(this.panelAsistenciaRegistrada);
            this.Controls.Add(this.panelConfirmacionEntrada);
            this.Controls.Add(this.panelNoExiste);
            this.Controls.Add(this.Evento);
            this.Controls.Add(this.CheckQR);
            this.Controls.Add(this.QRText);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelNoExiste.ResumeLayout(false);
            this.panelNoExiste.PerformLayout();
            this.panelConfirmacionEntrada.ResumeLayout(false);
            this.panelConfirmacionEntrada.PerformLayout();
            this.panelAsistenciaRegistrada.ResumeLayout(false);
            this.panelAsistenciaRegistrada.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicializarTodoToolStripMenuItem;
        private System.Windows.Forms.Label Evento;
        private System.Windows.Forms.Panel panelNoExiste;
        private System.Windows.Forms.Label NoExisteInfoLabel;
        private System.Windows.Forms.Label QRErrorLabel;
        private System.Windows.Forms.Panel panelConfirmacionEntrada;
        private System.Windows.Forms.Button buttonNoVerificado;
        private System.Windows.Forms.Button buttonVerificado;
        private System.Windows.Forms.Label InvitadoDatosLabel;
        private System.Windows.Forms.Label LecturaCorrectaLabel;
        private System.Windows.Forms.Panel panelAsistenciaRegistrada;
        private System.Windows.Forms.Label AsistenteDatosLabel;
        private System.Windows.Forms.Label AsistenteYaRegistradoLabel;
    }
}

