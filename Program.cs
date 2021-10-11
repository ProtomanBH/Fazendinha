using System;
using System.Collections.Generic;
using System.Text;

namespace Fazendinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Fazenda bichos = new Fazenda();
            List<double> ovos_galinha = new List<double>();
            List<double> leite_vaca = new List<double>();

            int x, tipo_animal;
            double peso_galinha, altura_galinha, peso_vaca, altura_vaca, quant_ovos, quant_leite, valor_ovo, valor_leite, receita_ovos = 0, receita_leite = 0;
           
            do
            {
                Console.WriteLine("Digite 1 para inserir um animal na lista:\n" +
                    "Digite 2 para exibir a lista:\n" +
                    "Digite 3 para exibir a receita de ovos:\n" +
                    "Digite 4 para exibir a receita com leite:\n" +
                    "Digite 5 para exibir a receita total:\n " +
                    "Digite 0 para sair:\n");
                x = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    Console.WriteLine("Digite 1 para adicionar uma galinha ou 2 para adicionar uma vaca");
                    tipo_animal = int.Parse(Console.ReadLine());
                    if (tipo_animal == 1)
                    {
                        Console.WriteLine("Digite a altura da galinha: ");
                        altura_galinha = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o peso da galinha: ");
                        peso_galinha = double.Parse(Console.ReadLine());

                        Galinha galinha = new Galinha(altura_galinha, peso_galinha);

                        Console.WriteLine("Insira a quantidade de ovos diarios dessa galinha: ");
                        quant_ovos = double.Parse(Console.ReadLine());

                        ovos_galinha.Add(quant_ovos);
                        galinha.Quantidade_de_ovos = quant_ovos;

                        bichos.lista_de_animais.Add(galinha);
                    }

                    if (tipo_animal == 2)
                    {
                        Console.WriteLine("Digite a altura da vaca: ");
                        altura_vaca = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o peso da vaca: ");
                        peso_vaca = double.Parse(Console.ReadLine());

                        Vaca vaca = new Vaca(altura_vaca, peso_vaca);

                        Console.WriteLine("Insira a quantidade de leite diario dessa vaca: ");
                        quant_leite = double.Parse(Console.ReadLine());

                        leite_vaca.Add(quant_leite);
                        vaca.Producao_de_leite = quant_leite;
                        
                        bichos.lista_de_animais.Add(vaca);
                    }
                }

                if(x == 2)
                {
                    foreach(Animais i in bichos.lista_de_animais)
                    {
                        Console.WriteLine(i);
                    }
                }
                if (x == 3)
                {
                    Console.WriteLine("Digite o valor unitário do ovo: ");
                    valor_ovo = double.Parse(Console.ReadLine());

                    receita_ovos = bichos.receita_mensal(ovos_galinha, valor_ovo);
                    Console.WriteLine("{0:F2}", receita_ovos);
                }
                if (x == 4)
                {
                    Console.WriteLine("Digite o valor do litro do leite: ");
                    valor_leite = double.Parse(Console.ReadLine());

                    receita_leite = bichos.receita_mensal(leite_vaca, valor_leite);
                    Console.WriteLine("{0:F2}" , receita_leite);
                }
                if (x == 5)
                {
                    Console.WriteLine("A receita total eh: {0:F2} " , receita_ovos + receita_leite);
                }
                        
                if ((x > 5) || (x < 0))
                {
                    Console.WriteLine("Numero invalido, digite novamente");
                }                   

            } while (x != 0);

            

        }
    }
}
