using System;
using Aritmetica;

namespace ComsumeLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarates of variable with values from the Library
            MisMates operation = new MisMates(5,10.5);
            //Optains the value of the operation
            double add = operation.suma();
            //Print the value of the answer
            Console.WriteLine("The result of the add is {0}", add);
            Console.ReadKey();
        }
    }
}
