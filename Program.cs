using Praticando.models;

Pessoa p1 = new Pessoa("Brena", "Paiva");
Pessoa p2 = new Pessoa("Gustavo", "Siqueira");


Curso cursoDeIngles = new Curso();

cursoDeIngles.Name = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();