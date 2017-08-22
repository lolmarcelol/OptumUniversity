using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace OptumUniversity.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string Nome { get; set; }
        public int CargaTotal { get; set; }

        public virtual ICollection<DC> DCs { get; set; }
    }
}