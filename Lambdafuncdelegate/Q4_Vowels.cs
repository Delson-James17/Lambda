using Questionares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdafuncdelegate
{

    delegate int CountVowels(string sentence);
    class Q4_Vowels
    {
        static public void vowels()
        {
            CountVowels vowelscount = (sentence) =>
            {
                string vowels = "aeiouAEIOU";
                int count = 0;
                foreach (char c in sentence)
                {
                    if (vowels.Contains(c))
                    {
                        count++;
                    }
                }
                return count;
            };
            string SampleSentence = "Whats the sounds of the dog Meo Meoow Meow";
            int vowelletters = vowelscount(SampleSentence);
            Console.WriteLine("Numbers of Vowels: " + vowelletters);
        }
    }
}
