
namespace teste;

public class Program
{
    static void Main()
    {
        //comentando para teste
        Console.WriteLine("to testando meo");


        //testando declarações de variáveis
        string teste = "Hello World!";
        Console.WriteLine(teste);
        int number = 18;
        Console.WriteLine(number);
        float number2 = 18.5f;
        Console.WriteLine(number2);
        bool isTrue = true;

        //solicita um valor inteiro ao usuário
        Console.WriteLine("digite um núemro inteiro: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        //testando conceitos de laço de repetição, incremento e decremento de váriaveis e uso de condicionais com booleanos
        do
        {
            if (number == 18)
            {
                isTrue = true;
                Console.WriteLine("\no número é igual 18, logo: " + isTrue);
                number++;
            }
            else if (number > 18)
            {
                isTrue = false;
                Console.WriteLine("\nO número é maior que 18 logo: " + isTrue);
                number -= 2;

            }
            else
            {
                isTrue = false;
                Console.WriteLine("\nO número é menor que 18 logo: " + isTrue);
                number += 5;

            }
        } while (number < 20);




    }
}
