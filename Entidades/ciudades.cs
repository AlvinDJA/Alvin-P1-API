using System;
using System.ComponentModel.DataAnnotations;

namespace Alvin_P1_API.Entidades
{
    public class Ciudades
    {
        [Key]
        public int ciudadId { get; set; }
        public string nombre { get; set; }
    }
}
