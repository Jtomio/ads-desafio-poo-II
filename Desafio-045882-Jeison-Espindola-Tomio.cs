using System;

namespace Calculadora
{
    abstract class Calculo
    {
        protected double R { get; set; }
    }

    class Basico : Calculo
    {
        public double X { private get; set; }
        public double Y { private get; set; }

        public void Multiplicar()
        {
            R = X * Y;
        }

        public void Somar()
        {
            R = X + Y;
        }

        public void Subtrair()
        {
            R = X - Y;
        }

        public void Dividir()
        {
            if (Y != 0)
            {
                R = X / Y;
            }
            else
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
        }
    }

    class Estatistico : Calculo
    {
        public double[] Valores { private get; set; }

        public void CalcularMediaAritmetica()
        {
            double soma = 0;
            foreach (double valor in Valores)
            {
                soma += valor;
            }

            R = soma / Valores.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de cálculo:");
            Console.WriteLine("1 - Cálculo Básico");
            Console.WriteLine("2 - Cálculo Estatístico");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    RealizarCalculoBasico();
                    break;
                case 2:
                    RealizarCalculoEstatistico();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Encerrando o programa.");
                    break;
            }
        }

        static void RealizarCalculoBasico()
        {
            Console.WriteLine("Digite o valor de X:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y:");
            double y = double.Parse(Console.ReadLine());

            Basico calculadora = new Basico();
            calculadora.X = x;
            calculadora.Y = y;

            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1 - Multiplicar");
            Console.WriteLine("2 - Somar");
            Console.WriteLine("3 - Subtrair");
            Console.WriteLine("4 - Dividir");
            int operacao = int.Parse(Console.ReadLine());

            try
            {
                switch (operacao)
                {
                    case 1:
                        calculadora.Multiplicar();
                        Console.WriteLine("Resultado: " + calculadora.R);
                        break;
                    case 2:
                        calculadora.Somar();
                        Console.WriteLine("Resultado: " + calculadora.R);
                        break;
                    case 3:
                        calculadora.Subtrair();
                        Console.WriteLine("Resultado: " + calculadora.R);
                        break;
                    case 4:
                        calculadora.Dividir();
                        Console.WriteLine("Resultado: " + calculadora.R);
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        static void RealizarCalculoEstatistico()
        {
            Console.WriteLine("Digite a quantidade de valores:");
            int quantidadeValores = int.Parse(Console.ReadLine());

            double[] valores = new double[quantidadeValores];

            for (int i = 0; i < quantidadeValores; i++)
            {
                Console.WriteLine("Digite o valor " + (i + 1) + ":");
                valores[i] = double.Parse(Console.ReadLine());
            }

            Estatistico calculadora = new Estatistico();
            calculadora.Valores = valores;
            calculadora.CalcularMediaAritmetica();

            Console.WriteLine("Média aritmética: " + calculadora.R);
        }
    }
}
