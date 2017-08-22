using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptumUniversity.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        public string Nome { get; set; }
        public string Turno { get; set; }
        public int DisciplinaID { get; set; }

        public virtual Disciplina Disciplina { get; set; }
    }
}