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
           
        }



        private void UsuariosStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuario = new rUsuarios();
            usuario.MdiParent = this;
            usuario.Show();
        }



        private void ActividadesStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var actividad = new rActividades();
            actividad.MdiParent = this;
            actividad.Show();
        }

        private void AsistenciaStripMenuItem_ItemClicked(object sender, EventHandler e)
        {
            var asistencias = new rActividades();
            asistencias.MdiParent = this;
            asistencias.Show();
        }



        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {



        }
    }
}