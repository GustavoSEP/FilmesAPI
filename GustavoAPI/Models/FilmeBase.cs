using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class FilmeBase
    {
        [Range(1, 600)]
        public int Duracao { get; set; }
    }
}