using ProjEstacionamento.Models;

Sis sistema = new Sis();
bool exibirMenu = true;
Console.WriteLine("Digite o preço do preço inicial, abaixo: ");
double precoInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o preço do preço por hora, abaixo: ");
double precoPorHora = Convert.ToDouble(Console.ReadLine());

while (exibirMenu)
{
    Console.WriteLine("--Bem vindo ao sistema de Estacionamento--\n");
    Console.WriteLine("1 - Adicionar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar Programa");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            sistema.AdicionarVeículo();
            break;
        case 2:
            sistema.RemoverVeículo(precoPorHora,precoInicial);
            break;
        case 3:
            sistema.ListarVeículos();
            break;
        case 4:
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção não encontrada, tente novamente. \n");
            break;
    }
}
