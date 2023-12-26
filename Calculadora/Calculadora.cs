
namespace Calculadora
{
    internal class Calculadora
    {
        public void MenuCalculadora()
        {
            int opcao;
            do
            {
                Console.Write("****CALCULADORA****\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n0 - Sair\nDigite sua Resposta: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Inserir();
                        Somar();
                        break;
                    case 2:
                        Console.Clear();
                        Inserir();
                        Subtrair();
                        break;
                    case 3:
                        Console.Clear();
                        Inserir();
                        Multiplicar();
                        break;
                    case 4:
                        Console.Clear();
                        Inserir();
                        Dividir();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida, tente novamente!");
                        Console.WriteLine();
                        break;
                }
            } while (opcao != 0);
        }

        int num1, num2;
        public void Inserir()
        {
            bool inputValido = false;

            do
            {
                Console.Write("Digite o primeiro número: ");
                string inputNum1 = Console.ReadLine();

                Console.Write("Digite o segundo número: ");
                string inputNum2 = Console.ReadLine();

                if (int.TryParse(inputNum1, out num1) && int.TryParse(inputNum2, out num2))
                {
                    inputValido = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Por favor, insira números válidos.");
                }
            } while (!inputValido);
        }


        public void Somar()
        {
            int resultado = num1 + num2;
            Console.Write("\n" + num1 + " + " + num2 + " = " + resultado);
            Console.WriteLine("\n");
        }

        public void Subtrair()
        {
            int resultado = num1 - num2;
            Console.Write("\n" + num1 + " - " + num2 + " = " + resultado);
            Console.WriteLine("\n");
        }
        public void Multiplicar()
        {
            int resultado = num1 * num2;
            Console.Write("\n" + num1 + " x " + num2 + " = " + resultado);
            Console.WriteLine("\n");
        }

        public void Dividir()
        {
            int result;
            try
            {
                result = num1 / num2;
                Console.Write("\n"+num1+" / "+num2+" = " + result);
                Console.WriteLine("\n");

            }
            catch (DivideByZeroException)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Não é possível dividir por zero!\nPor favor, insira um denominador diferente de zero.");

                    Console.Write("\nDigite o denominador: ");
                    num2 = int.Parse(Console.ReadLine());

                } while (num2 == 0);

                result = num1 / num2;
                Console.Write("\n" + num1 + " / " + num2 + " = " + result);
                Console.WriteLine("\n");

            }
        }
    }
}
