using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Repository;
using WindowsFormsApp1.Service.PersonService;
using FormUI.Data;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public static class Program
    {
        public static IConfigurationRoot Configuration { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var services = new ServiceCollection();
            RegisterServie(services);

            //zbudowanie dostawcy
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                mainForm.Show();
                Application.Run();
        }

        private static void RegisterServie(IServiceCollection services)
        {
            // Dodanie ustawienie domy�lnej �cie�ki i zarejestroanie user secrets�w
            Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddUserSecrets(typeof(Program).Assembly)
            .Build();

            // wstrzykni�cie zale�no�ci DI
            services.AddSingleton<MainForm>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IPersonService,PersonService>();
            services.AddDbContext<SimpleWarehousContext>(option => option.UseSqlServer(Configuration.GetConnectionString("SimpleWarehous")));
        }
    }
}
