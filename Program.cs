using System;

namespace MethodYuanluFang
{
    class Program
    {
        //declear a method for looping the message
       static void LoopMessage (String word, int number)
        {
            for(int i =0; i< number; i++)//for loop
            {
                Console.Write(word);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Yuanlu Fang. Version = 25.");

            String word = "";
            //char seperator;
            int number;
 
           
                Console.WriteLine("Please type any characters you want:");//take in the character
                word = Console.ReadLine();

                Console.WriteLine("Please enter a number from 2-5:");//take in the number if not show error
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Only number!");
                }

                //Console.WriteLine("Please type one character:");//take in the third single variable if not show error
               // while (!char.TryParse(Console.ReadLine(), out seperator))
               // {
                //    Console.WriteLine("Only one character!");
               // }

                LoopMessage(word, number);// call custom method

                Console.WriteLine();

                Console.WriteLine("Your input (" + word + ") has been repeated for " + number + " times.");// print a scentence on how many times has it been repeated
                Console.WriteLine();
                         
        }
        
    }
}
