using ActividadesApostolica.UI.Consultas;
using ActividadesApostolica.UI.Registros;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadesApostolica
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();

            //Registros
            this.UsuariosStripMenuItem.Click += new EventHandler(this.UsuariosStripMenuItem_ItemClicked);

            //Actividades
            this.ActividadesStripMenuItem.Click += new EventHandler(this.ActividadesStripMenuItem_ItemClicked);

            //Asistencias
            this.AsistenciaStripMenuItem.Click += new EventHandler(this.AsistenciaStripMenuItem_ItemClicked);

            //Personas
            this.PersonasStripMenuItem.Click += new EventHandler(this.PersonasStripMenuItem_ItemCliked);

            //Cosultas
            this.ActividadStripMenuItem.Click += new EventHandler(this.ActividadStripMenuItem_ItemCliked);

            //Personas Consulta
            this.PersonaStripMenuItem.Click += new EventHandler(this.PersonaStripMenuItem_ItemCliked );

            //Usuarios Consulta
            this.UsuarioStripMenuItem.Click += new EventHandler(this.UsuarioStripMenuItem_ItemCliked);

        }

        private void UsuariosStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuario = new rUsuarios();

            if (Login.TipoUsuario == "Administrador")
            {
                usuario.MdiParent = this;
                usuario.Show();
            }
            else
                MessageBox.Show("Solo un usuario tipo Administrador puede acceder a este registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ActividadesStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var actividad = new rActividades();
            actividad.MdiParent = this;
            actividad.Show();
        }

        private void AsistenciaStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var asistencias = new rAsistencias();
            asistencias.MdiParent = this;
            asistencias.Show();
        }

        private void PersonasStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var personas = new rPersonas();
            personas.MdiParent = this;
            personas.Show();
        }

        // Consultas
        private void ActividadStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var actividad = new cActividades();
            actividad.MdiParent = this;
            actividad.Show();
        }

        //Personas consulta
        private void PersonaStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var persona = new cPersonas();
            persona.MdiParent = this;
            persona.Show();
        }

        //Usuarios Consultas
        private void UsuarioStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var usuario = new cUsuarios();
            usuario.MdiParent = this;
            usuario.Show();
        }




        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}