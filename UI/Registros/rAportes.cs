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
    public partial class rAportes : Form
    {
        public rAportes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            MetaComboBox.ResetText();
            PersonaComboBox.ResetText();
            ContribucionTextBox.Text = String.Empty;
            RestaTextBox.Text = String.Empty;
        }

        private Aportes LLenaClase()
        {
            Aportes aportes = new Aportes();
            aportes.AportesId = Convert.ToInt32(IdNumericUpDown.Value);
         
            aportes.Persona = Convert.ToInt32(PersonaComboBox.SelectedValue);
            aportes.Fecha = FechaDateTimePicker.Value;
            

            return aportes;
        }

        private void LLenaCampo(Aportes aportes)
        {
            IdNumericUpDown.Value = aportes.AportesId;
            
            PersonaComboBox.SelectedValue = aportes.Persona;
            FechaDateTimePicker.Value = aportes.Fecha;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(PersonaComboBox.Text))
            {
                MyErrorProvider.SetError(PersonaComboBox, "El campo Descripcion no puede estar vacio");
                PersonaComboBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Aportes aportes = AportesBLL.Buscar((int)IdNumericUpDown.Value);
            return (aportes != null);
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Aportes aportes = new Aportes();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();
            aportes = AportesBLL.Buscar(id);

            if (aportes != null)
                LLenaCampo(aportes);
            else
                MessageBox.Show("Aportes no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Aportes aportes;

            if (!Validar())
                return;
            aportes = LLenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = AportesBLL.Guardar(aportes);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Aporte ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = AportesBLL.Modificar(aportes);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ElimarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();
            if (AportesBLL.Buscar(id) != null)
            {
                if (AportesBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No se puede eliminar la colecta que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }

}
