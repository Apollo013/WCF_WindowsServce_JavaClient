using Client.CalculatorServiceRef;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> PrintTitle = (title) =>
            {
                Console.WriteLine();
                Console.WriteLine(new String('=', 70));
                Console.WriteLine(title);
                Console.WriteLine(new String('=', 70));
            };

            CalculatorClient client = new CalculatorClient();

            PrintTitle("Adding Example");
            var result = client.Add(50, 50);
            Console.WriteLine($"50 + 50 = {result}");


            PrintTitle("Subtraction Example");
            var subresult = client.Subtract(500, 50);
            Console.WriteLine($"500 - 50 = {subresult}");


            PrintTitle("Multiplication Example");
            var mulresult = client.Multiply(25, 25);
            Console.WriteLine($"25 * 25 = {mulresult}");


            PrintTitle("Division Example");
            var divresult = client.Divide(500, 50);
            Console.WriteLine($"500 / 50 = {divresult}");

            client.Close();
        }
    }
}
