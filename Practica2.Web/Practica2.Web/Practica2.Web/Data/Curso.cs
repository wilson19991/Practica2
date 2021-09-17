using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2.Web.Data
{
    public class Curso 

    {
        public int Id { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe contener {1} caracteres de longitud. ")]
        //[Required]

        public string Descripcion { get; set; }

        [Display(Name = "Asignado")]
        //[Required]
        public bool Asignado { get; set; }

        [Display(Name = "Activo")]
        //[Required]
        public bool Activo { get; set; }

        public Ciudad Ciudad { get; set; } //Llaves foraneas
    }
}
