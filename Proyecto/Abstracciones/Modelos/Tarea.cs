using Abstracciones.API;
using Abstracciones.BW;
using Abstracciones.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Abstracciones.Modelos
{
    public class Tarea
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Descripcion { get; set; }


        [Required]
        public Date? FechaInicio { get; set; }

        [Required]
        public Date? FechaFinal { get; set; }

        [Required]
        
        public Guid Asignado { get; set; }

        [Required]
        public Guid Estado { get; set; }

        [Required]
        public Guid Creador { get; set; }
    }
}
