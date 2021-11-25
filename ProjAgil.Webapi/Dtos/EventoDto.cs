using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjAgil.Webapi.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Tema deve ser preenchido")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Campo deve conter no mínimo 3 caracteres")]
        public string Local { get; set; }

        [Range(2, 120000, ErrorMessage = "Quantidade de pessoas deve ser entre 2 e 120000")]
        public int QtdPessoas { get; set; }
        public DateTime DataEvento { get; set; }
        public string ImagemURL { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Obrigatório um e-mail válido")]
        public string Email { get; set; }
        public List<LoteDto> Lotes { get; set; }
        public List<RedeSocialDto> RedesSociais { get; set; }
        public List<PalestranteDto> Palestrantes { get; set; }
    }
}