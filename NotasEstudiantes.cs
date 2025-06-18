using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    [Table("notas")]
    internal class NotasEstudiantes(long id, string nombre, string apellido, double notas, bool firma, DateTime fechaEvaluacion)

    {
        [Column("Id")]
        public long Id { get; set; } = id;
        [Column("Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(1, ErrorMessage = "El nombre debe tener al menos 1 caracter")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; } = nombre;
        [Column("Apellido")]
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MinLength(1, ErrorMessage = "El apellido debe tener al menos 1 caracter")]
        [MaxLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres")]
        public string Apellido { get; set; } = apellido;
        [Column("Notas")]
        public double Notas { get; set; } = notas;
        [Column("Firma")]
        public bool Firma { get; set; } = firma;
        [Column("FechaEvaluacion")]
        public DateTime FechaEvaluacion { get; set; } = fechaEvaluacion;

        public NotasEstudiantes(string nombre) : this(0, nombre, "Apellido", 0.0, false, DateTime.Now.AddDays(1)) { }

    }
}
