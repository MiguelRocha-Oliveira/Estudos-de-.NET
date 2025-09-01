using System.Collections;

namespace Calculadora;

public class Program
{
    public static void Main()
    {
        do{
        Console.WriteLine("----------Calculadora----------");//title

        float number1, number2, result;//variables for the operations
        char operation, menu;

        Console.WriteLine("\nEscolha a ação a ser exxecutada:\n a) Sair\n b) Menu de operações\n c) Descriçãode operadores");
        menu = Console.ReadKey().KeyChar; //Read a single character from user input
        switch (menu) //use switch to handle the menu options
                {

                        case 'a'://for char type us single quotes
                                Console.WriteLine("Você escolheu sair, até mais!");//finish the program
                                break;


                        case 'b':
                                Console.WriteLine("\nWright the first number of the operation:");
                                number1 = Convert.ToSingle(Console.ReadLine());


                                Console.WriteLine("\nWright the second number of the operation:");
                                number2 = Convert.ToSingle(Console.ReadLine());


                                break;
                }
        }while(menu != 'a');
    }
 }