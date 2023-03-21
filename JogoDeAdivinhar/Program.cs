namespace JogoDeAdivinhar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int opDificuldade, contTentativas = 1;
            int numeroAdivinhar = numAleatorio.Next(1, 21);
            int numChutado = 0;
            int pontuacao = 1000;

            Console.WriteLine("------Jogo da Adivinhação------");

            Console.WriteLine("");

            Console.WriteLine("Escolha o nível da dificuldade");
            Console.WriteLine("---------1 - Fácil------------");
            Console.WriteLine("---------2 - Médio------------");
            Console.WriteLine("--------3 - Difícil-----------");

            Console.WriteLine("");

            Console.Write("Opção: ");
            opDificuldade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("==============================");

            switch (opDificuldade)
            {
                case 1:
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Tentativa: "+contTentativas+"/15");
                        Console.WriteLine("--------------------------------");
                        Console.Write("Digite um numero para tentar adivinhar o numero: ");
                        numChutado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        if (numChutado > numAleatorio)
                        {
                            Console.WriteLine("O numero chutado está acima do número secreto");
                        }
                        else
                        {
                            Console.WriteLine("O numero chutado está abaixo do número secreto");
                        }

                        Console.WriteLine();
                        pontuacao = pontuacao - Math.Abs((numChutado - numeroAdivinhar)) / 2;
                        Console.WriteLine("Você fez " + pontuacao);

                        contTentativas++;
                    } while (contTentativas != 15 && numChutado != numeroAdivinhar);

                    if(contTentativas == 15)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você não teve sorte, tente outra vez - Número secreto: "+numeroAdivinhar);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Parabéns você adivinhou - número chutado: "+numChutado+" número aleatório: "+numeroAdivinhar);
                    }

                    break;

                case 2:
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Tentativa: " + contTentativas + "/10");
                        Console.WriteLine("--------------------------------");
                        Console.Write("Digite um numero para tentar adivinhar o numero: ");
                        numChutado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        if (numChutado > numAleatorio)
                        {
                            Console.WriteLine("O numero chutado está acima do número secreto");
                        }
                        else
                        {
                            Console.WriteLine("O numero chutado está abaixo do número secreto");
                        }

                        Console.WriteLine();
                        pontuacao = pontuacao - Math.Abs((numChutado - numeroAdivinhar)) / 2;
                        Console.WriteLine("Você fez " + pontuacao);

                        contTentativas++;
                    } while (contTentativas != 10 && numChutado != numeroAdivinhar);

                    if (contTentativas == 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você não teve sorte, tente outra vez - Número secreto: " + numeroAdivinhar);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Parabéns você adivinhou - número chutado: " + numChutado + " número aleatório: " + numeroAdivinhar);
                    }

                    break;

                case 3:
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Tentativa: " + contTentativas + "/5");
                        Console.WriteLine("--------------------------------");
                        Console.Write("Digite um numero para tentar adivinhar o numero: ");
                        numChutado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        if (numChutado > numAleatorio)
                        {
                            Console.WriteLine("O numero chutado está acima do número secreto");
                        }
                        else
                        {
                            Console.WriteLine("O numero chutado está abaixo do número secreto");
                        }

                        Console.WriteLine();
                        pontuacao = pontuacao - Math.Abs((numChutado - numeroAdivinhar)) / 2;
                        Console.WriteLine("Você fez " + pontuacao);

                        contTentativas++;
                    } while (contTentativas != 5 && numChutado != numeroAdivinhar);

                    if (contTentativas == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você não teve sorte, tente outra vez - Número secreto: " + numeroAdivinhar);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Parabéns você adivinhou - número chutado: " + numChutado + " número aleatório: " + numeroAdivinhar);
                    }

                    break;
            }

            Console.ReadLine();
        }
    }
}