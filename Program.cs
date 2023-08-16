using GeradorCurriculo.Models;

Console.WriteLine("CRIAR CURRICULO");

var pessoa = new Pessoa();

Console.WriteLine("Digite o nome da pessoa do currículo:");
var nome = Console.ReadLine();
Console.WriteLine("Digite a idade da pessoa:");
var idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o email da pessoa:");
var email = Console.ReadLine();

pessoa.Nome = nome;
pessoa.Idade = idade;
pessoa.Email = email;

var habilidade = new Habilidade();

Console.WriteLine("Digite uma habilidade para o Currículo:");
var nomeHabilidade = Console.ReadLine();
Console.WriteLine("Esta habilidade está em qual nível (de 0 - 10):");
var nivel = int.Parse(Console.ReadLine());

habilidade.Nome = nomeHabilidade;
habilidade.Nivel = nivel;

var formacao = new Formacao();
Console.WriteLine("Digite o ano que a pessoa se formou: ");
var anoFormacao = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a Instituição que a pessoa formou: ");
var instituicao = Console.ReadLine();
Console.WriteLine("Digite o Grau de Formação da pessoa: ");
var grauFormacao = Console.ReadLine();

formacao.AnoFormacao = anoFormacao;
formacao.Instituicao = instituicao;
formacao.GrauFormacao = grauFormacao;

var curriculo = new Curriculo();

curriculo.DadosPessoais = pessoa;
curriculo.Habilidade = habilidade;
curriculo.Formacao = formacao;


Console.WriteLine("CURRICULO CRIADO");

Console.WriteLine("DADOS PESSOAIS:");
Console.WriteLine("Nome: " + curriculo.DadosPessoais.Nome);
Console.WriteLine("Idade: " + curriculo.DadosPessoais.Idade);
Console.WriteLine("Email: " + curriculo.DadosPessoais.Email);

Console.WriteLine("HABILIDADE:");
Console.WriteLine("Nome: " + curriculo.Habilidade.Nome);
Console.WriteLine("Nível: " + curriculo.Habilidade.Nivel);

Console.WriteLine("FORMAÇÃO:");
Console.WriteLine("Ano: " +  curriculo.Formacao.AnoFormacao);
Console.WriteLine("Nome da Instituição: " + curriculo.Formacao.Instituicao);
Console.WriteLine("Grau de Formação: " + curriculo.Formacao.GrauFormacao);
