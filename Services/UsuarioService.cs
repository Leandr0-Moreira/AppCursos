using AppCursos.Models;

namespace AppCursos.Services
{
    public class UsuarioService
    {
        private readonly List<Usuario> _usuarios = new()
        {
            new() { Id=1, Nombre="Ana",   Email="ana@demo.com",   Rol="Admin",  ImagenPath="images/ana.jpg",  Contrasena="1234" },
            new() { Id=2, Nombre="Pedro", Email="pedro@demo.com", Rol="Alumno", ImagenPath="images/pedro.jpg", Contrasena="1234" },
            new() { Id=3, Nombre="Laura", Email="laura@demo.com", Rol="Alumno", ImagenPath="images/laura.jpg", Contrasena="1234" },
        };

        public List<Usuario> ObtenerTodos() =>
            _usuarios.OrderBy(u => u.Id).ToList();

        public Usuario? ObtenerPorId(int id) =>
            _usuarios.FirstOrDefault(u => u.Id == id);

        public void Agregar(Usuario u)
        {
            if (u is null) return;
            u.Id = _usuarios.Count == 0 ? 1 : _usuarios.Max(x => x.Id) + 1;
            _usuarios.Add(u);
        }

        public void Editar(Usuario u)
        {
            if (u is null) return;
            var i = _usuarios.FindIndex(x => x.Id == u.Id);
            if (i >= 0) _usuarios[i] = u;
        }

        public bool Eliminar(int id)
        {
            var u = ObtenerPorId(id);
            return u is not null && _usuarios.Remove(u);
        }

        public Usuario? ValidarCredenciales(string email, string contrasena) =>
            _usuarios.FirstOrDefault(u =>
                u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                u.Contrasena == contrasena);
    }
}