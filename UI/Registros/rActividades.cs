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

namespace ActividadesApostolica.UI.Registros
{
    public partial class rActividades : Form
    {
        public rActividades()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            NumericUpDown.Value = 0;
            DescriccionTextBox.Text = String.Empty;
        }

        private Actividades LLenaClase()
        {
            Actividades actividad = new Actividades();
            actividad.ActividadId = Convert.ToInt32(NumericUpDown.Value);
            actividad.Descripcion = DescriccionTextBox.Text;
            return actividad;
        }

        private void LLenaCampo(Actividades actividad)
        {
            NumericUpDown.Value = actividad.ActividadId;
            DescriccionTextBox.Text = actividad.Descripcion;

        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(DescriccionTextBox.Text))
            {
                MyErrorProvider.SetError(DescriccionTextBox, "El campo Descripcion no puede estar vacio");
                DescriccionTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Actividades actividad = ActividadesBLL.Buscar((int)NumericUpDown.Value);
            return (actividad != null);
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Actividades actividad = new Actividades();
            int id;
            int.TryParse(NumericUpDown.Text, out id);

            Limpiar();
            actividad = ActividadesBLL.Buscar(id);

            if (actividad != null)
                LLenaCampo(actividad);
            else
                MessageBox.Show("Actividad no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Actividades actividad;

            if (!Validar())
                return;
            actividad = LLenaClase();

            if (NumericUpDown.Value == 0)
                paso = ActividadesBLL.Guardar(actividad);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ActividadesBLL.Modificar(actividad);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(NumericUpDown.Text, out id);

            Limpiar();
            if (ActividadesBLL.Buscar(id) != null)
            {
                if (ActividadesBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No se puede eliminar el usuario que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
