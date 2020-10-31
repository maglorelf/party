namespace party
{
    partial class NuevoInvitadoForm
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
            this.NombreText = new System.Windows.Forms.TextBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.DniText = new System.Windows.Forms.TextBox();
            this.DniLabel = new System.Windows.Forms.Label();
            this.NotasText = new System.Windows.Forms.TextBox();
            this.NotasLabel = new System.Windows.Forms.Label();
            this.panelInferior.SuspendLayout();
            this.CabeceraPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.buttonGuardar);
            this.panelInferior.Controls.Add(this.buttonSalir);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 253);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(649, 53);
            this.panelInferior.TabIndex = 5;
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
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
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
            this.CabeceraPanel.Size = new System.Drawing.Size(649, 40);
            this.CabeceraPanel.TabIndex = 6;
            // 
            // InstruccionesLabel
            // 
            this.InstruccionesLabel.AutoSize = true;
            this.InstruccionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruccionesLabel.Location = new System.Drawing.Point(3, 9);
            this.InstruccionesLabel.Name = "InstruccionesLabel";
            this.InstruccionesLabel.Size = new System.Drawing.Size(498, 16);
            this.InstruccionesLabel.TabIndex = 1;
            this.InstruccionesLabel.Text = "Creación de un invitado no registrado (indicar la información sobre la confirmaci" +
    "ón)";
            // 
            // NombreText
            // 
            this.NombreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreText.Location = new System.Drawing.Point(176, 61);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(453, 22);
            this.NombreText.TabIndex = 11;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(12, 64);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(140, 16);
            this.TituloLabel.TabIndex = 10;
            this.TituloLabel.Text = "Nombre y Apellidos(*)";
            // 
            // DniText
            // 
            this.DniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniText.Location = new System.Drawing.Point(176, 97);
            this.DniText.Name = "DniText";
            this.DniText.Size = new System.Drawing.Size(453, 22);
            this.DniText.TabIndex = 13;
            // 
            // DniLabel
            // 
            this.DniLabel.AutoSize = true;
            this.DniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniLabel.Location = new System.Drawing.Point(12, 100);
            this.DniLabel.Name = "DniLabel";
            this.DniLabel.Size = new System.Drawing.Size(44, 16);
            this.DniLabel.TabIndex = 12;
            this.DniLabel.Text = "Dni (*)";
            // 
            // NotasText
            // 
            this.NotasText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasText.Location = new System.Drawing.Point(176, 137);
            this.NotasText.MaxLength = 2000;
            this.NotasText.Multiline = true;
            this.NotasText.Name = "NotasText";
            this.NotasText.Size = new System.Drawing.Size(453, 80);
            this.NotasText.TabIndex = 15;
            // 
            // NotasLabel
            // 
            this.NotasLabel.AutoSize = true;
            this.NotasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasLabel.Location = new System.Drawing.Point(12, 140);
            this.NotasLabel.Name = "NotasLabel";
            this.NotasLabel.Size = new System.Drawing.Size(57, 16);
            this.NotasLabel.TabIndex = 14;
            this.NotasLabel.Text = "Notas(*)";
            // 
            // NuevoInvitadoForm
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(649, 306);
            this.Controls.Add(this.NotasText);
            this.Controls.Add(this.NotasLabel);
            this.Controls.Add(this.DniText);
            this.Controls.Add(this.DniLabel);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.CabeceraPanel);
            this.Controls.Add(this.panelInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NuevoInvitadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo invitado";
            this.panelInferior.ResumeLayout(false);
            this.CabeceraPanel.ResumeLayout(false);
            this.CabeceraPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Panel CabeceraPanel;
        private System.Windows.Forms.Label InstruccionesLabel;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.TextBox DniText;
        private System.Windows.Forms.Label DniLabel;
        private System.Windows.Forms.TextBox NotasText;
        private System.Windows.Forms.Label NotasLabel;
    }
}