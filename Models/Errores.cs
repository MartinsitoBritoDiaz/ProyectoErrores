using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoErrorBlazor.Models
{
    public class Errores
    {
        [Key]
        public int errorId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir la fecha")]
        public DateTime fecha { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir el hallazgo")]
        public string hallazgo { get; set; }

        [Url(ErrorMessage ="Debe introducir una ruta valida")]
        [Required(ErrorMessage = "Es obligatorio introducir la ruta")]
        public string ruta { get; set; }

        [Range(minimum:1,maximum:10,ErrorMessage ="Debe introducir una importancia entre 1 y 10")]
        [Required(ErrorMessage = "Es obligatorio introducir la importancia")]
        public int importancia { get; set; }
    }
}
