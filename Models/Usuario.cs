using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCursos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Email { get; set; } = "";
        public string Rol { get; set; } = "Alumno"; // Alumno/Admin
        public string ImagenPath { get; set; } = "images/ana.jpg";
        public string Contrasena { get; set; } = "";
    }
}
