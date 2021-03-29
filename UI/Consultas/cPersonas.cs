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
    public partial class cPersonas : Form
    {
        List<Personas> lista = new List<Personas>();
        public cPersonas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
            if (UsarCheckBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //CategoriaId
                            lista = PersonasBLL.GetList(r => r.PersonaId == Utilidades.ToInt(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                        case 1: //Nombre
                            lista = PersonasBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                    }
                }
               
                else
                    lista = PersonasBLL.GetList(r => (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //PersonaId
                            lista = PersonasBLL.GetList(r => r.PersonaId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //Nombre
                            lista = PersonasBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBox, se imprimirán todos los categorias
                else
                    lista = PersonasBLL.GetList(r => true);
            }


            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }
    }
}

