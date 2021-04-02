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

        private void LLenarComboMeta()
        {
            var ListaColectas = ColectasBLL.GetList(p => true);

            MetaComboBox.DataSource = ListaColectas;
            MetaComboBox.ValueMember = "ColectasId";
            MetaComboBox.DisplayMember = "Descripcion";
        }

        private void LlenarComboPersonas()
        {
            var ListaPersonas = PersonasBLL.GetList(p => true);

            PersonaComboBox.DataSource = ListaPersonas;
            PersonaComboBox.ValueMember = "PersonaId";
            PersonaComboBox.DisplayMember = "Nombres";
        }

        private void rAportes_Load(object sender, EventArgs e)
        {
            Limpiar();
            LlenarComboPersonas();
            LLenarComboMeta();
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
            aportes.ColectaId = Convert.ToInt32(MetaComboBox.SelectedValue);
            aportes.Persona = Convert.ToInt32(PersonaComboBox.SelectedValue);
            aportes.Contribucion = Convert.ToDouble(ContribucionTextBox.Text);
            aportes.Fecha = FechaDateTimePicker.Value;


            return aportes;
        }

        private void LLenaCampo(Aportes aportes)
        {
            IdNumericUpDown.Value = aportes.AportesId;
            MetaComboBox.SelectedValue = aportes.ColectaId;
            PersonaComboBox.SelectedValue = aportes.Persona;
            ContribucionTextBox.Text = aportes.Contribucion.ToString();
            FechaDateTimePicker.Value = aportes.Fecha;
        }

        private bool Validar()
        {
            bool paso = true;
            var colecta = ColectasBLL.Buscar(Convert.ToInt32(MetaComboBox.SelectedValue));


            if (Convert.ToDouble(ContribucionTextBox.Text) + colecta.Logrado > colecta.Meta)
            {
                MyErrorProvider.SetError(ContribucionTextBox, "La contribucion excede la cantiadad faltante");
                ContribucionTextBox.Focus();
                paso = false;
            }

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

        private void ContribucionTextBox_TextChanged(object sender, EventArgs e)
        {
            var colecta = ColectasBLL.Buscar(Convert.ToInt32(MetaComboBox.SelectedValue));
            double contribucion = 0;

            if (!string.IsNullOrWhiteSpace(ContribucionTextBox.Text))
            {
                contribucion = Convert.ToDouble(ContribucionTextBox.Text);
            }

            if (colecta != null)
                RestaTextBox.Text = (colecta.Meta - contribucion).ToString();

        }

        private void MetaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetaComboBox.ResetText();
        }
    } 

}

