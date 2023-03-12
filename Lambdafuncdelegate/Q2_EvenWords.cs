using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdafuncdelegate
{
    delegate int ELC(string sentence);
    class Q2_EvenWords
    {
        public static void Evenwords()
        {
            ELC countEvenLengthWords = (sentence) =>
            {

                string[] words = sentence.Split(' ');

                int count = 0;
                foreach (string word in words)
                {
                    if (word.Length % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            };
            string SampleSentence = "Whats the sounds of the dog Meo Meoow Meow";
            //call the deligation 
            int numevenLengthWord = countEvenLengthWords(SampleSentence);
            Console.WriteLine("Sample Sentece: " + SampleSentence);
            Console.WriteLine("Total Number of EvenWords: " + numevenLengthWord);
        }
       
    }
}

