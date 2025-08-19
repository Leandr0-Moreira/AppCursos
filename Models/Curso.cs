using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCursos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public string Categoria { get; set; } = ""; // Ofimática, Programación
        public string Descripcion { get; set; } = "";
        public string ImagenPath { get; set; } = "";
    }
}