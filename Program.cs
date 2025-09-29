using System.Globalization;
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Helo", sobrenome: "Giacometti", idade: 20);
Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta", idade: 23);

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

decimal valorMonetario = 82.40M;
Console.WriteLine(valorMonetario.ToString("C"));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));