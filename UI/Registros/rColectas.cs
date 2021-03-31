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
    public partial class rColectas : Form
    {
        public rColectas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = String.Empty;
            MetaTextBox.Text = String.Empty;
            LogradoTextBox.Text = String.Empty;
        }

        private Colectas LLenaClase()
        {
            Colectas colectas = new Colectas();
            colectas.ColectasId = Convert.ToInt32(IdNumericUpDown.Value);
            colectas.Descripcion = DescripcionTextBox.Text;
            colectas.Meta = Convert.ToDouble(MetaTextBox.Text);
            colectas.Logrado = Convert.ToDouble(LogradoTextBox.Text);
          
            return colectas;
        }

        private void LLenaCampo(Colectas colectas)
        {
            IdNumericUpDown.Value = colectas.ColectasId;
            DescripcionTextBox.Text = colectas.Descripcion;

        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo Descripcion no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Colectas colectas = ColectasBLL.Buscar((int)IdNumericUpDown.Value);
            return (colectas != null);
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Colectas colectas = new Colectas();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();
            colectas = ColectasBLL.Buscar(id);

            if (colectas != null)
                LLenaCampo(colectas);
            else
                MessageBox.Show("Colectas no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {

            bool paso = false;
            Colectas colectas;

            if (!Validar())
                return;
            colectas = LLenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = ColectasBLL.Guardar(colectas);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ColectasBLL.Modificar(colectas);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();
            if (ColectasBLL.Buscar(id) != null)
            {
                if (ColectasBLL.Eliminar(id))
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

