using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Praticando.models
{
    public class Curso
    {
        public string Name { get; set; }
        public List<Pessoa> Alunos {get; set;}

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQtdDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Name}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N° {count + 1}  - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto); 
            }
            
        }
}
}