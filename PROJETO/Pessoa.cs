using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO
{
    public class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Pessoa(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }
        
        private Pessoa () { }
    }
}
