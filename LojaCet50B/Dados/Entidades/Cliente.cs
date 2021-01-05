using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCet50B.Dados.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }


        public string Nome { get; set; }

        public string Apelido { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }


        [Display(Name = "NIF")]
        public string Nif { get; set; }


        [Display(Name = "Telefone")]
        public string Telefone { get; set; }


        [Display(Name = "Reside em Portugal")]
        public bool Residencia { get; set; }
    }
}
