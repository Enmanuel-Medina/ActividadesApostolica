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
    public partial class rAsistencias : Form
    {
        public List<AsistenciasDetalle> Detalle { get; set; }

        public rAsistencias()
        {
            InitializeComponent();
            this.Detalle = new List<AsistenciasDetalle>();
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            IdNumericUpDown.Value = 0;
            ActividadComboBox.ResetText();
            PersonaComboBox.ResetText();
            FechaDateTimePicker.Value = DateTime.Now;
            PresentesTextBox.Text = "0";
            AusentesTextBox.Text = "0";
            TotalTextBox.Text = "0";

            this.Detalle = new List<AsistenciasDetalle>();
            CargarGrid();
        }

        public Asistencias LlenaClase()
        {
            Asistencias asistencia = new Asistencias();

            asistencia.AsistenciaId = Convert.ToInt32(IdNumericUpDown.Value);
            asistencia.ActividadId = Convert.ToInt32(ActividadComboBox.SelectedIndex);
            asistencia.PersonaId = Convert.ToInt32(PersonaComboBox.SelectedIndex);
            asistencia.Fecha = FechaDateTimePicker.Value;
            asistencia.CantidadPresentes = Convert.ToInt32(PresentesTextBox.Text);
            asistencia.CantidadAusentes = Convert.ToInt32(AusentesTextBox.Text);
            asistencia.AsistenciasDetalle = this.Detalle;

            return asistencia;
        }

        public void LlenaCampo(Asistencias asistencia)
        {
            IdNumericUpDown.Value = asistencia.AsistenciaId;
            ActividadComboBox.SelectedItem = asistencia.ActividadId;
            PersonaComboBox.SelectedItem = asistencia.PersonaId;
            FechaDateTimePicker.Value = asistencia.Fecha;
            PresentesTextBox.Text = Convert.ToString(asistencia.CantidadPresentes);
            AusentesTextBox.Text = Convert.ToString(asistencia.CantidadAusentes);
            TotalTextBox.Text = Convert.ToString(DetalleDataGridView.Rows.Count);

            this.Detalle = asistencia.AsistenciasDetalle;
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Asistencias asistencia = AsistenciasBLL.Buscar((int)IdNumericUpDown.Value);

            return (asistencia != null);
        }

        private void ActividadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboActividades();
        }

        private void PersonaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboPersonas();
        }

        private void LlenarComboActividades()
        {
            var ListaActividades = ActividadesBLL.GetList(p => true);

            ActividadComboBox.DataSource = ListaActividades;
            ActividadComboBox.ValueMember = "ActividadId";
            ActividadComboBox.DisplayMember = "Descripcion";
        }

        private void LlenarComboPersonas()
        {
            var ListaPersonas = PersonasBLL.GetList(p => true);

            PersonaComboBox.DataSource = ListaPersonas;
            PersonaComboBox.ValueMember = "PersonaId";
            PersonaComboBox.DisplayMember = "Nombres";
        }

        private void rAsistencias_Load(object sender, EventArgs e)
        {
            LlenarComboActividades();
            LlenarComboPersonas();
        }

        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.Rows.Clear();
            foreach (var item in this.Detalle)
                DetalleDataGridView.Rows.Add(PersonasBLL.Buscar(item.PersonaId).Nombres, item.Presente, item.Ausente, item.Excusa);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<AsistenciasDetalle>)DetalleDataGridView.DataSource;

            this.Detalle.Add(
                new AsistenciasDetalle(
                    personaId: Convert.ToInt32(ActividadComboBox.SelectedIndex + 1),
                    actividadId: Convert.ToInt32(ActividadComboBox.SelectedIndex + 1),
                    presente: false,
                    ausente: true,
                    excusa: false
                    )
                );

            TotalTextBox.Text = Convert.ToString(DetalleDataGridView.Rows.Count);
            CargarGrid();
        }

        private void RemoverFilaButton_Click(object sender, EventArgs e)
        {
            if ((DetalleDataGridView.Rows.Count > 0) && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;

            int indice = 0;

            //if (!Validar())
            //return;

            foreach (var item in this.Detalle)
            {
                var checkPresente = DetalleDataGridView.Rows[indice].Cells[1].Value;
                var checkAusente = DetalleDataGridView.Rows[indice].Cells[2].Value;
                var checkExcusa = DetalleDataGridView.Rows[indice].Cells[3].Value;

                if ((bool)checkPresente == false && (bool)checkExcusa == false)
                    checkAusente = true;

                var objeto = this.Detalle.FirstOrDefault(x => x.PersonaId == item.PersonaId);

                if (objeto != null)
                {
                    objeto.Presente = (bool)checkPresente;
                    objeto.Ausente = (bool)checkAusente;
                    objeto.Excusa = (bool)checkExcusa;
                }

                indice += 1;
            }

            Asistencias asistencia = LlenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = AsistenciasBLL.Guardar(asistencia);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra la asistencia en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = AsistenciasBLL.Modificar(asistencia);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar la asistencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)IdNumericUpDown.Value;
            MyErrorProvider.Clear();

            if (AsistenciasBLL.Eliminar(id))
            {
                MessageBox.Show("Se  eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show(" No ha sido eliminado", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var asistencia = new Asistencias();
            int id = (int)IdNumericUpDown.Value;

            Limpiar();
            asistencia = AsistenciasBLL.Buscar(id);
            if (asistencia != null)
                LlenaCampo(asistencia);
            else
                MessageBox.Show("No se a podido encontrar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DetalleDataGridView.RowCount != 0)
            {
                if (e.ColumnIndex == 1)
                {
                    var checkAusente = DetalleDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    var checkExcusa = DetalleDataGridView.Rows[e.RowIndex].Cells[3].Value;

                    if ((bool)checkAusente == true || (bool)checkExcusa == true)
                    {
                        DetalleDataGridView.Rows[e.RowIndex].Cells[2].Value = false;
                        DetalleDataGridView.Rows[e.RowIndex].Cells[3].Value = false;
                    }
                }

                if (e.ColumnIndex == 2)
                {
                    var checkAusente = DetalleDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    var checkExcusa = DetalleDataGridView.Rows[e.RowIndex].Cells[3].Value;

                    if ((bool)checkAusente == true || (bool)checkExcusa == true)
                    {
                        DetalleDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
                        DetalleDataGridView.Rows[e.RowIndex].Cells[3].Value = false;
                    }
                }

                if (e.ColumnIndex == 3)
                {
                    var checkAusente = DetalleDataGridView.Rows[e.RowIndex].Cells[1].Value;
                    var checkExcusa = DetalleDataGridView.Rows[e.RowIndex].Cells[2].Value;

                    if ((bool)checkAusente == true || (bool)checkExcusa == true)
                    {
                        DetalleDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
                        DetalleDataGridView.Rows[e.RowIndex].Cells[2].Value = false;
                    }
                }
            }
        }

        private void DetalleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int presente = 0;
            int ausente = 0;
            int excusa = 0;

            foreach (DataGridViewRow row in DetalleDataGridView.Rows)
            {
                if ((Convert.ToBoolean(row.Cells[1].Value) == true))
                    presente += 1;

                if ((Convert.ToBoolean(row.Cells[2].Value) == true))
                    ausente += 1;

                if ((Convert.ToBoolean(row.Cells[3].Value) == true))
                    excusa += 1;
            }

            PresentesTextBox.Text = Convert.ToString(presente);
            AusentesTextBox.Text = Convert.ToString(ausente);
            ExcusasTextBox.Text = Convert.ToString(excusa);
        }
    }
}