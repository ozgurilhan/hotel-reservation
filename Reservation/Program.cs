using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Reservation.Data;
using Reservation.Domain;
using Reservation.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<frmHotels>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IDbContext, DapperContext>();
                    services.AddTransient<IRepository<Customer>, DapperRepository<Customer>>();
                    services.AddTransient<IRepository<Hotel>, DapperRepository<Hotel>>();
                    services.AddTransient<IRepository<Room>, DapperRepository<Room>>();
                    services.AddTransient<IRepository<Booking>, DapperRepository<Booking>>();
                    services.AddTransient<IRepository<BookingDetail>, DapperRepository<BookingDetail>>();
                    services.AddTransient<ICommonService, CommonService>();
                    services.AddTransient<frmHotels>();
                });
        }
    }
}
