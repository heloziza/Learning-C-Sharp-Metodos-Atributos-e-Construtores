using System.Globalization;
using ExemploExplorando.Models;

//Return de método com tupla: --------------------------------------------------------------------------------

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade linhas do arquivo: {quantidadeLinhas}");

    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else {
    Console.WriteLine("Não foi possível ler o arquivo");
}

//Tupla: --------------------------------------------------------------------------------
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Leonardo", "Buta", 1.80M);
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Buta", 1.80M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Leonardo", "Buta", 1.80M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Item4}");
// Console.WriteLine($"Altura: {tupla.Altura}");

//Dicionário: --------------------------------------------------------------------------------
// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor inexistente. É seguro adicionar: {chave}");
// }


//Pilha: --------------------------------------------------------------------------------
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


//Fila: --------------------------------------------------------------------------------
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


//Exceção: --------------------------------------------------------------------------------
// new ExemploExcecao().Metodo1();


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }









//List e formatações de data e valores monetários: --------------------------------------------------------------------------------


// Pessoa p1 = new Pessoa(nome: "Helo", sobrenome: "Giacometti", idade: 20);
// Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta", idade: 23);

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

// decimal valorMonetario = 82.40M;
// Console.WriteLine(valorMonetario.ToString("C"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// DateTime data = DateTime.Now;
// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy"));
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// DateTime dataString = DateTime.Parse("28/09/2025");
// Console.WriteLine(dataString);

// string stringData = "2022-04-17 18:00";
// DateTime.TryParseExact(stringData, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertidaDaString);

// Console.WriteLine(dataConvertidaDaString);