namespace OptumUniversity.Models
{
    public interface IAD
    {
        Aluno Aluno { get; set; }
        int AlunoID { get; set; }
        Disciplina Disciplina { get; set; }
        int DisciplinaID { get; set; }
        int NotaID { get; set; }
    }
}