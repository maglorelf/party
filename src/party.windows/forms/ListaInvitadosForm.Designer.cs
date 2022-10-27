namespace party.windows.forms
{
    partial class ListaInvitadosForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.NuevoInvitadoButton = new System.Windows.Forms.Button();
            this.limpiarFiltroButton = new System.Windows.Forms.Button();
            this.fieldToFilterCombo = new System.Windows.Forms.ComboBox();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.DataFiltroText = new System.Windows.Forms.TextBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.gridInvitados = new System.Windows.Forms.DataGridView();
            this.contextMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.marcarAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.addNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvitados)).BeginInit();
            this.contextMenuGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.NuevoInvitadoButton);
            this.panelSuperior.Controls.Add(this.limpiarFiltroButton);
            this.panelSuperior.Controls.Add(this.fieldToFilterCombo);
            this.panelSuperior.Controls.Add(this.filtrarButton);
            this.panelSuperior.Controls.Add(this.DataFiltroText);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(982, 58);
            this.panelSuperior.TabIndex = 1;
            // 
            // NuevoInvitadoButton
            // 
            this.NuevoInvitadoButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NuevoInvitadoButton.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.NuevoInvitadoButton.Location = new System.Drawing.Point(765, 8);
            this.NuevoInvitadoButton.Name = "NuevoInvitadoButton";
            this.NuevoInvitadoButton.Size = new System.Drawing.Size(139, 30);
            this.NuevoInvitadoButton.TabIndex = 10;
            this.NuevoInvitadoButton.Text = "&Nuevo";
            this.NuevoInvitadoButton.UseVisualStyleBackColor = false;
            this.NuevoInvitadoButton.Click += new System.EventHandler(this.NuevoInvitadoButton_Click);
            // 
            // limpiarFiltroButton
            // 
            this.limpiarFiltroButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.limpiarFiltroButton.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.limpiarFiltroButton.Location = new System.Drawing.Point(620, 8);
            this.limpiarFiltroButton.Name = "limpiarFiltroButton";
            this.limpiarFiltroButton.Size = new System.Drawing.Size(139, 30);
            this.limpiarFiltroButton.TabIndex = 9;
            this.limpiarFiltroButton.Text = "&Limpiar";
            this.limpiarFiltroButton.UseVisualStyleBackColor = false;
            this.limpiarFiltroButton.Click += new System.EventHandler(this.LimpiarFiltroButton_Click);
            // 
            // fieldToFilterCombo
            // 
            this.fieldToFilterCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldToFilterCombo.FormattingEnabled = true;
            this.fieldToFilterCombo.Location = new System.Drawing.Point(295, 11);
            this.fieldToFilterCombo.Name = "fieldToFilterCombo";
            this.fieldToFilterCombo.Size = new System.Drawing.Size(174, 24);
            this.fieldToFilterCombo.TabIndex = 8;
            // 
            // filtrarButton
            // 
            this.filtrarButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.filtrarButton.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.filtrarButton.Location = new System.Drawing.Point(475, 8);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(139, 30);
            this.filtrarButton.TabIndex = 7;
            this.filtrarButton.Text = "&Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = false;
            this.filtrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // DataFiltroText
            // 
            this.DataFiltroText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFiltroText.Location = new System.Drawing.Point(12, 12);
            this.DataFiltroText.Name = "DataFiltroText";
            this.DataFiltroText.Size = new System.Drawing.Size(277, 22);
            this.DataFiltroText.TabIndex = 0;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.buttonSalir);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 454);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(982, 53);
            this.panelInferior.TabIndex = 2;
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
            // panelFill
            // 
            this.panelFill.Controls.Add(this.gridInvitados);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 58);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(982, 396);
            this.panelFill.TabIndex = 3;
            // 
            // gridInvitados
            // 
            this.gridInvitados.AllowUserToAddRows = false;
            this.gridInvitados.AllowUserToDeleteRows = false;
            this.gridInvitados.AllowUserToOrderColumns = true;
            this.gridInvitados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInvitados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInvitados.ContextMenuStrip = this.contextMenuGrid;
            this.gridInvitados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInvitados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridInvitados.Location = new System.Drawing.Point(0, 0);
            this.gridInvitados.MultiSelect = false;
            this.gridInvitados.Name = "gridInvitados";
            this.gridInvitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInvitados.ShowEditingIcon = false;
            this.gridInvitados.Size = new System.Drawing.Size(982, 396);
            this.gridInvitados.TabIndex = 0;
            this.gridInvitados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInvitados_RowEnter);
            // 
            // contextMenuGrid
            // 
            this.contextMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarAsistencia,
            this.addNotasToolStripMenuItem});
            this.contextMenuGrid.Name = "contextMenuGrid";
            this.contextMenuGrid.Size = new System.Drawing.Size(197, 48);
            // 
            // marcarAsistencia
            // 
            this.marcarAsistencia.Name = "marcarAsistencia";
            this.marcarAsistencia.Size = new System.Drawing.Size(196, 22);
            this.marcarAsistencia.Text = "Marcar como Asistente";
            this.marcarAsistencia.Click += new System.EventHandler(this.MarcarAsistencia_Click);
            // 
            // addNotasToolStripMenuItem
            // 
            this.addNotasToolStripMenuItem.Name = "addNotasToolStripMenuItem";
            this.addNotasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addNotasToolStripMenuItem.Text = "Añadir Notas";
            this.addNotasToolStripMenuItem.Click += new System.EventHandler(this.AddNotasToolStripMenuItem_Click);
            // 
            // ListaInvitadosForm
            // 
            this.AcceptButton = this.filtrarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(982, 507);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaInvitadosForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de invitados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInvitados)).EndInit();
            this.contextMenuGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DataGridView gridInvitados;
        private System.Windows.Forms.ComboBox fieldToFilterCombo;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.TextBox DataFiltroText;
        private System.Windows.Forms.Button limpiarFiltroButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem marcarAsistencia;
        private System.Windows.Forms.Button NuevoInvitadoButton;
        private System.Windows.Forms.ToolStripMenuItem addNotasToolStripMenuItem;
    }
}