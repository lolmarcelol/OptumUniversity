using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace OptumUniversity.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public virtual ICollection<AD> ADs { get; set; }
    }
}