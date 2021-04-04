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
    public partial class cColectas : Form
    {
        List<Colectas> lista = new List<Colectas>();
        public cColectas()
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
                            lista = ColectasBLL.GetList(r => r.ColectasId == Utilidades.ToInt(CriterioTextBox.Text) && (r.Vence >= DesdeDateTimePicker.Value && r.Vence <= HastaDateTimePicker.Value));
                            break;
                        case 1: //Persona
                            lista = ColectasBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.Vence >= DesdeDateTimePicker.Value && r.Vence <= HastaDateTimePicker.Value));
                            break;
                    }

                }
                else
                    lista = ColectasBLL.GetList(r => (r.Vence >= DesdeDateTimePicker.Value && r.Vence <= HastaDateTimePicker.Value));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //Aportes
                            lista = ColectasBLL.GetList(r => r.ColectasId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //Persona
                            lista = ColectasBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.Vence >= DesdeDateTimePicker.Value && r.Vence <= HastaDateTimePicker.Value));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBo
                else
                    lista = ColectasBLL.GetList(r => true);
            }


            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;
        }
    }
    
}
