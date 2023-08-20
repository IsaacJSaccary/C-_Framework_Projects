﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable
            const string const1 = "Your name is: ";
            const string const2 = "Your favorite number is ";
            Console.WriteLine("Enter your name and favourite number: ");
            //Create a variable using keyword var
            var answer = Console.ReadLine();
            //Chain two constructors
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}