using System;
using System.ComponentModel.DataAnnotations;

namespace MvcVehiculos.Models
{
    public class vehiculo
    {

        public int Id { get; set; }

        [Display(Name = "Fecha Inscripción")]
        [DataType(DataType.Date)]
        public DateTime vehiculofechainc { get; set; }

        [Display(Name = "Placa")]
        [Required]
        public string vehiculoplaca { get; set; }

        [Display(Name = "Marca")]
        [Required]
        public string vehiculomarca { get; set; }

        [Display(Name = "No de Puertas")]
        public int vehiculonropuertas { get; set; }
    }
}