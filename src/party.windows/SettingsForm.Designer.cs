namespace party.windows
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
            this.selectDatabaseButton = new System.Windows.Forms.Button();
            this.panelInferior.SuspendLayout();
            this.CabeceraPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.buttonGuardar);
            this.panelInferior.Controls.Add(this.buttonSalir);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 397);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(800, 53);
            this.panelInferior.TabIndex = 4;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGuardar.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.buttonGuardar.Location = new System.Drawing.Point(12, 7);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(139, 39);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "&Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.buttonSalir.Location = new System.Drawing.Point(157, 7);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(139, 39);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "&Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            // 
            // CabeceraPanel
            // 
            this.CabeceraPanel.Controls.Add(this.InstruccionesLabel);
            this.CabeceraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CabeceraPanel.Location = new System.Drawing.Point(0, 0);
            this.CabeceraPanel.Name = "CabeceraPanel";
            this.CabeceraPanel.Size = new System.Drawing.Size(800, 40);
            this.CabeceraPanel.TabIndex = 5;
            // 
            // InstruccionesLabel
            // 
            this.InstruccionesLabel.AutoSize = true;
            this.InstruccionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruccionesLabel.Location = new System.Drawing.Point(3, 9);
            this.InstruccionesLabel.Name = "InstruccionesLabel";
            this.InstruccionesLabel.Size = new System.Drawing.Size(156, 16);
            this.InstruccionesLabel.TabIndex = 1;
            this.InstruccionesLabel.Text = "Configuración del evento";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(13, 55);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(41, 16);
            this.TituloLabel.TabIndex = 6;
            this.TituloLabel.Text = "Título";
            // 
            // EventoLabel
            // 
            this.EventoLabel.AutoSize = true;
            this.EventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventoLabel.Location = new System.Drawing.Point(13, 119);
            this.EventoLabel.Name = "EventoLabel";
            this.EventoLabel.Size = new System.Drawing.Size(50, 16);
            this.EventoLabel.TabIndex = 7;
            this.EventoLabel.Text = "Evento";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLabel.Location = new System.Drawing.Point(12, 85);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(131, 16);
            this.databaseLabel.TabIndex = 8;
            this.databaseLabel.Text = "Nombre Base Datos";
            // 
            // TituloText
            // 
            this.TituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloText.Location = new System.Drawing.Point(177, 52);
            this.TituloText.Name = "TituloText";
            this.TituloText.Size = new System.Drawing.Size(453, 22);
            this.TituloText.TabIndex = 9;
            // 
            // DatabaseText
            // 
            this.DatabaseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseText.Location = new System.Drawing.Point(177, 82);
            this.DatabaseText.Name = "DatabaseText";
            this.DatabaseText.Size = new System.Drawing.Size(453, 22);
            this.DatabaseText.TabIndex = 10;
            // 
            // EventoText
            // 
            this.EventoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventoText.Location = new System.Drawing.Point(177, 116);
            this.EventoText.Name = "EventoText";
            this.EventoText.Size = new System.Drawing.Size(453, 22);
            this.EventoText.TabIndex = 11;
            // 
            // SeparadorCSVText
            // 
            this.SeparadorCSVText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparadorCSVText.Location = new System.Drawing.Point(177, 149);
            this.SeparadorCSVText.Name = "SeparadorCSVText";
            this.SeparadorCSVText.Size = new System.Drawing.Size(453, 22);
            this.SeparadorCSVText.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Separador CSV";
            // 
            // BackgroundText
            // 
            this.BackgroundText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundText.Location = new System.Drawing.Point(177, 185);
            this.BackgroundText.Name = "BackgroundText";
            this.BackgroundText.Size = new System.Drawing.Size(453, 22);
            this.BackgroundText.TabIndex = 15;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundLabel.Location = new System.Drawing.Point(13, 188);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(95, 16);
            this.BackgroundLabel.TabIndex = 14;
            this.BackgroundLabel.Text = "Imagen Fondo";
            // 
            // selectBackgroundButton
            // 
            this.selectBackgroundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBackgroundButton.Location = new System.Drawing.Point(630, 185);
            this.selectBackgroundButton.Name = "selectBackgroundButton";
            this.selectBackgroundButton.Size = new System.Drawing.Size(24, 23);
            this.selectBackgroundButton.TabIndex = 16;
            this.selectBackgroundButton.Text = "...";
            this.selectBackgroundButton.UseVisualStyleBackColor = true;
            this.selectBackgroundButton.Click += new System.EventHandler(this.SelectBackgroundButton_Click);
            // 
            // selectDatabaseButton
            // 
            this.selectDatabaseButton.Location = new System.Drawing.Point(630, 82);
            this.selectDatabaseButton.Name = "selectDatabaseButton";
            this.selectDatabaseButton.Size = new System.Drawing.Size(24, 23);
            this.selectDatabaseButton.TabIndex = 17;
            this.selectDatabaseButton.Text = "...";
            this.selectDatabaseButton.UseVisualStyleBackColor = true;
            this.selectDatabaseButton.Click += new System.EventHandler(this.SelectDatabaseButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectDatabaseButton);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de evento";
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
        private System.Windows.Forms.Button selectDatabaseButton;
    }
}