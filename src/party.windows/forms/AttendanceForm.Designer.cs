namespace party.windows.forms
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            QRText = new System.Windows.Forms.TextBox();
            CheckQR = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cargarFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            descargarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            consultarInvitadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            consultarAsistentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            textosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            barcodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inicializarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Evento = new System.Windows.Forms.Label();
            panelNoExiste = new System.Windows.Forms.Panel();
            QRErrorLabel = new System.Windows.Forms.Label();
            NoExisteInfoLabel = new System.Windows.Forms.Label();
            panelConfirmacionEntrada = new System.Windows.Forms.Panel();
            buttonNoVerificado = new System.Windows.Forms.Button();
            buttonVerificado = new System.Windows.Forms.Button();
            InvitadoDatosLabel = new System.Windows.Forms.Label();
            LecturaCorrectaLabel = new System.Windows.Forms.Label();
            labelAsistenteAceptado = new System.Windows.Forms.Label();
            panelAsistenciaRegistrada = new System.Windows.Forms.Panel();
            AsistenteDatosLabel = new System.Windows.Forms.Label();
            AsistenteYaRegistradoLabel = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            statusDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            statusInvitados = new System.Windows.Forms.ToolStripStatusLabel();
            statusAsistentes = new System.Windows.Forms.ToolStripStatusLabel();
            processBar = new System.Windows.Forms.ToolStripProgressBar();
            eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panelNoExiste.SuspendLayout();
            panelConfirmacionEntrada.SuspendLayout();
            panelAsistenciaRegistrada.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // QRText
            // 
            QRText.Location = new System.Drawing.Point(19, 88);
            QRText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            QRText.Multiline = true;
            QRText.Name = "QRText";
            QRText.Size = new System.Drawing.Size(304, 20);
            QRText.TabIndex = 0;
            // 
            // CheckQR
            // 
            CheckQR.Location = new System.Drawing.Point(248, 116);
            CheckQR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CheckQR.Name = "CheckQR";
            CheckQR.Size = new System.Drawing.Size(75, 28);
            CheckQR.TabIndex = 1;
            CheckQR.Text = "Validar";
            CheckQR.UseVisualStyleBackColor = true;
            CheckQR.Click += CheckQR_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { archivoToolStripMenuItem, configuraciónToolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1374, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cargarFicheroToolStripMenuItem, descargarAsistenciaToolStripMenuItem, consultarInvitadosToolStripMenuItem, consultarAsistentesToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarFicheroToolStripMenuItem
            // 
            cargarFicheroToolStripMenuItem.Name = "cargarFicheroToolStripMenuItem";
            cargarFicheroToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            cargarFicheroToolStripMenuItem.Text = "&Cargar Fichero Invitados";
            cargarFicheroToolStripMenuItem.Click += CargarFicheroToolStripMenuItem_Click;
            // 
            // descargarAsistenciaToolStripMenuItem
            // 
            descargarAsistenciaToolStripMenuItem.Name = "descargarAsistenciaToolStripMenuItem";
            descargarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            descargarAsistenciaToolStripMenuItem.Text = "&Descargar Asistencia";
            descargarAsistenciaToolStripMenuItem.Click += DescargarAsistenciaToolStripMenuItem_Click;
            // 
            // consultarInvitadosToolStripMenuItem
            // 
            consultarInvitadosToolStripMenuItem.Name = "consultarInvitadosToolStripMenuItem";
            consultarInvitadosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            consultarInvitadosToolStripMenuItem.Text = "Consultar &Invitados";
            consultarInvitadosToolStripMenuItem.Click += ConsultarInvitadosToolStripMenuItem_Click;
            // 
            // consultarAsistentesToolStripMenuItem
            // 
            consultarAsistentesToolStripMenuItem.Name = "consultarAsistentesToolStripMenuItem";
            consultarAsistentesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            consultarAsistentesToolStripMenuItem.Text = "Consultar &Asistentes";
            consultarAsistentesToolStripMenuItem.Click += ConsultarAsistentesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            // 
            // configuraciónToolStripMenuItem1
            // 
            configuraciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { textosToolStripMenuItem, eventToolStripMenuItem, barcodesToolStripMenuItem, inicializarTodoToolStripMenuItem });
            configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            configuraciónToolStripMenuItem1.Text = "Configuración";
            // 
            // textosToolStripMenuItem
            // 
            textosToolStripMenuItem.Name = "textosToolStripMenuItem";
            textosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            textosToolStripMenuItem.Text = "Settings";
            textosToolStripMenuItem.Click += TextosToolStripMenuItem_Click;
            // 
            // barcodesToolStripMenuItem
            // 
            barcodesToolStripMenuItem.Name = "barcodesToolStripMenuItem";
            barcodesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            barcodesToolStripMenuItem.Text = "Lectora";
            barcodesToolStripMenuItem.Click += BarcodesToolStripMenuItem_Click;
            // 
            // inicializarTodoToolStripMenuItem
            // 
            inicializarTodoToolStripMenuItem.Name = "inicializarTodoToolStripMenuItem";
            inicializarTodoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            inicializarTodoToolStripMenuItem.Text = "Inicializar base datos";
            inicializarTodoToolStripMenuItem.Click += InicializarTodoToolStripMenuItem_Click;
            // 
            // Evento
            // 
            Evento.AutoSize = true;
            Evento.BackColor = System.Drawing.Color.Transparent;
            Evento.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Evento.ForeColor = System.Drawing.SystemColors.Window;
            Evento.Location = new System.Drawing.Point(13, 34);
            Evento.Name = "Evento";
            Evento.Size = new System.Drawing.Size(0, 29);
            Evento.TabIndex = 4;
            // 
            // panelNoExiste
            // 
            panelNoExiste.BackColor = System.Drawing.Color.DarkRed;
            panelNoExiste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelNoExiste.Controls.Add(QRErrorLabel);
            panelNoExiste.Controls.Add(NoExisteInfoLabel);
            panelNoExiste.ForeColor = System.Drawing.SystemColors.Info;
            panelNoExiste.Location = new System.Drawing.Point(487, 50);
            panelNoExiste.Name = "panelNoExiste";
            panelNoExiste.Size = new System.Drawing.Size(700, 400);
            panelNoExiste.TabIndex = 6;
            panelNoExiste.Visible = false;
            // 
            // QRErrorLabel
            // 
            QRErrorLabel.AutoSize = true;
            QRErrorLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            QRErrorLabel.Location = new System.Drawing.Point(22, 59);
            QRErrorLabel.Name = "QRErrorLabel";
            QRErrorLabel.Size = new System.Drawing.Size(132, 24);
            QRErrorLabel.TabIndex = 4;
            QRErrorLabel.Text = "QR COMPLETO";
            QRErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoExisteInfoLabel
            // 
            NoExisteInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            NoExisteInfoLabel.AutoSize = true;
            NoExisteInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NoExisteInfoLabel.Location = new System.Drawing.Point(30, 17);
            NoExisteInfoLabel.Name = "NoExisteInfoLabel";
            NoExisteInfoLabel.Size = new System.Drawing.Size(490, 29);
            NoExisteInfoLabel.TabIndex = 1;
            NoExisteInfoLabel.Text = "El QR no se reconoce en la lista de invitados";
            // 
            // panelConfirmacionEntrada
            // 
            panelConfirmacionEntrada.BackColor = System.Drawing.Color.OliveDrab;
            panelConfirmacionEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelConfirmacionEntrada.Controls.Add(buttonNoVerificado);
            panelConfirmacionEntrada.Controls.Add(buttonVerificado);
            panelConfirmacionEntrada.Controls.Add(InvitadoDatosLabel);
            panelConfirmacionEntrada.Controls.Add(LecturaCorrectaLabel);
            panelConfirmacionEntrada.Controls.Add(labelAsistenteAceptado);
            panelConfirmacionEntrada.ForeColor = System.Drawing.SystemColors.Info;
            panelConfirmacionEntrada.Location = new System.Drawing.Point(487, 50);
            panelConfirmacionEntrada.Name = "panelConfirmacionEntrada";
            panelConfirmacionEntrada.Size = new System.Drawing.Size(700, 400);
            panelConfirmacionEntrada.TabIndex = 7;
            panelConfirmacionEntrada.Visible = false;
            // 
            // buttonNoVerificado
            // 
            buttonNoVerificado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            buttonNoVerificado.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonNoVerificado.Location = new System.Drawing.Point(170, 345);
            buttonNoVerificado.Name = "buttonNoVerificado";
            buttonNoVerificado.Size = new System.Drawing.Size(209, 39);
            buttonNoVerificado.TabIndex = 6;
            buttonNoVerificado.Text = "Datos incorrectos (N)";
            buttonNoVerificado.UseVisualStyleBackColor = false;
            buttonNoVerificado.Click += ButtonNoVerificado_Click;
            // 
            // buttonVerificado
            // 
            buttonVerificado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            buttonVerificado.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonVerificado.Location = new System.Drawing.Point(15, 345);
            buttonVerificado.Name = "buttonVerificado";
            buttonVerificado.Size = new System.Drawing.Size(139, 39);
            buttonVerificado.TabIndex = 5;
            buttonVerificado.Text = "Verificado (S)";
            buttonVerificado.UseVisualStyleBackColor = false;
            buttonVerificado.Click += ButtonVerificado_Click;
            // 
            // InvitadoDatosLabel
            // 
            InvitadoDatosLabel.AutoSize = true;
            InvitadoDatosLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            InvitadoDatosLabel.Location = new System.Drawing.Point(22, 59);
            InvitadoDatosLabel.Name = "InvitadoDatosLabel";
            InvitadoDatosLabel.Size = new System.Drawing.Size(141, 24);
            InvitadoDatosLabel.TabIndex = 4;
            InvitadoDatosLabel.Text = "Datos asistente";
            InvitadoDatosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LecturaCorrectaLabel
            // 
            LecturaCorrectaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LecturaCorrectaLabel.AutoSize = true;
            LecturaCorrectaLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LecturaCorrectaLabel.Location = new System.Drawing.Point(30, 17);
            LecturaCorrectaLabel.Name = "LecturaCorrectaLabel";
            LecturaCorrectaLabel.Size = new System.Drawing.Size(193, 29);
            LecturaCorrectaLabel.TabIndex = 1;
            LecturaCorrectaLabel.Text = "Lectura correcta";
            // 
            // labelAsistenteAceptado
            // 
            labelAsistenteAceptado.AutoSize = true;
            labelAsistenteAceptado.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAsistenteAceptado.Location = new System.Drawing.Point(13, 352);
            labelAsistenteAceptado.Name = "labelAsistenteAceptado";
            labelAsistenteAceptado.Size = new System.Drawing.Size(173, 24);
            labelAsistenteAceptado.TabIndex = 7;
            labelAsistenteAceptado.Text = "Asistente aceptado";
            labelAsistenteAceptado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAsistenciaRegistrada
            // 
            panelAsistenciaRegistrada.BackColor = System.Drawing.Color.Coral;
            panelAsistenciaRegistrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelAsistenciaRegistrada.Controls.Add(AsistenteDatosLabel);
            panelAsistenciaRegistrada.Controls.Add(AsistenteYaRegistradoLabel);
            panelAsistenciaRegistrada.ForeColor = System.Drawing.SystemColors.Info;
            panelAsistenciaRegistrada.Location = new System.Drawing.Point(487, 50);
            panelAsistenciaRegistrada.Name = "panelAsistenciaRegistrada";
            panelAsistenciaRegistrada.Size = new System.Drawing.Size(700, 400);
            panelAsistenciaRegistrada.TabIndex = 8;
            panelAsistenciaRegistrada.Visible = false;
            // 
            // AsistenteDatosLabel
            // 
            AsistenteDatosLabel.AutoSize = true;
            AsistenteDatosLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AsistenteDatosLabel.Location = new System.Drawing.Point(22, 59);
            AsistenteDatosLabel.Name = "AsistenteDatosLabel";
            AsistenteDatosLabel.Size = new System.Drawing.Size(132, 24);
            AsistenteDatosLabel.TabIndex = 4;
            AsistenteDatosLabel.Text = "QR COMPLETO";
            AsistenteDatosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AsistenteYaRegistradoLabel
            // 
            AsistenteYaRegistradoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            AsistenteYaRegistradoLabel.AutoSize = true;
            AsistenteYaRegistradoLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AsistenteYaRegistradoLabel.Location = new System.Drawing.Point(30, 17);
            AsistenteYaRegistradoLabel.Name = "AsistenteYaRegistradoLabel";
            AsistenteYaRegistradoLabel.Size = new System.Drawing.Size(513, 29);
            AsistenteYaRegistradoLabel.TabIndex = 1;
            AsistenteYaRegistradoLabel.Text = "El asistente ya ha sido registrado previamente";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusDatabase, statusInvitados, statusAsistentes, processBar });
            statusStrip1.Location = new System.Drawing.Point(0, 546);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1374, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusDatabase
            // 
            statusDatabase.AutoSize = false;
            statusDatabase.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            statusDatabase.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            statusDatabase.Name = "statusDatabase";
            statusDatabase.Size = new System.Drawing.Size(350, 17);
            statusDatabase.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // statusInvitados
            // 
            statusInvitados.AutoSize = false;
            statusInvitados.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            statusInvitados.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            statusInvitados.Name = "statusInvitados";
            statusInvitados.Size = new System.Drawing.Size(200, 17);
            statusInvitados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusAsistentes
            // 
            statusAsistentes.AutoSize = false;
            statusAsistentes.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            statusAsistentes.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            statusAsistentes.Name = "statusAsistentes";
            statusAsistentes.Size = new System.Drawing.Size(200, 17);
            statusAsistentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processBar
            // 
            processBar.Name = "processBar";
            processBar.Size = new System.Drawing.Size(200, 16);
            processBar.Step = 1;
            // 
            // eventToolStripMenuItem
            // 
            eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            eventToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            eventToolStripMenuItem.Text = "Event";
            eventToolStripMenuItem.Click += EventToolStripMenuItem_Click;
            // 
            // AttendanceForm
            // 
            AcceptButton = CheckQR;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1374, 568);
            Controls.Add(statusStrip1);
            Controls.Add(Evento);
            Controls.Add(CheckQR);
            Controls.Add(QRText);
            Controls.Add(menuStrip1);
            Controls.Add(panelConfirmacionEntrada);
            Controls.Add(panelNoExiste);
            Controls.Add(panelAsistenciaRegistrada);
            Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AttendanceForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Party";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += AttendanceForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelNoExiste.ResumeLayout(false);
            panelNoExiste.PerformLayout();
            panelConfirmacionEntrada.ResumeLayout(false);
            panelConfirmacionEntrada.PerformLayout();
            panelAsistenciaRegistrada.ResumeLayout(false);
            panelAsistenciaRegistrada.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
    }
}

