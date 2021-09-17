using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2.Web.Data
{
    public class Ciudad 

    {
        public int Id { get; set; }

        [Display(Name = "Ciudad")]
        [MaxLength(30, ErrorMessage = "El campo {0} debe contener {1} caracteres de longitud. ")]
        [Required(ErrorMessage ="Tipo de Departamento es Requerido")]

        public string Dpto { get; set; }

        [Display(Name = "Correo Electronico")]
        [MaxLength(60, ErrorMessage = "El campo {0} debe contener {1} caracteres de longitud. ")]
        [EmailAddress(ErrorMessage = "Correo Electronico Incorrecto")]

        public string EMAIL { get; set; }

        [Display(Name = "Fecha registro")]
        [Required(ErrorMessage = "Fecha registro es Requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true),]

        public DateTime Fecha_Reg { get; set; }

        [Display(Name = "Activo")]
        [Required]
        public bool Activo { get; set; }
    }
}