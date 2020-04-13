// Hiago Domingos de Oliveira
// Prova de capacitação NESS


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testeNess.Models
{
    public class Paciente
    {
        [Display(Name = "Id")]
        public int IdPaciente {get; set;}
        [Required(ErrorMessage = "Favor informar o 'NOME' do Paciente")]
        public string NomePaciente {get; set;}

        [Required(ErrorMessage = "Favor informar a 'DATA DE NASCIMENTO' do Paciente")]
        public string DataNascimento { get; set;}
        
        [Required(ErrorMessage = "Favor informar 'ENDEREÇO' do Paciente")]
        public string Endereco { get; set;}
        
        [Required(ErrorMessage = "Favor informar 'TELEFONE' do Paciente")]
        public string Telefone { get; set;}
        
        [Required(ErrorMessage = "Favor informar 'CELULAR' do Paciente")]
        public string Celular { get; set; }
        
        [Required(ErrorMessage = "Favor informar 'EMAIL' do Paciente")]
        public string Email { get; set; }

        public string DataConsulta { get; set; }

    }
}