using AniMa.Forms;
using AniMa.Forms.Interfaces;
using AniMa.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniMa;

static class Program
{
    /// <summary>
    /// アプリケーションのメイン エントリ ポイントです。
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var manager = new AnimeManager();
        var mainForm = new MainForm(manager);

        StartApi(manager, mainForm);
        Application.Run(mainForm);
    }

    private static Task StartApi(AnimeManager manager, IFormRemoteAction formAction)
    {
        var builder = WebApplication.CreateBuilder();

        string corsPolicyName = "myPolicy";

        builder.Services.AddControllers();
        builder.Services.AddSingleton(manager);
        builder.Services.AddSingleton(formAction);

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddCors(option =>
            option.AddPolicy(corsPolicyName, builder => builder
                .AllowAnyOrigin()
                .WithMethods(new string[] { "GET", "POST", "OPTIONS" })
                .AllowAnyHeader()));

        var app = builder.Build();

        app.UseCors(corsPolicyName);

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        return app.RunAsync();
    }
}
