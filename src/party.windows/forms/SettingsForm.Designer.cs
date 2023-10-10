namespace party.windows.forms
{
    partial class SettingsForm
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
            panelInferior = new System.Windows.Forms.Panel();
            buttonGuardar = new System.Windows.Forms.Button();
            buttonSalir = new System.Windows.Forms.Button();
            CabeceraPanel = new System.Windows.Forms.Panel();
            InstruccionesLabel = new System.Windows.Forms.Label();
            EventoLabel = new System.Windows.Forms.Label();
            databaseLabel = new System.Windows.Forms.Label();
            DatabaseText = new System.Windows.Forms.TextBox();
            EventoText = new System.Windows.Forms.TextBox();
            SeparadorCSVText = new System.Windows.Forms.TextBox();
            SeparadorLabel = new System.Windows.Forms.Label();
            BackgroundText = new System.Windows.Forms.TextBox();
            BackgroundLabel = new System.Windows.Forms.Label();
            selectBackgroundButton = new System.Windows.Forms.Button();
            PathText = new System.Windows.Forms.TextBox();
            PathLabel = new System.Windows.Forms.Label();
            selectEventPathButton = new System.Windows.Forms.Button();
            routeLabel = new System.Windows.Forms.Label();
            RouteCombo = new System.Windows.Forms.ComboBox();
            panelInferior.SuspendLayout();
            CabeceraPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(buttonGuardar);
            panelInferior.Controls.Add(buttonSalir);
            panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelInferior.Location = new System.Drawing.Point(0, 458);
            panelInferior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new System.Drawing.Size(933, 61);
            panelInferior.TabIndex = 4;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            buttonGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonGuardar.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonGuardar.Location = new System.Drawing.Point(14, 8);
            buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new System.Drawing.Size(162, 45);
            buttonGuardar.TabIndex = 7;
            buttonGuardar.Text = "&Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += ButtonGuardar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonSalir.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonSalir.Location = new System.Drawing.Point(183, 8);
            buttonSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new System.Drawing.Size(162, 45);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "&Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            // 
            // CabeceraPanel
            // 
            CabeceraPanel.Controls.Add(InstruccionesLabel);
            CabeceraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            CabeceraPanel.Location = new System.Drawing.Point(0, 0);
            CabeceraPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CabeceraPanel.Name = "CabeceraPanel";
            CabeceraPanel.Size = new System.Drawing.Size(933, 46);
            CabeceraPanel.TabIndex = 5;
            // 
            // InstruccionesLabel
            // 
            InstruccionesLabel.AutoSize = true;
            InstruccionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            InstruccionesLabel.Location = new System.Drawing.Point(4, 10);
            InstruccionesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            InstruccionesLabel.Name = "InstruccionesLabel";
            InstruccionesLabel.Size = new System.Drawing.Size(155, 16);
            InstruccionesLabel.TabIndex = 1;
            InstruccionesLabel.Text = "Configuración del evento";
            // 
            // EventoLabel
            // 
            EventoLabel.AutoSize = true;
            EventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EventoLabel.Location = new System.Drawing.Point(17, 63);
            EventoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            EventoLabel.Name = "EventoLabel";
            EventoLabel.Size = new System.Drawing.Size(49, 16);
            EventoLabel.TabIndex = 7;
            EventoLabel.Text = "Evento";
            // 
            // databaseLabel
            // 
            databaseLabel.AutoSize = true;
            databaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            databaseLabel.Location = new System.Drawing.Point(17, 140);
            databaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            databaseLabel.Name = "databaseLabel";
            databaseLabel.Size = new System.Drawing.Size(130, 16);
            databaseLabel.TabIndex = 8;
            databaseLabel.Text = "Nombre Base Datos";
            // 
            // DatabaseText
            // 
            DatabaseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DatabaseText.Location = new System.Drawing.Point(206, 137);
            DatabaseText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DatabaseText.Name = "DatabaseText";
            DatabaseText.Size = new System.Drawing.Size(528, 22);
            DatabaseText.TabIndex = 10;
            // 
            // EventoText
            // 
            EventoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EventoText.Location = new System.Drawing.Point(206, 60);
            EventoText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EventoText.Name = "EventoText";
            EventoText.ReadOnly = true;
            EventoText.Size = new System.Drawing.Size(528, 22);
            EventoText.TabIndex = 11;
            // 
            // SeparadorCSVText
            // 
            SeparadorCSVText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SeparadorCSVText.Location = new System.Drawing.Point(206, 175);
            SeparadorCSVText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SeparadorCSVText.Name = "SeparadorCSVText";
            SeparadorCSVText.Size = new System.Drawing.Size(528, 22);
            SeparadorCSVText.TabIndex = 13;
            // 
            // SeparadorLabel
            // 
            SeparadorLabel.AutoSize = true;
            SeparadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SeparadorLabel.Location = new System.Drawing.Point(17, 178);
            SeparadorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SeparadorLabel.Name = "SeparadorLabel";
            SeparadorLabel.Size = new System.Drawing.Size(102, 16);
            SeparadorLabel.TabIndex = 12;
            SeparadorLabel.Text = "Separador CSV";
            // 
            // BackgroundText
            // 
            BackgroundText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BackgroundText.Location = new System.Drawing.Point(206, 213);
            BackgroundText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BackgroundText.Name = "BackgroundText";
            BackgroundText.Size = new System.Drawing.Size(528, 22);
            BackgroundText.TabIndex = 15;
            // 
            // BackgroundLabel
            // 
            BackgroundLabel.AutoSize = true;
            BackgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BackgroundLabel.Location = new System.Drawing.Point(17, 216);
            BackgroundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BackgroundLabel.Name = "BackgroundLabel";
            BackgroundLabel.Size = new System.Drawing.Size(94, 16);
            BackgroundLabel.TabIndex = 14;
            BackgroundLabel.Text = "Imagen Fondo";
            // 
            // selectBackgroundButton
            // 
            selectBackgroundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            selectBackgroundButton.Location = new System.Drawing.Point(735, 208);
            selectBackgroundButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            selectBackgroundButton.Name = "selectBackgroundButton";
            selectBackgroundButton.Size = new System.Drawing.Size(28, 27);
            selectBackgroundButton.TabIndex = 16;
            selectBackgroundButton.Text = "...";
            selectBackgroundButton.UseVisualStyleBackColor = true;
            selectBackgroundButton.Click += SelectBackgroundButton_Click;
            // 
            // PathText
            // 
            PathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PathText.Location = new System.Drawing.Point(206, 251);
            PathText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PathText.Name = "PathText";
            PathText.Size = new System.Drawing.Size(526, 22);
            PathText.TabIndex = 19;
            // 
            // PathLabel
            // 
            PathLabel.AutoSize = true;
            PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PathLabel.Location = new System.Drawing.Point(17, 254);
            PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PathLabel.Name = "PathLabel";
            PathLabel.Size = new System.Drawing.Size(34, 16);
            PathLabel.TabIndex = 18;
            PathLabel.Text = "Path";
            // 
            // selectEventPathButton
            // 
            selectEventPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            selectEventPathButton.Location = new System.Drawing.Point(735, 249);
            selectEventPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            selectEventPathButton.Name = "selectEventPathButton";
            selectEventPathButton.Size = new System.Drawing.Size(28, 27);
            selectEventPathButton.TabIndex = 20;
            selectEventPathButton.Text = "...";
            selectEventPathButton.UseVisualStyleBackColor = true;
            selectEventPathButton.Click += SelectEventPathButton_Click;
            // 
            // routeLabel
            // 
            routeLabel.AutoSize = true;
            routeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            routeLabel.Location = new System.Drawing.Point(17, 100);
            routeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            routeLabel.Name = "routeLabel";
            routeLabel.Size = new System.Drawing.Size(82, 16);
            routeLabel.TabIndex = 21;
            routeLabel.Text = "Localización";
            // 
            // RouteCombo
            // 
            RouteCombo.Enabled = false;
            RouteCombo.FormattingEnabled = true;
            RouteCombo.Location = new System.Drawing.Point(206, 98);
            RouteCombo.Name = "RouteCombo";
            RouteCombo.Size = new System.Drawing.Size(526, 23);
            RouteCombo.TabIndex = 22;
            // 
            // SettingsForm
            // 
            AcceptButton = buttonGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonSalir;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(RouteCombo);
            Controls.Add(routeLabel);
            Controls.Add(selectEventPathButton);
            Controls.Add(PathText);
            Controls.Add(PathLabel);
            Controls.Add(selectBackgroundButton);
            Controls.Add(BackgroundText);
            Controls.Add(BackgroundLabel);
            Controls.Add(SeparadorCSVText);
            Controls.Add(SeparadorLabel);
            Controls.Add(EventoText);
            Controls.Add(DatabaseText);
            Controls.Add(databaseLabel);
            Controls.Add(EventoLabel);
            Controls.Add(CabeceraPanel);
            Controls.Add(panelInferior);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Configuración de evento";
            FormClosing += SettingsForm_FormClosing;
            panelInferior.ResumeLayout(false);
            CabeceraPanel.ResumeLayout(false);
            CabeceraPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Panel CabeceraPanel;
        private System.Windows.Forms.Label InstruccionesLabel;
        private System.Windows.Forms.Label EventoLabel;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.TextBox DatabaseText;
        private System.Windows.Forms.TextBox EventoText;
        private System.Windows.Forms.TextBox SeparadorCSVText;
        private System.Windows.Forms.Label SeparadorLabel;
        private System.Windows.Forms.TextBox BackgroundText;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Button selectBackgroundButton;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button selectEventPathButton;
        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.ComboBox RouteCombo;
    }
}
