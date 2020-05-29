using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea3RegPrestamo.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una fecha diferente")]
        public DateTime FechaPrestamo { get; set; }
        [Required(ErrorMessage = "Es obligatorio seleccionar una persona")]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "Es obligatorio llenar este campo")]
        public string Concepto { get; set; }
        [Range(minimum: 1, maximum: 999999999, ErrorMessage = "Agregue un monto")]
        public decimal Monto { get; set; }
        public decimal Balances { get; set; }

        public Prestamos()
        {
            PrestamoId =0;
            FechaPrestamo = DateTime.Now;
            PersonaId = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balances = 0;
        }
    }
}
