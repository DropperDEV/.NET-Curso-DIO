using System;
using System.Collections.Generic;

namespace ProjEstacionamento.Models
{
    public class Sis
    {
        private List<string> veiculos = new List<string>();

        public void AdicionarVeículo()
        {
            bool tentativa = true;
            while (tentativa)
            {
                Console.WriteLine("Insira a numeração da placa do veículo, abaixo: ");
                string numeracao = Console.ReadLine();
                if (numeracao.Length == 7)
                {
                    veiculos.Add(numeracao);
                    Console.WriteLine("Veículo autenticado!");
                    tentativa = false;
                }
                else
                {
                    Console.WriteLine("Padrão de placa não encontrado, tente novamente com 7 caracteres.");
                }
            }
        }

        public void RemoverVeículo(double precoPorHora, double precoInicial)
        {
            bool tentativa = true;
            while (tentativa)
            {
                Console.WriteLine("Digite a numeração da placa do veículo a ser removido, abaixo: ");
                string numeracao = Console.ReadLine();
                if (numeracao.Length == 7)
                {
                    if (veiculos.Contains(numeracao))
                    {
                        veiculos.Remove(numeracao);
                        bool horasValida = false;
                        int horas = 0;

                        while (!horasValida)
                        {
                            Console.WriteLine("Quantas horas o veículo ficou estacionado, digite abaixo: ");
                            if (int.TryParse(Console.ReadLine(), out horas) && horas > 0)
                            {
                                horasValida = true;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido. Por favor, insira um número positivo de horas.");
                            }
                        }

                        double precoTotal = horas * precoPorHora + precoInicial;
                        Console.WriteLine($"O veículo {numeracao} foi removido e o preço total foi de: {precoTotal:C}");
                        tentativa = false;
                    }
                    else
                    {
                        Console.WriteLine("Veículo não encontrado.");
                    }
                }
                else
                {
                    Console.WriteLine("Padrão de placa não encontrado, tente novamente com 7 caracteres.");
                }
            }
        }


        public void ListarVeículos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine($"Listando os {veiculos.Count} veículos:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
                Console.WriteLine("Fim da lista.");
            }
            else
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
        }
    }
}
