using System;
using AppCursos.Models;

namespace AppCursos.Services
{
    public class SesionService
    {
        public Usuario? UsuarioActual { get; private set; }
        public bool EstaLogueado => UsuarioActual is not null;
        public bool EsInvitado { get; private set; }

        // Helpers de rol
        public string Rol => UsuarioActual?.Rol ?? (EsInvitado ? "Invitado" : "");
        public bool EsAdmin => string.Equals(UsuarioActual?.Rol, "Admin", StringComparison.OrdinalIgnoreCase);
        public bool EsAlumno => string.Equals(UsuarioActual?.Rol, "Alumno", StringComparison.OrdinalIgnoreCase);

        public void Login(Usuario u)
        {
            UsuarioActual = u;
            EsInvitado = false;
        }

        public void EntrarComoInvitado()
        {
            UsuarioActual = null;
            EsInvitado = true;
        }

        public void Logout()
        {
            UsuarioActual = null;
            EsInvitado = false;
        }
    }
}