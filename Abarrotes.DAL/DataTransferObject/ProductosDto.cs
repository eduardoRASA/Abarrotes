using System;
using System.ComponentModel.DataAnnotations;

namespace Abarrotes.DAL
{
    public class ProductosDto
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string marca { get; set; }
        [Required]
        public string tipo { get; set; }
        [Required]
        public int existencia { get; set; }
        [Required]
        public Double precio { get; set; }
    }
}
