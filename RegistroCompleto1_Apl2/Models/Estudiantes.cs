﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCompleto1_Apl2.Models
{
    public class Estudiantes
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre no puede estar vacio.")]
        [RegularExpression(@"\S(.*)\S", ErrorMessage = "Solo se permiter texto.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo telefono no puede estar vacío.")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$")]
        [MaxLength(10, ErrorMessage = "No puede ingresar mas de 10 digitos.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo cedula no puede estar vacío.")]
        [MinLength(9, ErrorMessage = "El campo cedula debe contener 11 caracteres.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo dirección no puede estar vacía.")]
        public string Direccion { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo Fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime Fecha { get; set; }

        public Estudiantes()
        {
            Id = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Fecha = DateTime.Now;
        }

    }
}
