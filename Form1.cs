using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Notas.Repositorio;

namespace Notas
{
    public partial class Form1 : Form
    {
        private IRepositorioNotas repository;

        private BindingList<NotasEstudiantes> notas;

        public Form1()
        {
            using (var context = new NotasContext())
            {
                context.Database.EnsureCreated();
            }

            InitializeComponent();
            repository = new RepositorioNotas();
            notas = new BindingList<NotasEstudiantes>();
            dataGridViewNotas.DataSource = notas;
            dateTimePicker1.Value = DateTime.Now;
            CargarNotas();
            dataGridViewNotas.Columns["Id"].ReadOnly = true;
            dataGridViewNotas.Columns["FechaEvaluacion"].ReadOnly = true;
        }

        private void CargarNotas()
        {
            notas.Clear();
            var newNotas = repository.ObtenerNotas();
            foreach (var nota in newNotas)
            {
                notas.Add(nota);
            }
        }



        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNota.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            var nota = new NotasEstudiantes(txtApellidos.Text);
            nota.Apellido = txtApellidos.Text;
            nota.Nombre = txtNombres.Text;
            nota.Notas = double.TryParse(txtNota.Text, out double notaValue) ? notaValue : 0.0;
            nota.FechaEvaluacion = dateTimePicker1.Value;

            var context = new ValidationContext(nota);
            var results = new List<ValidationResult>();
            var isValid = ValidateNota(nota, results);

            if (isValid)
            {
                repository.AgregarNota(nota);
                notas.Add(nota);
                txtApellidos.Clear();
                txtNombres.Clear();
                txtNota.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                ShowErrors(results);
            }

        }

        private void btnRecargar_Click_1(object sender, EventArgs e)
        {
            CargarNotas();
        }

        private void ShowErrors(List<ValidationResult> errors)
        {
            MessageBox.Show(string.Join(Environment.NewLine, errors.ConvertAll(r => "- " + r.ErrorMessage)));
        }

        private void dataGridViewNotas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var oldNotasEstudiantes = dataGridViewNotas.Rows[e.RowIndex].DataBoundItem as NotasEstudiantes;
            var value = e.FormattedValue;

            if (oldNotasEstudiantes == null || value == null)
            {
                e.Cancel = true;
                return;
            }
            var name = dataGridViewNotas.Columns[e.ColumnIndex].Name;
            var notas = new NotasEstudiantes(oldNotasEstudiantes.Id, oldNotasEstudiantes.Nombre, oldNotasEstudiantes.Apellido, oldNotasEstudiantes.Notas, oldNotasEstudiantes.Firma, oldNotasEstudiantes.FechaEvaluacion);
            var results = new List<ValidationResult>();
            if (name == "Nombre")
            {
                notas.Nombre = (string)value;
            }
            else if (name == "Apellido")
            {
                notas.Apellido = (string)value;
            }
            if (name == "Notas")
            {
                notas.Notas = (double)value;
            }
            else if (name == "Firma")
            {
                notas.Firma = (bool)value;
            }
            var isValid = ValidateNota(notas, results);
            if (isValid)
            {
                repository.ActualizarNota(notas);
            }
            else
            {
                ShowErrors(results);
                e.Cancel = true;
            }
        }
        private void dataGridViewNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool ValidateNota(NotasEstudiantes nota, List<ValidationResult> errors)
        {
            var context = new ValidationContext(nota);
            return Validator.TryValidateObject(nota, context, errors, true);
        }
        private void dataGridViewNotas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem is NotasEstudiantes nota)
            {
                dataGridViewNotas!.DataSource = notas;
                var result = MessageBox.Show("¿Está seguro de que desea eliminar esta nota?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    repository.EliminarNota(nota);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
