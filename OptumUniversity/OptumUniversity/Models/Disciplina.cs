using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace OptumUniversity.Models
{
    public class Disciplina
    {
        public int DisciplinaID { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public virtual ICollection<Periodo> Periodos { get; set; }
        public virtual ICollection<Nota> Notas { get; set; }
    }
}