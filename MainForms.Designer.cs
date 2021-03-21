
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
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroStripMenuItem});
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
            this.ActividadesStripMenuItem});
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
    }
}
