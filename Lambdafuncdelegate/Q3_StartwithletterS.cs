using Questionares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdafuncdelegate
{
    delegate void printtheS(string sentence);
    class Q3_StartwithletterS
    {
        static public void startwithletters()
        {
            printtheS printallstartS = (sentence) =>
            {
                string[] words = sentence.Split(' ');

                foreach (string word in words)
                {
                    if (word.StartsWith('s') || word.StartsWith('S'))
                    {
                        Console.WriteLine(word);
                    }
                }
            };

            string SampleSentence = "Six sick hicks nicks six slick bricks with picks and sticks";
            Console.WriteLine("Print with start with letter s");
            printallstartS(SampleSentence);
        }
    }
}
