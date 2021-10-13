namespace party.windows
{
    partial class BarcodesConfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodesConfForm));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.ConfiguracionCodigosBarraPanel = new System.Windows.Forms.Panel();
            this.CabeceraPanel = new System.Windows.Forms.Panel();
            this.InstruccionesLabel = new System.Windows.Forms.Label();
            this.barcode1Box = new System.Windows.Forms.PictureBox();
            this.barcodeBox2 = new System.Windows.Forms.PictureBox();
            this.panelInferior.SuspendLayout();
            this.ConfiguracionCodigosBarraPanel.SuspendLayout();
            this.CabeceraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.buttonSalir.Location = new System.Drawing.Point(12, 6);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(139, 39);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "&Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.buttonSalir);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 328);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(427, 53);
            this.panelInferior.TabIndex = 3;
            // 
            // ConfiguracionCodigosBarraPanel
            // 
            this.ConfiguracionCodigosBarraPanel.Controls.Add(this.barcodeBox2);
            this.ConfiguracionCodigosBarraPanel.Controls.Add(this.barcode1Box);
            this.ConfiguracionCodigosBarraPanel.Controls.Add(this.CabeceraPanel);
            this.ConfiguracionCodigosBarraPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfiguracionCodigosBarraPanel.Location = new System.Drawing.Point(0, 0);
            this.ConfiguracionCodigosBarraPanel.Name = "ConfiguracionCodigosBarraPanel";
            this.ConfiguracionCodigosBarraPanel.Size = new System.Drawing.Size(427, 328);
            this.ConfiguracionCodigosBarraPanel.TabIndex = 4;
            // 
            // CabeceraPanel
            // 
            this.CabeceraPanel.Controls.Add(this.InstruccionesLabel);
            this.CabeceraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CabeceraPanel.Location = new System.Drawing.Point(0, 0);
            this.CabeceraPanel.Name = "CabeceraPanel";
            this.CabeceraPanel.Size = new System.Drawing.Size(427, 40);
            this.CabeceraPanel.TabIndex = 3;
            // 
            // InstruccionesLabel
            // 
            this.InstruccionesLabel.AutoSize = true;
            this.InstruccionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruccionesLabel.Location = new System.Drawing.Point(9, 9);
            this.InstruccionesLabel.Name = "InstruccionesLabel";
            this.InstruccionesLabel.Size = new System.Drawing.Size(254, 16);
            this.InstruccionesLabel.TabIndex = 1;
            this.InstruccionesLabel.Text = "Códigos para la configuración de Lectora";
            // 
            // barcode1Box
            // 
            this.barcode1Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcode1Box.Image = ((System.Drawing.Image)(resources.GetObject("barcode1Box.Image")));
            this.barcode1Box.Location = new System.Drawing.Point(0, 40);
            this.barcode1Box.Name = "barcode1Box";
            this.barcode1Box.Size = new System.Drawing.Size(427, 173);
            this.barcode1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barcode1Box.TabIndex = 4;
            this.barcode1Box.TabStop = false;
            // 
            // barcodeBox2
            // 
            this.barcodeBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeBox2.Image = ((System.Drawing.Image)(resources.GetObject("barcodeBox2.Image")));
            this.barcodeBox2.Location = new System.Drawing.Point(0, 213);
            this.barcodeBox2.Name = "barcodeBox2";
            this.barcodeBox2.Size = new System.Drawing.Size(427, 116);
            this.barcodeBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barcodeBox2.TabIndex = 5;
            this.barcodeBox2.TabStop = false;
            // 
            // BarcodesConfForm
            // 
            this.AcceptButton = this.buttonSalir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(427, 381);
            this.Controls.Add(this.ConfiguracionCodigosBarraPanel);
            this.Controls.Add(this.panelInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BarcodesConfForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración Lectora";
            this.panelInferior.ResumeLayout(false);
            this.ConfiguracionCodigosBarraPanel.ResumeLayout(false);
            this.CabeceraPanel.ResumeLayout(false);
            this.CabeceraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel ConfiguracionCodigosBarraPanel;
        private System.Windows.Forms.PictureBox barcodeBox2;
        private System.Windows.Forms.PictureBox barcode1Box;
        private System.Windows.Forms.Panel CabeceraPanel;
        private System.Windows.Forms.Label InstruccionesLabel;
    }
}