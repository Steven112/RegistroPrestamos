using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea3RegPrestamo.Models
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage ="Es obligatorio llenar el campo")]
        public string Normbre { get; set; }

        [Required(ErrorMessage = "Es obligatorio llenar este campo")]
        public string Telofono { get; set; }

        [Required(ErrorMessage = "Es obligatorio llenar este campo")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Es obligatorio llenar este campo")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una fecha diferente")]
        public DateTime FechaNacimiento { get; set; }
        public decimal Balance { get; set; }

        public Persona()
        {
            PersonaId = 0;
            Normbre = string.Empty;
            Telofono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;
            Balance = 0;
        }
    }


}
