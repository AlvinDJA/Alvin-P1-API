using System;
using System.ComponentModel.DataAnnotations;

namespace Alvin_P1_API.Entidades
{
    public class ciudades
    {
        [Key]
        public int ciudadId { get; set; }
        public string nombre { get; set; }
    }
}
