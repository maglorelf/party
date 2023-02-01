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
            this.panelInferior = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.CabeceraPanel = new System.Windows.Forms.Panel();
            this.InstruccionesLabel = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.EventoLabel = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.TituloText = new System.Windows.Forms.TextBox();
            this.DatabaseText = new System.Windows.Forms.TextBox();
            this.EventoText = new System.Windows.Forms.TextBox();
            this.SeparadorCSVText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundText = new System.Windows.Forms.TextBox();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.selectBackgroundButton = new System.Windows.Forms.Button();
            this.PathText = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.selectEventPathButton = new System.Windows.Forms.Button();
            this.panelInferior.SuspendLayout();
            this.CabeceraPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.buttonGuardar);
            this.panelInferior.Controls.Add(this.buttonSalir);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 458);
            this.panelInferior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(933, 61);
            this.panelInferior.TabIndex = 4;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGuardar.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardar.Location = new System.Drawing.Point(14, 8);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(162, 45);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "&Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalir.Location = new System.Drawing.Point(183, 8);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(162, 45);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "&Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            // 
            // CabeceraPanel
            // 
            this.CabeceraPanel.Controls.Add(this.InstruccionesLabel);
            this.CabeceraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CabeceraPanel.Location = new System.Drawing.Point(0, 0);
            this.CabeceraPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CabeceraPanel.Name = "CabeceraPanel";
            this.CabeceraPanel.Size = new System.Drawing.Size(933, 46);
            this.CabeceraPanel.TabIndex = 5;
            // 
            // InstruccionesLabel
            // 
            this.InstruccionesLabel.AutoSize = true;
            this.InstruccionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstruccionesLabel.Location = new System.Drawing.Point(4, 10);
            this.InstruccionesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstruccionesLabel.Name = "InstruccionesLabel";
            this.InstruccionesLabel.Size = new System.Drawing.Size(155, 16);
            this.InstruccionesLabel.TabIndex = 1;
            this.InstruccionesLabel.Text = "Configuración del evento";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TituloLabel.Location = new System.Drawing.Point(17, 63);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(40, 16);
            this.TituloLabel.TabIndex = 6;
            this.TituloLabel.Text = "Título";
            // 
            // EventoLabel
            // 
            this.EventoLabel.AutoSize = true;
            this.EventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventoLabel.Location = new System.Drawing.Point(17, 137);
            this.EventoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EventoLabel.Name = "EventoLabel";
            this.EventoLabel.Size = new System.Drawing.Size(49, 16);
            this.EventoLabel.TabIndex = 7;
            this.EventoLabel.Text = "Evento";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.databaseLabel.Location = new System.Drawing.Point(17, 98);
            this.databaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(130, 16);
            this.databaseLabel.TabIndex = 8;
            this.databaseLabel.Text = "Nombre Base Datos";
            // 
            // TituloText
            // 
            this.TituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TituloText.Location = new System.Drawing.Point(206, 60);
            this.TituloText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TituloText.Name = "TituloText";
            this.TituloText.Size = new System.Drawing.Size(528, 22);
            this.TituloText.TabIndex = 9;
            // 
            // DatabaseText
            // 
            this.DatabaseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatabaseText.Location = new System.Drawing.Point(206, 95);
            this.DatabaseText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DatabaseText.Name = "DatabaseText";
            this.DatabaseText.Size = new System.Drawing.Size(528, 22);
            this.DatabaseText.TabIndex = 10;
            // 
            // EventoText
            // 
            this.EventoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventoText.Location = new System.Drawing.Point(206, 134);
            this.EventoText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EventoText.Name = "EventoText";
            this.EventoText.Size = new System.Drawing.Size(528, 22);
            this.EventoText.TabIndex = 11;
            // 
            // SeparadorCSVText
            // 
            this.SeparadorCSVText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeparadorCSVText.Location = new System.Drawing.Point(206, 172);
            this.SeparadorCSVText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SeparadorCSVText.Name = "SeparadorCSVText";
            this.SeparadorCSVText.Size = new System.Drawing.Size(528, 22);
            this.SeparadorCSVText.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Separador CSV";
            // 
            // BackgroundText
            // 
            this.BackgroundText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackgroundText.Location = new System.Drawing.Point(206, 213);
            this.BackgroundText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackgroundText.Name = "BackgroundText";
            this.BackgroundText.Size = new System.Drawing.Size(528, 22);
            this.BackgroundText.TabIndex = 15;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackgroundLabel.Location = new System.Drawing.Point(17, 217);
            this.BackgroundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(94, 16);
            this.BackgroundLabel.TabIndex = 14;
            this.BackgroundLabel.Text = "Imagen Fondo";
            // 
            // selectBackgroundButton
            // 
            this.selectBackgroundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectBackgroundButton.Location = new System.Drawing.Point(735, 213);
            this.selectBackgroundButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectBackgroundButton.Name = "selectBackgroundButton";
            this.selectBackgroundButton.Size = new System.Drawing.Size(28, 27);
            this.selectBackgroundButton.TabIndex = 16;
            this.selectBackgroundButton.Text = "...";
            this.selectBackgroundButton.UseVisualStyleBackColor = true;
            this.selectBackgroundButton.Click += new System.EventHandler(this.SelectBackgroundButton_Click);
            // 
            // PathText
            // 
            this.PathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathText.Location = new System.Drawing.Point(206, 248);
            this.PathText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(526, 22);
            this.PathText.TabIndex = 19;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathLabel.Location = new System.Drawing.Point(17, 251);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(34, 16);
            this.PathLabel.TabIndex = 18;
            this.PathLabel.Text = "Path";
            // 
            // selectEventPathButton
            // 
            this.selectEventPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectEventPathButton.Location = new System.Drawing.Point(735, 246);
            this.selectEventPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectEventPathButton.Name = "selectEventPathButton";
            this.selectEventPathButton.Size = new System.Drawing.Size(28, 27);
            this.selectEventPathButton.TabIndex = 20;
            this.selectEventPathButton.Text = "...";
            this.selectEventPathButton.UseVisualStyleBackColor = true;
            this.selectEventPathButton.Click += new System.EventHandler(this.SelectEventPathButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.selectEventPathButton);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.selectBackgroundButton);
            this.Controls.Add(this.BackgroundText);
            this.Controls.Add(this.BackgroundLabel);
            this.Controls.Add(this.SeparadorCSVText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventoText);
            this.Controls.Add(this.DatabaseText);
            this.Controls.Add(this.TituloText);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.EventoLabel);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.CabeceraPanel);
            this.Controls.Add(this.panelInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de evento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.panelInferior.ResumeLayout(false);
            this.CabeceraPanel.ResumeLayout(false);
            this.CabeceraPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Panel CabeceraPanel;
        private System.Windows.Forms.Label InstruccionesLabel;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Label EventoLabel;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.TextBox TituloText;
        private System.Windows.Forms.TextBox DatabaseText;
        private System.Windows.Forms.TextBox EventoText;
        private System.Windows.Forms.TextBox SeparadorCSVText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BackgroundText;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Button selectBackgroundButton;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button selectEventPathButton;
    }
}
