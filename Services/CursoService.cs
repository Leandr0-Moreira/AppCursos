using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppCursos.Models;

namespace AppCursos.Services
{
    public class CursoService
    {
        private readonly List<Curso> _cursos = new()
        {
            new Curso{ Id=1, Titulo="Microsoft Word Básico", Categoria="Ofimática", Descripcion="Formato de texto, estilos y plantillas.", ImagenPath="images/word.jpg"},
            new Curso{ Id=2, Titulo="Microsoft Excel Inicial", Categoria="Ofimática", Descripcion="Fórmulas, funciones y gráficos.", ImagenPath="images/excel.jpg"},
            new Curso{ Id=3, Titulo="PowerPoint Efectivo", Categoria="Ofimática", Descripcion="Presentaciones con impacto.", ImagenPath="images/powerpoint.jpg"},

            new Curso{ Id=4, Titulo="Programación C# Básico", Categoria="Programación", Descripcion="Sintaxis, tipos, condicionales, colecciones.", ImagenPath="images/csharp.jpg"},
            new Curso{ Id=5, Titulo="JavaScript", Categoria="Programación", Descripcion="Variables, funciones y DOM.", ImagenPath="images/javascript.jpg"},
            new Curso{ Id=6, Titulo="HTML y CSS desde Cero", Categoria="Programación", Descripcion="Estructura y estilos web.", ImagenPath="images/html_css.jpg"},
            new Curso{ Id=7, Titulo="Python", Categoria="Programación", Descripcion="Manejo de archivos, módulos y excepciones.", ImagenPath="images/python.jpg"},
            new Curso{ Id=8, Titulo="Java", Categoria="Programación", Descripcion="POO, colecciones y hilos.", ImagenPath="images/java.jpg"},

        };

        public List<Curso> ObtenerTodos() => _cursos;
        public Curso? ObtenerPorId(int id) => _cursos.FirstOrDefault(c => c.Id == id);

        public void Agregar(Curso c)
        {
            c.Id = (_cursos.Count == 0 ? 1 : _cursos.Max(x => x.Id) + 1);
            _cursos.Add(c);
        }
        public void Editar(Curso c)
        {
            var i = _cursos.FindIndex(x => x.Id == c.Id);
            if (i >= 0) _cursos[i] = c;
        }
        public void Eliminar(int id) => _cursos.RemoveAll(x => x.Id == id);
    }
}