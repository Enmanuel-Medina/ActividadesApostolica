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
    public partial class cAportes : Form
    {
        List<Aportes> lista = new List<Aportes>();
        public cAportes()
        {
            InitializeComponent();
        }


        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
            if (FechaCheckBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //Aportes
                            lista = AportesBLL.GetList(r => r.AportesId == Utilidades.ToInt(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                        case 1: //Persona
                            lista = AportesBLL.GetList(r => r.Persona == Utilidades.ToInt(CriterioTextBox.Text)); 
                            break;
                    }

                }
                else
                    lista = AportesBLL.GetList(r => (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //Aportes
                            lista = AportesBLL.GetList(r => r.AportesId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //Persona
                            lista = AportesBLL.GetList(r => r.Persona == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBo
                else
                    lista = AportesBLL.GetList(r => true);
            }


            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }

    }
}

