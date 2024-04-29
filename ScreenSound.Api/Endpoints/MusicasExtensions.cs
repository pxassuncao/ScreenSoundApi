﻿using Microsoft.AspNetCore.Mvc;
using ScreenSound.Data;
using ScreenSound.Modelos;

namespace ScreenSound.Api.Endpoints
{
    public static class MusicasExtensions
    {
        public static void AddEndpointMusicas(this WebApplication
            app)
        {
            app.MapGet("/Musicas", ([FromServices]DAL<Musica> dal) =>
            {
                return Results.Ok(dal.Listar());
            });

            app.MapGet("/Musicas/{nome}", ([FromServices] DAL<Musica> dal, string nome) =>
            {
                var musica= dal.RecuperarPor(a=>a.Nome.ToUpper().Equals(nome.ToUpper()));
                if(musica is null )
            {
                return Results.NotFound();
            }
                return Results.Ok(musica);
            });

            app.MapPost("/Musicas", ([FromServices] DAL<Musica> DAL, [FromBody] Musicas musicas) =>
            {
                DAL.Adicionar(musica);
                return Results.Ok();
            });

            app.MapDelete("/Musicas/{id}", ([FromServices] DAL<Musica> dal, int id) =>
            {
                var musica = dal.RecuperarPor(a => a.Id == id);
                if (musica is null)
                {
                    return Results.NotFound();
                }
                dal.Deletar(musica);
                return Results.NoContent();
            });

            app.MapPut("/Musicas", ([FromServices] DAL<Musica> dal,
                [FromBody] Musica musica) =>
            {
                var musicaAAtualizar = dal.RecuperarPor(a=>a.Id == musica.Id);
                if(musicaAAtualizar is null)
                {
                    return Results.NotFound();
                }
                musicaAAtualizar.Nome = musica.Nome;
                musicaAAtualizar.AnoLancamento = musica.AnoLancamento;
                dal.Atualizar(musicaAAtualizar);
                return Results.Ok();
            });
        }
    }
}
