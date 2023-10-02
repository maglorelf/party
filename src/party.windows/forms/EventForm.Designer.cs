namespace party.windows.forms
{
    partial class EventForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            panelInferior = new System.Windows.Forms.Panel();
            buttonGuardar = new System.Windows.Forms.Button();
            buttonSalir = new System.Windows.Forms.Button();
            CabeceraPanel = new System.Windows.Forms.Panel();
            HeaderLabel = new System.Windows.Forms.Label();
            TitleLabel = new System.Windows.Forms.Label();
            StartDateLabel = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            TituloText = new System.Windows.Forms.TextBox();
            DescriptionText = new System.Windows.Forms.TextBox();
            StartDatePicker = new System.Windows.Forms.DateTimePicker();
            EndDatePicker = new System.Windows.Forms.DateTimePicker();
            EndDateLabel = new System.Windows.Forms.Label();
            CheckInPicker = new System.Windows.Forms.DateTimePicker();
            CheckInLabel = new System.Windows.Forms.Label();
            gridRoutes = new System.Windows.Forms.DataGridView();
            RoutesLabel = new System.Windows.Forms.Label();
            panelInferior.SuspendLayout();
            CabeceraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRoutes).BeginInit();
            SuspendLayout();
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(buttonGuardar);
            panelInferior.Controls.Add(buttonSalir);
            panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelInferior.Location = new System.Drawing.Point(0, 536);
            panelInferior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new System.Drawing.Size(813, 61);
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
            CabeceraPanel.Controls.Add(HeaderLabel);
            CabeceraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            CabeceraPanel.Location = new System.Drawing.Point(0, 0);
            CabeceraPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CabeceraPanel.Name = "CabeceraPanel";
            CabeceraPanel.Size = new System.Drawing.Size(813, 46);
            CabeceraPanel.TabIndex = 5;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            HeaderLabel.Location = new System.Drawing.Point(4, 10);
            HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new System.Drawing.Size(142, 16);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Información del evento";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TitleLabel.Location = new System.Drawing.Point(17, 60);
            TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(40, 16);
            TitleLabel.TabIndex = 6;
            TitleLabel.Text = "Título";
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StartDateLabel.Location = new System.Drawing.Point(17, 130);
            StartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new System.Drawing.Size(98, 16);
            StartDateLabel.TabIndex = 7;
            StartDateLabel.Text = "Fecha de inicio";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DescriptionLabel.Location = new System.Drawing.Point(17, 95);
            DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(130, 16);
            DescriptionLabel.TabIndex = 8;
            DescriptionLabel.Text = "Nombre Base Datos";
            // 
            // TituloText
            // 
            TituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TituloText.Location = new System.Drawing.Point(206, 57);
            TituloText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TituloText.MaxLength = 2048;
            TituloText.Name = "TituloText";
            TituloText.Size = new System.Drawing.Size(528, 22);
            TituloText.TabIndex = 9;
            // 
            // DescriptionText
            // 
            DescriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DescriptionText.Location = new System.Drawing.Point(206, 92);
            DescriptionText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DescriptionText.MaxLength = 2048;
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Size = new System.Drawing.Size(528, 22);
            DescriptionText.TabIndex = 10;
            // 
            // StartDatePicker
            // 
            StartDatePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            StartDatePicker.Location = new System.Drawing.Point(206, 127);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new System.Drawing.Size(200, 23);
            StartDatePicker.TabIndex = 11;
            // 
            // EndDatePicker
            // 
            EndDatePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            EndDatePicker.Location = new System.Drawing.Point(206, 162);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new System.Drawing.Size(200, 23);
            EndDatePicker.TabIndex = 13;
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EndDateLabel.Location = new System.Drawing.Point(17, 165);
            EndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new System.Drawing.Size(133, 16);
            EndDateLabel.TabIndex = 12;
            EndDateLabel.Text = "Fecha de finalizacion";
            // 
            // CheckInPicker
            // 
            CheckInPicker.CustomFormat = "yyyy-MM-dd HH:mm";
            CheckInPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            CheckInPicker.Location = new System.Drawing.Point(206, 197);
            CheckInPicker.Name = "CheckInPicker";
            CheckInPicker.Size = new System.Drawing.Size(200, 23);
            CheckInPicker.TabIndex = 15;
            // 
            // CheckInLabel
            // 
            CheckInLabel.AutoSize = true;
            CheckInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckInLabel.Location = new System.Drawing.Point(17, 200);
            CheckInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CheckInLabel.Name = "CheckInLabel";
            CheckInLabel.Size = new System.Drawing.Size(111, 16);
            CheckInLabel.TabIndex = 14;
            CheckInLabel.Text = "Hora de Check-In";
            // 
            // gridRoutes
            // 
            gridRoutes.AllowUserToAddRows = false;
            gridRoutes.AllowUserToDeleteRows = false;
            gridRoutes.AllowUserToOrderColumns = true;
            gridRoutes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            gridRoutes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRoutes.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridRoutes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            gridRoutes.Location = new System.Drawing.Point(0, 263);
            gridRoutes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridRoutes.MultiSelect = false;
            gridRoutes.Name = "gridRoutes";
            gridRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            gridRoutes.ShowEditingIcon = false;
            gridRoutes.Size = new System.Drawing.Size(813, 273);
            gridRoutes.TabIndex = 16;
            // 
            // RoutesLabel
            // 
            RoutesLabel.AutoSize = true;
            RoutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RoutesLabel.Location = new System.Drawing.Point(13, 244);
            RoutesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            RoutesLabel.Name = "RoutesLabel";
            RoutesLabel.Size = new System.Drawing.Size(97, 16);
            RoutesLabel.TabIndex = 17;
            RoutesLabel.Text = "Localizaciones";
            // 
            // EventForm
            // 
            AcceptButton = buttonGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonSalir;
            ClientSize = new System.Drawing.Size(813, 597);
            Controls.Add(RoutesLabel);
            Controls.Add(gridRoutes);
            Controls.Add(CheckInPicker);
            Controls.Add(CheckInLabel);
            Controls.Add(EndDatePicker);
            Controls.Add(EndDateLabel);
            Controls.Add(StartDatePicker);
            Controls.Add(DescriptionText);
            Controls.Add(TituloText);
            Controls.Add(DescriptionLabel);
            Controls.Add(StartDateLabel);
            Controls.Add(TitleLabel);
            Controls.Add(CabeceraPanel);
            Controls.Add(panelInferior);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Información del evento";
            FormClosing += EventForm_FormClosing;
            panelInferior.ResumeLayout(false);
            CabeceraPanel.ResumeLayout(false);
            CabeceraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridRoutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Panel CabeceraPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox TituloText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DateTimePicker CheckInPicker;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.DataGridView gridRoutes;
        private System.Windows.Forms.Label RoutesLabel;
    }
}
