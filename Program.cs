using System;

namespace A2Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence which contains some 'ies' at the end of one or more words: ");
            string sentence = Console.ReadLine();

            //Printing initial string
            //Console.WriteLine(sentence);

            //using replace function to change 'ies' to 's'
            string newSen = sentence.Replace("ies", "s");

            Console.WriteLine("\n\nThe modifield sentence is: ");
            Console.WriteLine(newSen);
        }
    }
}
