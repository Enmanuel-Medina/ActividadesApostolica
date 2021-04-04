namespace ActividadesApostolica.UI.Registros
{
    partial class rAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAsistencias));
            this.label1 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ActividadComboBox = new System.Windows.Forms.ComboBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ausente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Excusa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoverFilaButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.ExcusasTextBox = new System.Windows.Forms.TextBox();
            this.AusentesTextBox = new System.Windows.Forms.TextBox();
            this.PresentesTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.PersonaComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(24, 50);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.IdNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actividad";
            // 
            // ActividadComboBox
            // 
            this.ActividadComboBox.FormattingEnabled = true;
            this.ActividadComboBox.Location = new System.Drawing.Point(24, 119);
            this.ActividadComboBox.Name = "ActividadComboBox";
            this.ActividadComboBox.Size = new System.Drawing.Size(868, 28);
            this.ActividadComboBox.TabIndex = 4;
            this.ActividadComboBox.SelectedIndexChanged += new System.EventHandler(this.ActividadComboBox_SelectedIndexChanged);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(698, 50);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(194, 27);
            this.FechaDateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(698, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ActividadesApostolica.Properties.Resources.eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(532, 732);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(95, 42);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ActividadesApostolica.Properties.Resources.Guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(423, 732);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(103, 42);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ActividadesApostolica.Properties.Resources.Nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(323, 732);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(94, 42);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ActividadesApostolica.Properties.Resources.Buscar1;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(180, 41);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 36);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowUserToAddRows = false;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Persona,
            this.Presente,
            this.Ausente,
            this.Excusa});
            this.DetalleDataGridView.Location = new System.Drawing.Point(6, 87);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.RowTemplate.Height = 29;
            this.DetalleDataGridView.Size = new System.Drawing.Size(867, 247);
            this.DetalleDataGridView.TabIndex = 12;
            this.DetalleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleDataGridView_CellClick);
            this.DetalleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleDataGridView_CellContentClick);
            // 
            // Persona
            // 
            this.Persona.HeaderText = "Persona";
            this.Persona.MinimumWidth = 6;
            this.Persona.Name = "Persona";
            this.Persona.Width = 125;
            // 
            // Presente
            // 
            this.Presente.HeaderText = "Presente";
            this.Presente.MinimumWidth = 6;
            this.Presente.Name = "Presente";
            this.Presente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Presente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Presente.Width = 125;
            // 
            // Ausente
            // 
            this.Ausente.HeaderText = "Ausente";
            this.Ausente.MinimumWidth = 6;
            this.Ausente.Name = "Ausente";
            this.Ausente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ausente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ausente.Width = 125;
            // 
            // Excusa
            // 
            this.Excusa.HeaderText = "Excusa";
            this.Excusa.MinimumWidth = 6;
            this.Excusa.Name = "Excusa";
            this.Excusa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excusa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Excusa.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoverFilaButton);
            this.groupBox1.Controls.Add(this.TotalTextBox);
            this.groupBox1.Controls.Add(this.ExcusasTextBox);
            this.groupBox1.Controls.Add(this.AusentesTextBox);
            this.groupBox1.Controls.Add(this.PresentesTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Controls.Add(this.PersonaComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DetalleDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(24, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 508);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asistencias";
            // 
            // RemoverFilaButton
            // 
            this.RemoverFilaButton.Location = new System.Drawing.Point(6, 340);
            this.RemoverFilaButton.Name = "RemoverFilaButton";
            this.RemoverFilaButton.Size = new System.Drawing.Size(129, 29);
            this.RemoverFilaButton.TabIndex = 0;
            this.RemoverFilaButton.Text = "Remover fila";
            this.RemoverFilaButton.UseVisualStyleBackColor = true;
            this.RemoverFilaButton.Click += new System.EventHandler(this.RemoverFilaButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(687, 466);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(185, 28);
            this.TotalTextBox.TabIndex = 23;
            // 
            // ExcusasTextBox
            // 
            this.ExcusasTextBox.Location = new System.Drawing.Point(687, 412);
            this.ExcusasTextBox.Name = "ExcusasTextBox";
            this.ExcusasTextBox.Size = new System.Drawing.Size(185, 28);
            this.ExcusasTextBox.TabIndex = 22;
            // 
            // AusentesTextBox
            // 
            this.AusentesTextBox.Location = new System.Drawing.Point(108, 466);
            this.AusentesTextBox.Name = "AusentesTextBox";
            this.AusentesTextBox.Size = new System.Drawing.Size(185, 28);
            this.AusentesTextBox.TabIndex = 21;
            // 
            // PresentesTextBox
            // 
            this.PresentesTextBox.Location = new System.Drawing.Point(108, 412);
            this.PresentesTextBox.Name = "PresentesTextBox";
            this.PresentesTextBox.Size = new System.Drawing.Size(185, 28);
            this.PresentesTextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(599, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(599, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Excusas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(5, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ausentes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Presentes";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgregarButton.Location = new System.Drawing.Point(823, 45);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(50, 36);
            this.AgregarButton.TabIndex = 15;
            this.AgregarButton.Text = "+";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // PersonaComboBox
            // 
            this.PersonaComboBox.FormattingEnabled = true;
            this.PersonaComboBox.Location = new System.Drawing.Point(6, 51);
            this.PersonaComboBox.Name = "PersonaComboBox";
            this.PersonaComboBox.Size = new System.Drawing.Size(811, 28);
            this.PersonaComboBox.TabIndex = 14;
            this.PersonaComboBox.SelectedIndexChanged += new System.EventHandler(this.PersonaComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Persona";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(423, 683);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(185, 27);
            this.UsuarioTextBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(334, 683);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Usuario";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 791);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.ActividadComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rAsistencias";
            this.Text = "Registro de asistencias";
            this.Load += new System.EventHandler(this.rAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ActividadComboBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ComboBox PersonaComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox ExcusasTextBox;
        private System.Windows.Forms.TextBox AusentesTextBox;
        private System.Windows.Forms.TextBox PresentesTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button RemoverFilaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Presente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ausente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excusa;
    }
}