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

namespace ActividadesApostolica
{
    public partial class Login : Form
    {
        List<Usuarios> lista = new List<Usuarios>();
        public static int UsuarioId;

        private bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo Usuario no puede estar vacio.");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContrasenaTextBox.Text))
            {
                MyErrorProvider.SetError(ContrasenaTextBox, "El campo Contrasena no puede estar vacio.");
                ContrasenaTextBox.Focus();
                paso = false;
            }
            return paso;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void IniciarSesionButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            MainForms main = new MainForms();
            lista = UsuariosBLL.GetList(p => true);

            bool paso = false;
            foreach (var item in lista)
            {
                if ((item.NombreUsuario == UsuarioTextBox.Text) && (item.ClaveUsuario == ContrasenaTextBox.Text))
                {
                    UsuarioId = item.UsuarioId;
                    main.Show();
                    paso = true;
                    break;
                }
            }
            if (paso == false)
            {
                MessageBox.Show("Usuario o Contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsuarioTextBox.Text = string.Empty;
                UsuarioTextBox.Focus();
                ContrasenaTextBox.Text = string.Empty;
            }
        }
    }
}