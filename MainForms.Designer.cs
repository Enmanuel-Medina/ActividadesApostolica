
namespace ActividadesApostolica
{
    partial class MainForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.RegistroStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActividadesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsistenciaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonasStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColectasStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActividadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuarioStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AportesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroStripMenuItem,
            this.ConsultasStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(1162, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // RegistroStripMenuItem
            // 
            this.RegistroStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosStripMenuItem,
            this.ActividadesStripMenuItem,
            this.AsistenciaStripMenuItem,
            this.PersonasStripMenuItem,
            this.ColectasStripMenuItem,
            this.AportesStripMenuItem});
            this.RegistroStripMenuItem.Name = "RegistroStripMenuItem";
            this.RegistroStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.RegistroStripMenuItem.Text = "&Registros";
            // 
            // UsuariosStripMenuItem
            // 
            this.UsuariosStripMenuItem.Name = "UsuariosStripMenuItem";
            this.UsuariosStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.UsuariosStripMenuItem.Text = "Usuarios";
            // 
            // ActividadesStripMenuItem
            // 
            this.ActividadesStripMenuItem.Name = "ActividadesStripMenuItem";
            this.ActividadesStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.ActividadesStripMenuItem.Text = "Actividades";
            // 
            // AsistenciaStripMenuItem
            // 
            this.AsistenciaStripMenuItem.Name = "AsistenciaStripMenuItem";
            this.AsistenciaStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.AsistenciaStripMenuItem.Text = "Asistencias";
            // 
            // PersonasStripMenuItem
            // 
            this.PersonasStripMenuItem.Name = "PersonasStripMenuItem";
            this.PersonasStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.PersonasStripMenuItem.Text = "Personas";
            // 
            // ColectasStripMenuItem
            // 
            this.ColectasStripMenuItem.Name = "ColectasStripMenuItem";
            this.ColectasStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.ColectasStripMenuItem.Text = "Colectas";
            // 
            // ConsultasStripMenuItem
            // 
            this.ConsultasStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActividadStripMenuItem,
            this.PersonaStripMenuItem,
            this.UsuarioStripMenuItem});
            this.ConsultasStripMenuItem.Name = "ConsultasStripMenuItem";
            this.ConsultasStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.ConsultasStripMenuItem.Text = "&Consultas";
            // 
            // ActividadStripMenuItem
            // 
            this.ActividadStripMenuItem.Name = "ActividadStripMenuItem";
            this.ActividadStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.ActividadStripMenuItem.Text = "Actividades";
            // 
            // PersonaStripMenuItem
            // 
            this.PersonaStripMenuItem.Name = "PersonaStripMenuItem";
            this.PersonaStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.PersonaStripMenuItem.Text = "Personas";
            // 
            // UsuarioStripMenuItem
            // 
            this.UsuarioStripMenuItem.Name = "UsuarioStripMenuItem";
            this.UsuarioStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.UsuarioStripMenuItem.Text = "Usuarios";
            // 
            // AportesStripMenuItem
            // 
            this.AportesStripMenuItem.Name = "AportesStripMenuItem";
            this.AportesStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.AportesStripMenuItem.Text = "Aportes";
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 606);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForms";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RegistroStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuariosStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActividadesStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AsistenciaStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonasStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultasStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActividadStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonaStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuarioStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColectasStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AportesStripMenuItem;
    }
}
