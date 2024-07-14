namespace FSModToolsManager;
using FSModToolsManager.Controls;
using FSModToolsManager.Services;
using Microsoft.Extensions.DependencyInjection;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        

        var services = new ServiceCollection();
        services.AddSingleton<Utils.Utils>();
        services.AddSingleton<IConfig, Config>();
        services.AddTransient<FormMain>();
        var build = services.BuildServiceProvider();
        Application.Run(build.GetRequiredService<FormMain>());
    }
}