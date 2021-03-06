using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo Titulo é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo Diretor é obrigatório!")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "Genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no minimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
