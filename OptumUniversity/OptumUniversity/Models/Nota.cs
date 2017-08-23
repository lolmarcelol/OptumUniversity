using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptumUniversity.Models
{
    public enum Notas
    {
        A, B, C, D, E, F
    }

    public class Nota
    {
        public int NotaID { get; set; }
        public int AlunoID { get; set; }
        public int DisciplinaID { get; set; }
        public Notas ? NotaAluno { get; set; }

        public virtual Disciplina Disciplina{ get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}