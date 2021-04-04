


namespace ActividadesApostolica.UI.Registros
{
    partial class rAportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MetaComboBox = new System.Windows.Forms.ComboBox();
            this.PersonaComboBox = new System.Windows.Forms.ComboBox();
            this.ContribucionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RestaTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ElimarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contribucion";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(30, 46);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.IdNumericUpDown.TabIndex = 4;
            // 
            // MetaComboBox
            // 
            this.MetaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetaComboBox.FormattingEnabled = true;
            this.MetaComboBox.Location = new System.Drawing.Point(29, 115);
            this.MetaComboBox.Name = "MetaComboBox";
            this.MetaComboBox.Size = new System.Drawing.Size(512, 28);
            this.MetaComboBox.TabIndex = 5;
            // 
            // PersonaComboBox
            // 
            this.PersonaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonaComboBox.FormattingEnabled = true;
            this.PersonaComboBox.Location = new System.Drawing.Point(29, 185);
            this.PersonaComboBox.Name = "PersonaComboBox";
            this.PersonaComboBox.Size = new System.Drawing.Size(512, 28);
            this.PersonaComboBox.TabIndex = 6;
            // 
            // ContribucionTextBox
            // 
            this.ContribucionTextBox.Location = new System.Drawing.Point(29, 262);
            this.ContribucionTextBox.Name = "ContribucionTextBox";
            this.ContribucionTextBox.Size = new System.Drawing.Size(211, 27);
            this.ContribucionTextBox.TabIndex = 7;
            this.ContribucionTextBox.TextChanged += new System.EventHandler(this.ContribucionTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resta";
            // 
            // RestaTextBox
            // 
            this.RestaTextBox.Location = new System.Drawing.Point(295, 262);
            this.RestaTextBox.Name = "RestaTextBox";
            this.RestaTextBox.ReadOnly = true;
            this.RestaTextBox.Size = new System.Drawing.Size(246, 27);
            this.RestaTextBox.TabIndex = 9;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(202, 46);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 29);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(101, 336);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(97, 29);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(222, 336);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(94, 29);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ElimarButton
            // 
            this.ElimarButton.Location = new System.Drawing.Point(344, 336);
            this.ElimarButton.Name = "ElimarButton";
            this.ElimarButton.Size = new System.Drawing.Size(94, 29);
            this.ElimarButton.TabIndex = 13;
            this.ElimarButton.Text = "Eliminar";
            this.ElimarButton.UseVisualStyleBackColor = true;
            this.ElimarButton.Click += new System.EventHandler(this.ElimarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(377, 48);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(164, 27);
            this.FechaDateTimePicker.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha";
            // 
            // rAportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 408);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.ElimarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.RestaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContribucionTextBox);
            this.Controls.Add(this.PersonaComboBox);
            this.Controls.Add(this.MetaComboBox);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rAportes";
            this.Text = "rAportes";
            this.Load += new System.EventHandler(this.rAportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.ComboBox MetaComboBox;
        private System.Windows.Forms.ComboBox PersonaComboBox;
        private System.Windows.Forms.TextBox ContribucionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RestaTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ElimarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
    }
}