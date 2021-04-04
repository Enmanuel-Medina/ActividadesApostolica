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

            //Colectas
            this.ColectasStripMenuItem.Click += new EventHandler(this.ColectasStripMenuItem_ItemCliked);

            //Aportes
            this.AportesStripMenuItem.Click += new EventHandler(this.AportesStripMenuItem_ItemCliked);

           //---------------------------------------------------------------------------------------------//
            //Cosultas
            this.ActividadStripMenuItem.Click += new EventHandler(this.ActividadStripMenuItem_ItemCliked);

            //Personas Consulta
            this.PersonaStripMenuItem.Click += new EventHandler(this.PersonaStripMenuItem_ItemCliked );

            //Asistencias Consulta
            this.cAsistenciasStripMenuItem.Click += new EventHandler(cAsistenciasStripMenuItem_ItemCliked);

            //Usuarios Consulta
            this.UsuarioStripMenuItem.Click += new EventHandler(this.UsuarioStripMenuItem_ItemCliked);

            //Aportes Consultas
            this.cAportesStripMenuItem.Click += new EventHandler(this.cAportesStripMenuItem_ItemCliked);

            //Colectas Consulta
            this.cColectasStripMenuItem.Click += new EventHandler(this.cColectasStripMenuItem_ItemCliked);

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

        private void ColectasStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var colectas = new rColectas();
            colectas.MdiParent = this;
            colectas.Show();
        }

        private void AportesStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var aportes = new rAportes();
            aportes.MdiParent = this;
            aportes.Show();
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

        // Asistencias Consulta
        private void cAsistenciasStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var asistencias = new cAsistencias();
            asistencias.MdiParent = this;
            asistencias.Show();
        }

        //Aportes consulta
        private void cAportesStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var aportes = new cAportes();
            aportes.MdiParent = this;
            aportes.Show();
        }

        //Colecta Consulta
        private void cColectasStripMenuItem_ItemCliked(object sender, EventArgs e)
        {
            var colectas = new cColectas();
            colectas.MdiParent = this;
            colectas.Show();
        }





        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}