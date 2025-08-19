using Microsoft.Extensions.Logging;
using AppCursos.Services;


namespace AppCursos
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddSingleton<UsuarioService>();
            builder.Services.AddSingleton<CursoService>();
            builder.Services.AddSingleton<SesionService>();





#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        
    
    
    
    }
   
    

}
