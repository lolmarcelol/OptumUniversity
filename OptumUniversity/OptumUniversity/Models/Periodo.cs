using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptumUniversity.Models
{
    public enum Periodos
    {
        QuatroAnos = 8,
        CincoAnos = 10
    }

    public class Periodo
    {
        public int PeriodoID { get; set; }
        public int DisciplinaID { get; set; }
        public int CursoID { get; set; }
        public Periodos PeriodoCurso { get; set; }

        public virtual Disciplina Disciplina { get; set; }
        public virtual Curso Curso{ get; set; }

    }
}
