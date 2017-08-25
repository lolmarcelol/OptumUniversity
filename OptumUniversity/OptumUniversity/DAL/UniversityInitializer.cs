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
                new Aluno{Nome="Camila Santin", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Neto Santos", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Felipe Noronha", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Marcelo Assis", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Katheryne Graf", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Marcelo Mikosz", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Murilo Erhardt", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Joel Santana", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Renato Gaúcho", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Lucas Paulo", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Claudio Silva", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Rosi Rodrigues", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Alexis Texas", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Mano Menezes", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Goku Silveira", DataNascimento=DateTime.Parse("2030-02-02")},
                new Aluno{Nome="Victor Belfort", DataNascimento=DateTime.Parse("2030-02-02")}

            };
            alunos.ForEach(s => context.Alunos.Add(s));
            context.Alunos.Add(new Aluno { Nome = "Vini Cios", DataNascimento = DateTime.Parse("2000-02-02") });
            context.SaveChanges();

            var cursos = new List<Curso> {
                new Curso {Nome="Ciência da Computação", CargaTotal=123 },
                new Curso {Nome="Sistemas de Informação", CargaTotal=123 },
                new Curso {Nome="Análise e Desenvolvimento de Sistemas",CargaTotal=123 },
                new Curso {Nome="Comércio Exterior", CargaTotal=321 },
                new Curso {Nome="Engenharia Mecânica", CargaTotal=321 },
                new Curso {Nome="Engenharia Civil", CargaTotal=123 },
                new Curso {Nome="Nanotecnologia", CargaTotal=123 },
                new Curso {Nome="Física", CargaTotal=321 },
                new Curso {Nome="Ciências Contábeis", CargaTotal=321 },
                new Curso {Nome="Engenharia Aeroespacial", CargaTotal=321 },
                new Curso {Nome="Química", CargaTotal=123 },
                new Curso {Nome="Matemática", CargaTotal=321 },
                new Curso {Nome="Engenharia de Software", CargaTotal=321},
                new Curso {Nome="Bioengenharia", CargaTotal=123}

            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();




            var disciplinas = new List<Disciplina> {
                new Disciplina {Nome="Arquitetura de Computadores", CargaHoraria=123,Periodo=1, CursoID = 1 },
                new Disciplina {Nome="Lógica Matemática", CargaHoraria=123,Periodo=3, CursoID = 2 },
                new Disciplina {Nome="Programação Orientada a Objetos", CargaHoraria=123,Periodo=3, CursoID = 3},
                new Disciplina {Nome="Negócios Internacionais", CargaHoraria=321,Periodo=10, CursoID = 4 },
                new Disciplina {Nome="Mecânica dos Fluídos", CargaHoraria=321,Periodo=5, CursoID = 5},
                new Disciplina {Nome="Cálculo 10 ", CargaHoraria=123,Periodo=6, CursoID = 6},
                new Disciplina {Nome="Mecânica da Partícula", CargaHoraria=123,Periodo=2, CursoID = 7},
                new Disciplina {Nome="Física Quântica", CargaHoraria=321,Periodo=8, CursoID = 8},
                new Disciplina {Nome="Organização Operacional", CargaHoraria=321,Periodo=1, CursoID = 9},
                new Disciplina {Nome="Projetos de Máquinas", CargaHoraria=321,Periodo=2, CursoID = 10},
                new Disciplina {Nome="Micro Gases", CargaHoraria=123,Periodo=3, CursoID = 11},
                new Disciplina {Nome="Tópicos de Matemática", CargaHoraria=321,Periodo=3, CursoID = 12},
                new Disciplina {Nome="Análise de Requisitos", CargaHoraria=321,Periodo=8, CursoID = 13},
                new Disciplina {Nome="Transferência de Calor", CargaHoraria=123,Periodo=4, CursoID = 14}

            };
            disciplinas.ForEach(s => context.Disciplinas.Add(s));
            context.SaveChanges();






            var notas = new List<Nota>
            {
                new Nota {AlunoID=1,DisciplinaID=1, NotaAluno = Notas.A},
                new Nota {AlunoID=2,DisciplinaID=1, NotaAluno = Notas.B},
                new Nota {AlunoID=3,DisciplinaID=2, NotaAluno = Notas.C},
                new Nota {AlunoID=4,DisciplinaID=2, NotaAluno = Notas.F},
                new Nota {AlunoID=5,DisciplinaID=3, NotaAluno = Notas.A},
                new Nota {AlunoID=6,DisciplinaID=4, NotaAluno = Notas.A},
                new Nota {AlunoID=7,DisciplinaID=5, NotaAluno = Notas.A},
                new Nota {AlunoID=8,DisciplinaID=6, NotaAluno = Notas.C},
                new Nota {AlunoID=9,DisciplinaID=7, NotaAluno = Notas.B},
                new Nota {AlunoID=10,DisciplinaID=8, NotaAluno = Notas.D},
                new Nota {AlunoID=11,DisciplinaID=9, NotaAluno = Notas.A},
                new Nota {AlunoID=12,DisciplinaID=10, NotaAluno = Notas.E},
                new Nota {AlunoID=13,DisciplinaID=11, NotaAluno = Notas.B},
                new Nota {AlunoID=14,DisciplinaID=12, NotaAluno = Notas.B},
                new Nota {AlunoID=15,DisciplinaID=13, NotaAluno = Notas.B},
                new Nota {AlunoID=16,DisciplinaID=14, NotaAluno = Notas.A},
                new Nota {AlunoID=17,DisciplinaID=11, NotaAluno = Notas.C},
                new Nota {AlunoID=18,DisciplinaID=1, NotaAluno = Notas.F},
                new Nota {AlunoID=19,DisciplinaID=7, NotaAluno = Notas.F},
                new Nota {AlunoID=20,DisciplinaID=8, NotaAluno = Notas.A},
                new Nota {AlunoID=21,DisciplinaID=12, NotaAluno = Notas.C},
                new Nota {AlunoID=22,DisciplinaID=14, NotaAluno = Notas.B},
                new Nota {AlunoID=23,DisciplinaID=10, NotaAluno = Notas.A},

            };

            notas.ForEach(s => context.Notas.Add(s));
            context.SaveChanges();

            var professores = new List<Professor>
            {
                new Professor {Nome="Pafuncio Rodrigo", Turno= "Noite", DisciplinaID = 1},
                new Professor {Nome="Rogério Pereira", Turno= "Manhã", DisciplinaID = 2},
                new Professor {Nome="Márcio Silva", Turno= "Noite", DisciplinaID = 3},
                new Professor {Nome="Fernanda Heinsten", Turno= "Manhã", DisciplinaID = 4},
                new Professor {Nome="Vagner Humberto", Turno= "Noite", DisciplinaID = 5},
                new Professor {Nome="Zenilda Wembert", Turno= "Manhã", DisciplinaID = 6},
                new Professor {Nome="Margareth Nubila", Turno= "Manhã", DisciplinaID = 7},
                new Professor {Nome="Ronaldo de Nazaré", Turno= "Noite", DisciplinaID = 8},
                new Professor {Nome="Jailson Mendes", Turno= "Manhã", DisciplinaID = 9},
                new Professor {Nome="Mário Gadelha", Turno= "Noite", DisciplinaID = 10},
                new Professor {Nome="Renata Ferreira", Turno= "Noite", DisciplinaID = 11},
                new Professor {Nome="Paulo Guina", Turno= "Manhã", DisciplinaID = 12},
                new Professor {Nome="Sérgio Aderblado", Turno= "Noite", DisciplinaID = 13},
                new Professor {Nome="Charles Fang", Turno= "Manhã", DisciplinaID = 14},

            };
            professores.ForEach(s => context.Professores.Add(s));
            context.SaveChanges();
        }
    }
}