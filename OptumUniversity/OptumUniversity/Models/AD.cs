using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptumUniversity.Models
{

    public class AD
    {
        public int ADID { get; set; }
        public int AlunoID { get; set; }
        public int DisciplinaID { get; set; }

        public virtual Disciplina Disciplina{ get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}