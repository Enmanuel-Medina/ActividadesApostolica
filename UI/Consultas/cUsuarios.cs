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
    public partial class cUsuarios : Form
    {
        List<Usuarios> lista = new List<Usuarios>();

        public cUsuarios()
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
                        case 0: //Usuarios
                            lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                        case 1: //Nombres
                            lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
                            break;
                    }

                }
                else
                    lista = UsuariosBLL.GetList(r => (r.Fecha >= DesdeDateTimePicker.Value && r.Fecha <= HastaDateTimePicker.Value));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //Usuarios
                            lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //Nombre
                            lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBo
                else
                    lista = UsuariosBLL.GetList(r => true);
            }


            UsuariosConsultaDataGridView.DataSource = null;
            UsuariosConsultaDataGridView.DataSource = lista;
        }
    }
}
 
