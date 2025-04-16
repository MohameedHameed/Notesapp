using Microsoft.Extensions.Logging;
using Notesapp.Data;
using Notesapp.Viewmodels;
using Notesapp.Views;

namespace Notesapp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            //Database created
            DBContext dbContext = new DBContext(); 
            dbContext.Database.EnsureCreated();

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<Noteview>();
            builder.Services.AddSingleton<Newviewmodel>();
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
