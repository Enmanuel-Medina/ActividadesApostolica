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
    public partial class rPersonas : Form
    {
        public rPersonas()
        {
            InitializeComponent();
            UsuarioTextBox.Text = Login.Nombre;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            NombresTextBox.Text = String.Empty;
            ApellidosTextBox.Text = String.Empty;
            TelefonoMaskedTextBox.Text = String.Empty;
            CelularMaskedTextBox.Text = String.Empty;
            EmailTextBox.Text = String.Empty;
            DireccionTextBox.Text = String.Empty;
            CedulaMaskedTextBox.Text = String.Empty;

        }

        private Personas LLenaClase()
        {
            Personas persona = new Personas();
            persona.PersonaId = Convert.ToInt32(IdNumericUpDown.Value);
            persona.Nombres = NombresTextBox.Text;
            persona.Apellidos = ApellidosTextBox.Text;
            persona.Telefono = TelefonoMaskedTextBox.Text;
            persona.Celular = CedulaMaskedTextBox.Text;
            persona.Email = EmailTextBox.Text;
            persona.Direccion = DireccionTextBox.Text;
            persona.Cedula = CedulaMaskedTextBox.Text;
            persona.UsuarioId = Login.UsuarioId;

            return persona;
        }

        private void LLenaCampo(Personas persona)
        {
            IdNumericUpDown.Value = persona.PersonaId;
            NombresTextBox.Text = persona.Nombres;
            ApellidosTextBox.Text = persona.Apellidos;
            TelefonoMaskedTextBox.Text = persona.Telefono;
            CelularMaskedTextBox.Text = persona.Celular;
            EmailTextBox.Text = persona.Email;
            DireccionTextBox.Text = persona.Direccion;
            CedulaMaskedTextBox.Text = persona.Cedula;
            UsuarioTextBox.Text = UsuariosBLL.Buscar(persona.UsuarioId).Nombres;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                MyErrorProvider.SetError(NombresTextBox, "El campo Nombres no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ApellidosTextBox.Text))
            {
                MyErrorProvider.SetError(ApellidosTextBox, "El campo Apellidos no puede estar vacio");
                ApellidosTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "El campo Telefono no puede estar vacio");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo Celular no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyErrorProvider.SetError(EmailTextBox, "El campo Email no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                MyErrorProvider.SetError(DireccionTextBox, "El campo Direccion no puede estar vacio");
                DireccionTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo Cedula no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }


            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Personas personas = PersonasBLL.Buscar((int)IdNumericUpDown.Value);
            return (personas != null);
        }

        private void BuscarAsistenciaButton_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();
            personas = PersonasBLL.Buscar(id);

            if (personas != null)
                LLenaCampo(personas);
            else
                MessageBox.Show("Persona no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoAsistenciaButton_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void GuardarAsistenciaButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Personas personas;

            if (!Validar())
                return;
            personas = LLenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = PersonasBLL.Guardar(personas);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Personas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PersonasBLL.Modificar(personas);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarAsistenciaButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();
            if (PersonasBLL.Buscar(id) != null)
            {
                if (PersonasBLL.Eliminar(id))
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

