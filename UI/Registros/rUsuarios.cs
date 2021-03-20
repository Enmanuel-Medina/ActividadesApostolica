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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
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
            NombreUsuarioTextBox.Text = String.Empty;
            ClaveUsuarioTextBox.Text = String.Empty;
            ConfirmarClaveTextBox.Text = String.Empty;
            TipoUsuariosComboBox.Text = String.Empty;
        }

        private Usuarios LLenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(IdNumericUpDown.Value);
            usuario.Nombres = NombresTextBox.Text;
            usuario.Apellidos = ApellidosTextBox.Text;
            usuario.Telefono = TelefonoMaskedTextBox.Text;
            usuario.Celular = CelularMaskedTextBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.Direccion = DireccionTextBox.Text;
            usuario.NombreUsuario = NombreUsuarioTextBox.Text;
            usuario.ClaveUsuario = ClaveUsuarioTextBox.Text;
            usuario.ClaveConfirmada = ConfirmarClaveTextBox.Text;
            usuario.TipoUsuario = TipoUsuariosComboBox.Text;
            
            return usuario;
        }

        private void LLenaCampo(Usuarios usuario)
        {
            IdNumericUpDown.Value = usuario.UsuarioId;
            NombresTextBox.Text = usuario.Nombres;
            ApellidosTextBox.Text = usuario.Apellidos;
            TelefonoMaskedTextBox.Text = usuario.Telefono;
            CelularMaskedTextBox.Text = usuario.Celular;
            EmailTextBox.Text = usuario.Email;
            DireccionTextBox.Text = usuario.Direccion;
            NombreUsuarioTextBox.Text = usuario.NombreUsuario;
            ClaveUsuarioTextBox.Text = usuario.ClaveUsuario;
            ConfirmarClaveTextBox.Text = usuario.ClaveConfirmada;
            TipoUsuariosComboBox.Text = usuario.TipoUsuario;
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

            if (ConfirmarClaveTextBox != ClaveUsuarioTextBox)
            {
                MyErrorProvider.SetError(ConfirmarClaveTextBox, "Las claves no coinciden");
                ConfirmarClaveTextBox.Focus();
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuario = UsuariosBLL.Buscar((int)IdNumericUpDown.Value);
            return (usuario != null);
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();
            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
                LLenaCampo(usuario);
            else
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Usuarios usuario;

            if (!Validar())
                return;
            usuario = LLenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = UsuariosBLL.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuario);
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
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();
            if (UsuariosBLL.Buscar(id) != null)
            {
                if (UsuariosBLL.Eliminar(id))
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

