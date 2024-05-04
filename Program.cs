using Projeto_Web_Lh_Pets_versão_1;

namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web - LH Pets Versão 1");

        app.UseStaticFiles();
        
        app.MapGet("/index", (HttpContext context) => {
            context.Response.Redirect("index.html", false);
        });

        Banco db=new();

        app.MapGet("/listaClientes", (HttpContext context) => {
            context.Response.WriteAsync(db.GetListaString());
        });

        app.Run();
    }
}
