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

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
            if (FechaCheckBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //Actividades
                            lista = ActividadesBLL.GetList(r => r.ActividadId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                        case 1: //Descripcion
                            lista = ActividadesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                    }

                }
                else
                    lista = ActividadesBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //AcvidadId
                                lista = ActividadesBLL.GetList(r => r.ActividadId == Utilidades.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //Descripciom
                                lista = ActividadesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBo
                    else
                        lista = ActividadesBLL.GetList(r => true);
                }


                CategoriasConsultaDataGridView.DataSource = null;
                CategoriasConsultaDataGridView.DataSource = lista;
        }
    }
 }



