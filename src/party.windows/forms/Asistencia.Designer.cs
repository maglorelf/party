namespace party.windows.forms
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
            this.consultarInvitadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAsistentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelAsistenteAceptado = new System.Windows.Forms.Label();
            this.panelAsistenciaRegistrada = new System.Windows.Forms.Panel();
            this.AsistenteDatosLabel = new System.Windows.Forms.Label();
            this.AsistenteYaRegistradoLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusInvitados = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAsistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.processBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.panelNoExiste.SuspendLayout();
            this.panelConfirmacionEntrada.SuspendLayout();
            this.panelAsistenciaRegistrada.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.CheckQR.Click += new System.EventHandler(this.CheckQR_Click);
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
            this.salirToolStripMenuItem,
            this.consultarInvitadosToolStripMenuItem,
            this.consultarAsistentesToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarFicheroToolStripMenuItem
            // 
            this.cargarFicheroToolStripMenuItem.Name = "cargarFicheroToolStripMenuItem";
            this.cargarFicheroToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cargarFicheroToolStripMenuItem.Text = "&Cargar Fichero Invitados";
            this.cargarFicheroToolStripMenuItem.Click += new System.EventHandler(this.CargarFicheroToolStripMenuItem_Click);
            // 
            // descargarAsistenciaToolStripMenuItem
            // 
            this.descargarAsistenciaToolStripMenuItem.Name = "descargarAsistenciaToolStripMenuItem";
            this.descargarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.descargarAsistenciaToolStripMenuItem.Text = "&Descargar Asistencia";
            this.descargarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.DescargarAsistenciaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // consultarInvitadosToolStripMenuItem
            // 
            this.consultarInvitadosToolStripMenuItem.Name = "consultarInvitadosToolStripMenuItem";
            this.consultarInvitadosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consultarInvitadosToolStripMenuItem.Text = "Consultar &Invitados";
            this.consultarInvitadosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarInvitadosToolStripMenuItem_Click);
            // 
            // consultarAsistentesToolStripMenuItem
            // 
            this.consultarAsistentesToolStripMenuItem.Name = "consultarAsistentesToolStripMenuItem";
            this.consultarAsistentesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consultarAsistentesToolStripMenuItem.Text = "Consultar &Asistentes";
            this.consultarAsistentesToolStripMenuItem.Click += new System.EventHandler(this.ConsultarAsistentesToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem1
            // 
            this.configuraciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barcodesToolStripMenuItem,
            this.textosToolStripMenuItem,
            this.inicializarTodoToolStripMenuItem});
            this.configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            this.configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem1.Text = "Configuración";
            // 
            // barcodesToolStripMenuItem
            // 
            this.barcodesToolStripMenuItem.Name = "barcodesToolStripMenuItem";
            this.barcodesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.barcodesToolStripMenuItem.Text = "Lectora";
            this.barcodesToolStripMenuItem.Click += new System.EventHandler(this.BarcodesToolStripMenuItem_Click);
            // 
            // textosToolStripMenuItem
            // 
            this.textosToolStripMenuItem.Name = "textosToolStripMenuItem";
            this.textosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.textosToolStripMenuItem.Text = "Evento";
            this.textosToolStripMenuItem.Click += new System.EventHandler(this.TextosToolStripMenuItem_Click);
            // 
            // inicializarTodoToolStripMenuItem
            // 
            this.inicializarTodoToolStripMenuItem.Name = "inicializarTodoToolStripMenuItem";
            this.inicializarTodoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.inicializarTodoToolStripMenuItem.Text = "Inicializar base datos";
            this.inicializarTodoToolStripMenuItem.Click += new System.EventHandler(this.InicializarTodoToolStripMenuItem_Click);
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
            this.QRErrorLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.QRErrorLabel.Location = new System.Drawing.Point(22, 59);
            this.QRErrorLabel.Name = "QRErrorLabel";
            this.QRErrorLabel.Size = new System.Drawing.Size(132, 24);
            this.QRErrorLabel.TabIndex = 4;
            this.QRErrorLabel.Text = "QR COMPLETO";
            this.QRErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoExisteInfoLabel
            // 
            this.NoExisteInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoExisteInfoLabel.AutoSize = true;
            this.NoExisteInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.NoExisteInfoLabel.Location = new System.Drawing.Point(30, 17);
            this.NoExisteInfoLabel.Name = "NoExisteInfoLabel";
            this.NoExisteInfoLabel.Size = new System.Drawing.Size(490, 29);
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
            this.panelConfirmacionEntrada.Controls.Add(this.labelAsistenteAceptado);
            this.panelConfirmacionEntrada.ForeColor = System.Drawing.SystemColors.Info;
            this.panelConfirmacionEntrada.Location = new System.Drawing.Point(487, 50);
            this.panelConfirmacionEntrada.Name = "panelConfirmacionEntrada";
            this.panelConfirmacionEntrada.Size = new System.Drawing.Size(700, 400);
            this.panelConfirmacionEntrada.TabIndex = 7;
            // 
            // buttonNoVerificado
            // 
            this.buttonNoVerificado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonNoVerificado.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.buttonNoVerificado.Location = new System.Drawing.Point(170, 345);
            this.buttonNoVerificado.Name = "buttonNoVerificado";
            this.buttonNoVerificado.Size = new System.Drawing.Size(209, 39);
            this.buttonNoVerificado.TabIndex = 6;
            this.buttonNoVerificado.Text = "Datos incorrectos (N)";
            this.buttonNoVerificado.UseVisualStyleBackColor = false;
            this.buttonNoVerificado.Click += new System.EventHandler(this.ButtonNoVerificado_Click);
            // 
            // buttonVerificado
            // 
            this.buttonVerificado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonVerificado.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.buttonVerificado.Location = new System.Drawing.Point(15, 345);
            this.buttonVerificado.Name = "buttonVerificado";
            this.buttonVerificado.Size = new System.Drawing.Size(139, 39);
            this.buttonVerificado.TabIndex = 5;
            this.buttonVerificado.Text = "Verificado (S)";
            this.buttonVerificado.UseVisualStyleBackColor = false;
            this.buttonVerificado.Click += new System.EventHandler(this.ButtonVerificado_Click);
            // 
            // InvitadoDatosLabel
            // 
            this.InvitadoDatosLabel.AutoSize = true;
            this.InvitadoDatosLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.InvitadoDatosLabel.Location = new System.Drawing.Point(22, 59);
            this.InvitadoDatosLabel.Name = "InvitadoDatosLabel";
            this.InvitadoDatosLabel.Size = new System.Drawing.Size(141, 24);
            this.InvitadoDatosLabel.TabIndex = 4;
            this.InvitadoDatosLabel.Text = "Datos asistente";
            this.InvitadoDatosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LecturaCorrectaLabel
            // 
            this.LecturaCorrectaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LecturaCorrectaLabel.AutoSize = true;
            this.LecturaCorrectaLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.LecturaCorrectaLabel.Location = new System.Drawing.Point(30, 17);
            this.LecturaCorrectaLabel.Name = "LecturaCorrectaLabel";
            this.LecturaCorrectaLabel.Size = new System.Drawing.Size(193, 29);
            this.LecturaCorrectaLabel.TabIndex = 1;
            this.LecturaCorrectaLabel.Text = "Lectura correcta";
            // 
            // labelAsistenteAceptado
            // 
            this.labelAsistenteAceptado.AutoSize = true;
            this.labelAsistenteAceptado.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.labelAsistenteAceptado.Location = new System.Drawing.Point(13, 352);
            this.labelAsistenteAceptado.Name = "labelAsistenteAceptado";
            this.labelAsistenteAceptado.Size = new System.Drawing.Size(173, 24);
            this.labelAsistenteAceptado.TabIndex = 7;
            this.labelAsistenteAceptado.Text = "Asistente aceptado";
            this.labelAsistenteAceptado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.AsistenteDatosLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.AsistenteDatosLabel.Location = new System.Drawing.Point(22, 59);
            this.AsistenteDatosLabel.Name = "AsistenteDatosLabel";
            this.AsistenteDatosLabel.Size = new System.Drawing.Size(132, 24);
            this.AsistenteDatosLabel.TabIndex = 4;
            this.AsistenteDatosLabel.Text = "QR COMPLETO";
            this.AsistenteDatosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AsistenteYaRegistradoLabel
            // 
            this.AsistenteYaRegistradoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsistenteYaRegistradoLabel.AutoSize = true;
            this.AsistenteYaRegistradoLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.AsistenteYaRegistradoLabel.Location = new System.Drawing.Point(30, 17);
            this.AsistenteYaRegistradoLabel.Name = "AsistenteYaRegistradoLabel";
            this.AsistenteYaRegistradoLabel.Size = new System.Drawing.Size(513, 29);
            this.AsistenteYaRegistradoLabel.TabIndex = 1;
            this.AsistenteYaRegistradoLabel.Text = "El asistente ya ha sido registrado previamente";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDatabase,
            this.statusInvitados,
            this.statusAsistentes,
            this.processBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1374, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusDatabase
            // 
            this.statusDatabase.AutoSize = false;
            this.statusDatabase.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusDatabase.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.statusDatabase.Name = "statusDatabase";
            this.statusDatabase.Size = new System.Drawing.Size(350, 17);
            this.statusDatabase.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // statusInvitados
            // 
            this.statusInvitados.AutoSize = false;
            this.statusInvitados.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusInvitados.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.statusInvitados.Name = "statusInvitados";
            this.statusInvitados.Size = new System.Drawing.Size(200, 17);
            this.statusInvitados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusAsistentes
            // 
            this.statusAsistentes.AutoSize = false;
            this.statusAsistentes.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusAsistentes.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.statusAsistentes.Name = "statusAsistentes";
            this.statusAsistentes.Size = new System.Drawing.Size(200, 17);
            this.statusAsistentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processBar
            // 
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(200, 16);
            this.processBar.Step = 1;
            // 
            // Asistencia
            // 
            this.AcceptButton = this.CheckQR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 568);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Evento);
            this.Controls.Add(this.CheckQR);
            this.Controls.Add(this.QRText);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelConfirmacionEntrada);
            this.Controls.Add(this.panelNoExiste);
            this.Controls.Add(this.panelAsistenciaRegistrada);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem barcodesToolStripMenuItem;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusDatabase;
        private System.Windows.Forms.ToolStripStatusLabel statusInvitados;
        private System.Windows.Forms.ToolStripStatusLabel statusAsistentes;
        private System.Windows.Forms.ToolStripProgressBar processBar;
        private System.Windows.Forms.Label labelAsistenteAceptado;
        private System.Windows.Forms.ToolStripMenuItem consultarInvitadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAsistentesToolStripMenuItem;
    }
}

