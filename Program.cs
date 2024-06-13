// See https://aka.ms/new-console-template for more information
using Models;
using primeiroProjetoConsole.Models;
// using primeiroProjetoConsole.PessoaCopia;

// Console.WriteLine("Hello, World!");

// Pessoa pessoaOriginal = new Pessoa();
// Pessoa pessoaFalsa = new Pessoa();


// int i = Convert.ToInt32("10");
// int i = int.Parse("10");
// int f = Convert.ToInt32(40.2);

// Console.WriteLine(i);
// Console.WriteLine(f);

// string nome = "ablabla";
// int b = 0;
// int.TryParse(nome,out b);
// Console.WriteLine(b);


// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possívelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível a venda? {possívelVenda}");

// if(possívelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda com quantidade zero, invalida!");
// }
// else{
//     Console.WriteLine("Não foi possível venda.");
// }

// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel){
//     Console.WriteLine("Entrada liberada");
// } else{
//     Console.WriteLine("Entrada negada");
// }

// bool possuiPresenciaMinima = true;
// double media = 7.5;

// if(possuiPresenciaMinima && media >= 7){
//     Console.WriteLine("Aprovado");
// } else{
//     Console.WriteLine("Reprovado");
// }

// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar");
// } else{
//     Console.WriteLine("Vou pedalar outro dia");
// }


// Calculadora calculadora = new Calculadora();
// double x = 10;
// double y = 3;

// calculadora.Somar(x,y);
// calculadora.Subtrair(x,y);
// calculadora.Multiplicar(x,y);
// calculadora.Dividir(x,y);
// calculadora.Potencia(x,y);
// calculadora.Seno(x);
// calculadora.Cosseno(x);
// calculadora.Tangente(x);

int numero = 10;

Console.WriteLine($"O incremento do numero {numero} = {numero++}");
Console.WriteLine($"O decremento do numero {numero} = {numero--}");