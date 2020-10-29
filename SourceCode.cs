using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Количество шагов рекомендуется не более 10 из-за большого количества цифр---");



            Console.WriteLine("\nВведите первое число для последовательности Морса-Туе: 0 либо 1");

            string firstNumber =Console.ReadLine();

            Console.WriteLine("Введите кол-во шагов для последовательности Морса-Туе");

            int n= Int32.Parse(Console.ReadLine());

             
        //    Console.WriteLine(firstNumber[1]);

            

            for (int i=0; i<n; i++)
            {

                var k = firstNumber.Length;

                for (int j = 0; j < k; j++)
                {

                    if (firstNumber[j] == Char.Parse("0"))
                    {

                        firstNumber = firstNumber + "1";
                       

                    }
                    else if (firstNumber[j] == Char.Parse("1"))
                    {

                        firstNumber = firstNumber + "0";
                        


                    }

                }
                Console.WriteLine("\n"+firstNumber);

            }




            Console.WriteLine("\nДля выхода нажмите Enter");
            Console.ReadLine();

        }
    }
}
