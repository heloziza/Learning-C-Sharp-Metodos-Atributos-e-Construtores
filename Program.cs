using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Helo";
p1.Sobrenome = "Giacometti";

Pessoa p2 = new Pessoa();
p2.Nome = "Leonardo";
p2.Sobrenome = "Buta";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();