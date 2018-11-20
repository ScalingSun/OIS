using System;
using System.Collections.Generic;
using System.Text;

namespace OIS
{
    class Main
    {
        public Vijver vijver = new Vijver();
        public Main()
        {
            firstQuestion();
            string firstQuestionAnswer = Console.ReadLine().ToString();
            vijver.FirstQuestionResult(firstQuestionAnswer);
            Console.Read();
        }
        public void firstQuestion()
        {
            Console.WriteLine("Stel eens een vraag? over welke eendje wil je iets weten? kies uit:");
            foreach (Eend eend in vijver.eendjes) {
                Console.WriteLine(eend.naam);
            }

        }
    }
}
