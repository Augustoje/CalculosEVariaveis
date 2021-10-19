using System;

namespace MenuEcalculos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            string nome;

            Console.WriteLine("### Seja Bem vindo ###");
            Console.WriteLine("\nDigite seu nome");
            nome = Console.ReadLine();

            do
            {
                Console.WriteLine("1 - Calculo do IMC");
                Console.WriteLine("2 - Calculo de Qtde Salario");
                Console.WriteLine("3 - Calculo do Volume de uma esfera");
                Console.WriteLine("4 - Calculo da média de uma nota");
                Console.WriteLine("5 - Algoritmo tipos de animais");
                Console.WriteLine("0 - Sair");

                Console.Write("\nOlá {0}, escolha uma opção: ", nome);
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        double altura, peso, imc;

                        Console.Write("Digite sua Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());

                        imc = peso / (altura * altura);

                        Console.WriteLine("\nIMC {0}", imc.ToString("F1"));

                        Console.Write("\n{0}, voce está", nome);

                        if (imc < 20)
                        {
                            Console.WriteLine(" abaixo do Peso!!!");
                        }

                        if (imc >= 20 && imc < 25)
                        {
                            Console.WriteLine(" com o peso Ideal!!!");
                        }
                        else if (imc >= 25)
                        {
                            Console.WriteLine(" acima do Peso!!!");
                        }
                        Console.WriteLine("\n \n \nPressione Enter para voltar ao Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:

                        double salario, salarioMinimo, Qtde;

                        Console.Write("Informe o valor do salario: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o valor do salario minimo: ");
                        salarioMinimo = Convert.ToDouble(Console.ReadLine());

                        Qtde = salario / salarioMinimo;

                        Console.WriteLine("\n{1}, você ganha {0:F1} salarios minimos", Qtde, nome);
                        Console.WriteLine("\n \n \nPressione Enter para voltar ao Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:

                        float div = 4f / 3f, pi = 3.14f, raio, exp = 3, result, volume;

                        Console.WriteLine("Informe o valor do raio: ");
                        raio = Convert.ToInt32(Console.ReadLine());

                        result = Convert.ToInt32(Math.Pow(raio, exp));
                        volume = div * pi * result;

                        Console.WriteLine("\n{1}, o volume do raio é {0:F1}", volume, nome);

                        Console.WriteLine("\n \n \nPressione Enter para voltar ao Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        {
                            double n1, n2, n3, notas, exame, media, nmedia, res = 3;

                            Console.Write("\nDigite a 1ª nota: ");
                            n1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite a 2ª nota: ");
                            n2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite a 3ª nota: ");
                            n3 = Convert.ToDouble(Console.ReadLine());

                            notas = n1 + n2 + n3;
                            media = notas / res;

                            if (media >= 7)
                            {
                                Console.WriteLine("\nSua média é {0:F1}", media);
                                Console.WriteLine("\nAprovado");

                            } else {

                                Console.WriteLine("\nSua média é {0:F1}", media);
                                Console.Write("\nDigite a nota do novo exame: ");
                                exame = Convert.ToDouble(Console.ReadLine());

                                nmedia = (media + exame) / 2;


                                if (nmedia >= 5)
                                {
                                    Console.WriteLine("\n \nSua nova média é {0:F1}", nmedia);
                                    Console.WriteLine("\nAprovado em exame");

                                } else {
                                    Console.WriteLine("\nSua nova média é {0:F1}", nmedia);
                                    Console.WriteLine("\nReprovado");
                                }

                            }
                        }
                        Console.WriteLine("\n \n \nPressione Enter para voltar ao Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }


            } while (true);
        }
    }
}
