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
        List<Asistencias> lista = new List<Asistencias>();

        public cAsistencias()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
            if (FechacCheckBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //AsistenciaId
                            lista = AsistenciasBLL.GetList(r => r.AsistenciaId == Utilidades.ToInt(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                        case 1: //ActividadId
                            lista = AsistenciasBLL.GetList(r => r.ActividadId == Utilidades.ToInt(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                        case 2: //Cantidad presentes
                            lista = AsistenciasBLL.GetList(r => r.CantidadPresentes == Utilidades.ToInt(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                        case 3: //Cantidad ausentes
                            lista = AsistenciasBLL.GetList(r => r.CantidadAusentes == Utilidades.ToInt(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                        case 4: //Cantidad excusas
                            lista = AsistenciasBLL.GetList(r => r.CantidadExcusas == Utilidades.ToInt(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                    }
                }

                else
                    lista = AsistenciasBLL.GetList(r => (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //AsistenciaId
                            lista = AsistenciasBLL.GetList(r => r.AsistenciaId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //ActividadId
                            lista = AsistenciasBLL.GetList(r => r.ActividadId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 2: //Cantidad presentes
                            lista = AsistenciasBLL.GetList(r => r.CantidadPresentes == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 3: //Cantidad ausentes
                            lista = AsistenciasBLL.GetList(r => r.CantidadAusentes == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 4: //Cantidad excusas
                            lista = AsistenciasBLL.GetList(r => r.CantidadExcusas == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBox, se imprimirán todos los categorias
                else
                    lista = AsistenciasBLL.GetList(r => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }
    }
}
