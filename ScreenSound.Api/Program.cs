using ScreenSound.Data;
using ScreenSound.Modelos;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>
    (options => options.SerializerOptions.ReferenceHandler
    = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

app.MapGet("/Artistas", () =>
{
    var dal = new DAL<Artista>(new ScreenSoundContext());
    return Results.Ok(dal.Listar());
});

app.MapGet("/Artistas/{nome}", (string nome) =>
{
    if (nome == null)
    {
        // Retornar um resultado de erro, por exemplo, BadRequest
        return Results.BadRequest("O parâmetro 'nome' não pode ser nulo.");
    }
    var dal = new DAL<Artista>(new ScreenSoundContext());
    var artista =  dal.RecuperarPor(a=> a.Nome.ToUpper().Equals(nome.ToUpper()));
    if(artista is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(artista);
});

app.Run();
