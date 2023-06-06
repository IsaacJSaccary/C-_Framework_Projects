using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //What is your name?
            Console.WriteLine("Please enter your name:");
            //Create string newname and string array names
            string newname = Console.ReadLine();
            string[] name = { "Jesse", "Sam", "Cole", "Steven" };
            //Create the forloop that adds your name
            for (int i = 0; i < name.Length; i++)
            {
                name[i] += newname;
            }
            //Create the for loop that prints the result.
            for (int j = 0; j < name.Length; j++)
            {
                Console.WriteLine(name[j]);
            }
            Console.ReadLine();

            //Part 2
            //Created int numArray
            int[] numArray = { 34, 35, 36, 22, 44 };
            //Created an infinite loop
            //Fixed the loop by adding "i++" after numArray.Length;
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            Console.ReadLine();

            //Part 3
            //For loop to create the < loop
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < 44)
                {
                    Console.WriteLine(numArray[i]);
                }
            }
            Console.ReadLine();
            //For loop to creat the <= loop
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] <= 36)
                {
                    Console.WriteLine(numArray[i]);
                }
            }


            //Part 4
            //Creating string array colours and adding and asking for the users
            //input of a number to determine their favourite colour.
            string[] colours = { "Blue", "Green", "Yellow", "Purple", "Red", "Orange", "Black" };
            Console.WriteLine("Pick a number between 0 and 6:");
            int favColour = Convert.ToInt32(Console.ReadLine());
            bool validString = false;
            //Creating a while loop with a try/catch block inside of it to give the result
            //of the users favourite colour or ask them to pick a different number if
            //that number isn't available.
            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favourite colour is " + colours[favColour]);
                    validString = true;
                }
                catch
                {
                    Console.WriteLine("Please pick a different number between 0 and 6.");
                    favColour = Convert.ToInt32(Console.ReadLine());
                }
            }


            //Part 5
            //Create list animals
            List<string> animals = new List<string>() { "Dog", "Cat", "Cat", "Hampsters", "Rabbit", "Guinea Pig" };
            Console.WriteLine("What is your favourite animal?");
            //Create string selection
            string selection = Console.ReadLine();
            //Created a loop that if a proper selection isn't made it continues asking 
            //"Please enter your favourite animal".
            while (!(selection == "Dog" || selection == "Cats" || selection == "Hampsters" || selection == "Rabbits" || selection == "Guinea Pigs"))
            {
                Console.WriteLine("Please enter your favourite animal:");
                selection = Console.ReadLine();
            }
            //Console.WriteLine that displays user selection
            Console.WriteLine("Your favourite animal is " + selection);
            Console.ReadLine();
            //String with tenant list names
            List<string> identical1 = new List<string>() { "Sam", "Steve", "Jesse", "Frank", "Steve", "Isaac" };
            //String to help check the list
            List<string> identicalCheck = new List<string>();
            Console.WriteLine("Tenant List:");
            //foreach loop to chech the list for identical strings
            foreach(string identical in identical1)
            {
                Console.WriteLine(identical);
                if(identicalCheck.Contains(identical))
                {
                    Console.WriteLine("This name has been repeated.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated.");
                }
                identicalCheck.Add(identical);
            }
            Console.ReadLine();
            

        }
    }
}
        
        
    

