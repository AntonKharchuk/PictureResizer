
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using PictureResizer;



using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddTransient<Validations>();
        services.AddTransient<IImageResizer, ImageResizer>();
        services.AddTransient<ConsoleResizeDemo>();
    })
    .Build();

var consoleResize = host.Services.GetService<ConsoleResizeDemo>();

consoleResize.Run();



