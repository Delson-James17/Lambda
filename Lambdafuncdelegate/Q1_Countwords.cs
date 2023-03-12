using Questionares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdafuncdelegate
{
    delegate int CountWords(string sentence);
    class Q1_Countwords
    {
        //Q1: For any given sentance find the no of words in it.
        public static void Q1()
        {
            CountWords countwordsentence = (sentence) =>
            {
                string[] words = sentence.Split(' ');
                return words.Length;
            };

            string message = "What's the sound of the dog? Meow, meow, meow.";

            Action<string> action = (messageToPrint) =>
            {
                Console.WriteLine(messageToPrint);
                //call the delagation
                int numWords = countwordsentence(messageToPrint);
                Console.WriteLine("Number of words: " + numWords);
            };
            //call action
            action(message);
        }

        }
}
