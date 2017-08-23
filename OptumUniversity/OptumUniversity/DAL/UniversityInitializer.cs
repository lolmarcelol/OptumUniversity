using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OptumUniversity.Models;


namespace OptumUniversity.DAL
{
    public class UniversityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var alunos = new List<Aluno>
            {
                new Aluno{Nome="Nicolas Troles", DataNascimento=DateTime.Parse("2000-02-02")},
                new Aluno{Nome="Pedro Paulo", DataNascimento=DateTime.Parse("2000-02-02")},
                new Aluno{Nome="Antonio Nunes", DataNascimento=DateTime.Parse("2000-02-02")},
                new Aluno{Nome="Joao Paulo", DataNascimento=DateTime.Parse("2000-02-02")},
                new Aluno{Nome="Marisa Monte", DataNascimento=DateTime.Parse("2020-02-02")},
                new Aluno{Nome="Tim Maia", DataNascimento=DateTime.Parse("2010-02-02")},
                new Aluno{Nome="Marcelo D2", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Mateus de Jesus", DataNascimento=DateTime.Parse("2030-02-02")}
            };
            alunos.ForEach(s => context.Alunos.Add(s));
            context.Alunos.Add(new Aluno { Nome = "Vini Cios", DataNascimento = DateTime.Parse("2000-02-02") });
            context.SaveChanges();

            var cursos = new List<Curso> {
                new Curso {Nome="Ciência da Computação", CargaTotal=123 },
                new Curso {Nome="Sistemas de Informação", CargaTotal=23 },
                new Curso {Nome="TI", CargaTotal=123 },
                new Curso {Nome="Analise de Sistemas", CargaTotal=321 }
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();


            var disciplinas = new List<Disciplina> {
                new Disciplina {Nome="Logica Matematica", CargaHoraria=123 },
                new Disciplina {Nome="Arquitetura de Computadores", CargaHoraria=23 },
                new Disciplina {Nome="Historia", CargaHoraria=123 },
                new Disciplina {Nome="LPTA", CargaHoraria=321 },
                new Disciplina {Nome="POO", CargaHoraria=122},
                new Disciplina {Nome="Banco de Dados", CargaHoraria=110}
            };
            disciplinas.ForEach(s => context.Disciplinas.Add(s));
            context.SaveChanges();

            var notas = new List<Nota>
            {
                new Nota {AlunoID=1,DisciplinaID=1, NotaAluno = Notas.B},
                new Nota {AlunoID=2,DisciplinaID=2, NotaAluno = Notas.C},
                new Nota {AlunoID=3,DisciplinaID=3, NotaAluno = Notas.A},
                new Nota {AlunoID=4,DisciplinaID=1, NotaAluno = Notas.E},
                new Nota {AlunoID=5,DisciplinaID=2, NotaAluno = Notas.D},
                new Nota {AlunoID=6,DisciplinaID=3, NotaAluno = Notas.F}
            };

            notas.ForEach(s => context.Notas.Add(s));
            context.SaveChanges();

            var periodos = new List<Periodo>
            {
                new Periodo {CursoID=1,DisciplinaID=1, PeriodoCurso = Periodos.CincoAnos},
                new Periodo {CursoID=1,DisciplinaID=2, PeriodoCurso = Periodos.CincoAnos},
                new Periodo {CursoID=1,DisciplinaID=3, PeriodoCurso = Periodos.CincoAnos},
                new Periodo {CursoID=2,DisciplinaID=1, PeriodoCurso = Periodos.QuatroAnos},
                new Periodo {CursoID=2,DisciplinaID=2, PeriodoCurso = Periodos.QuatroAnos},
                new Periodo {CursoID=2,DisciplinaID=3, PeriodoCurso = Periodos.QuatroAnos}
            };
            periodos.ForEach(s => context.Periodos.Add(s));
            context.SaveChanges();

            var professores = new List<Professor>
            {
                new Professor {Nome="Pafuncio Rodrigo", Turno= "Noturno", DisciplinaID = 2}
            };
            professores.ForEach(s => context.Professores.Add(s));
            context.SaveChanges();
        }
    }
}