# 📚 AppCursos

Aplicación **.NET MAUI Blazor Hybrid** para la gestión de cursos digitales.  
Este proyecto fue desarrollado como un trabajo práctico, implementando CRUD de usuarios, sistema de login con roles y vistas adaptadas a distintos perfiles.

---

## ✨ Características principales

- **Login y Roles**
  - Inicio de sesión básico con validación de credenciales.
  - Roles diferenciados (Admin, Usuario).
  - Restricciones de acceso por rol (solo Admin puede gestionar usuarios).

- **Gestión de Usuarios**
  - Crear, editar, eliminar y listar usuarios.
  - Visualización de detalles individuales.
  - Confirmación antes de eliminar.
  - Avatares con placeholder automático.

- **UI y Estilo**
  - Tablas responsivas con Bootstrap.
  - Botones agrupados con iconos (`bootstrap-icons`).
  - Layout adaptado a dispositivos móviles.
  - Logo y página de login personalizados.

---

## 🛠️ Tecnologías utilizadas

- [.NET MAUI](https://learn.microsoft.com/dotnet/maui) – interfaz multiplataforma
- [Blazor Hybrid](https://learn.microsoft.com/aspnet/core/blazor/hybrid) – componentes web embebidos
- [Bootstrap 5](https://getbootstrap.com/) – estilos y responsive design
- [C#](https://learn.microsoft.com/dotnet/csharp/) – lenguaje principal
- [Entity Framework Core (opcional)] – para persistencia de datos

---

## 📂 Estructura del proyecto
AppCursos/
* Components/ → Componentes reutilizables
* Models/ → Clases de dominio (Usuario, etc.)
* Pages/ → Vistas Razor (Login, Usuarios, etc.)
* Services/ → Servicios de negocio (Sesión, Usuarios)
* Shared/ → Layout y componentes compartidos
* wwwroot/ → Recursos estáticos (css, imágenes, logo)
* AppCursos.sln → Solución principal
* MauiProgram.cs → Configuración inicial de la app

👨‍💻 Autor

Leandro Moreira

📄 Licencia

Proyecto académico sin fines comerciales.
Distribuido bajo licencia MIT(LICENSE).
