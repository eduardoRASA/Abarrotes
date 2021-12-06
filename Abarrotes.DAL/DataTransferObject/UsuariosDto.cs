using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.DAL
{
    public class UsuariosDto
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido1 { get; set; }
        [Required]
        public string apellido2 { get; set; }
        [Required]
        public string correo { get; set; }
        public string celular { get; set; }
        [Required]
        public int tipo { get; set; }
    }
}
