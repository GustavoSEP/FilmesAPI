using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GustavoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {


        private static List<Filme> filmes = new List<Filme>();

        public void AdicionaFilme(Filme filme)
        {
            filmes.Add(filme);

            Console.WriteLine(filme.Titulo);

        }
    }
}