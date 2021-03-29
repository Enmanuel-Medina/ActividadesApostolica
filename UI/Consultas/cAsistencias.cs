using ActividadesApostolica.BLL;
using ActividadesApostolica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadesApostolica.UI.Consultas
{
    public partial class cAsistencias : Form
    {
        List<Asistencias> lista = new List <Asistencias>();

        public cAsistencias()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            //RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();


            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = AsistenciasBLL.GetList(a => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        lista = AsistenciasBLL.GetList(a => a.AsistenciaId == id);
                        break;

                    case 2:
                        //lista = AsistenciasBLL.GetList(a => a.//No se que poner.Contains(CriterioTextBox.Text));
                        break;

                    
                }
                lista = lista.Where(a => a.Fecha.Date >= DesdeDateTimePicker.Value.Date && a.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                lista = AsistenciasBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }

        private void ConsultarButton_Click_1(object sender, EventArgs e)
        {

        }
    } 
}
