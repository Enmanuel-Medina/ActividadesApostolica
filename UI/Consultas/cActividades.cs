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
    public partial class cActividades : Form
    {
        List<Actividades> lista = new List<Actividades>();
        public cActividades()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
            if (FechaCheckBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //CategoriaId
                            lista = ActividadesBLL.GetList(r => r.ActividadId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                        case 1: //NombreCategoria
                            lista = ActividadesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBox, se imprimirán todos los categorias
                else
                    lista = ActividadesBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //CategoriaId
                            lista = ActividadesBLL.GetList(r => r.ActividadId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //NombreCategoria
                            lista = ActividadesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBox, se imprimirán todos los categorias
                else
                    lista = ActividadesBLL.GetList(r => true);
            }


            CategoriasConsultaDataGridView.DataSource = null;
            CategoriasConsultaDataGridView.DataSource = lista;
        }

        private void DesdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

