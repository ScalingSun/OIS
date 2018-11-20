using System;
using System.Collections.Generic;
using System.Text;

namespace OIS
{
    class Main
    {
        public Vijver vijver = new Vijver();
        public Ooievaar ooievaren = new Ooievaar();
        public Main()
        {
            firstQuestion();
            string firstQuestionAnswer = Console.ReadLine().ToString();
            vijver.FirstQuestionResult(firstQuestionAnswer);
            SecondQuestion();
            Console.Read();
        }
        public void firstQuestion()
        {
            Console.WriteLine("Stel eens een vraag? over welke eendje wil je iets weten? kies uit:");
            foreach (Eend eend in vijver.eendjes) {
                Console.WriteLine(eend.naam);
            }
        }
        public void SecondQuestion()
        {
            Console.WriteLine("Deze vijver bevat ook Kikkers & Ooievaren. Ooievaren eten ook kikkers. Hier volgt een lijst met kikkers.");
            foreach (Kikker kikkers in vijver.kikkers)
            {
                Console.WriteLine(kikkers.naam);
            }
            Console.WriteLine("De Ooievaren in de vijver kiezen willekeurig een kikker uit om op te eten.");
            Console.WriteLine("Druk op enter om verder te gaan");
            Console.ReadLine();

            ooievaren.eetKikker(vijver.kikkers);
            foreach (Kikker Kikkers in vijver.kikkers)
            {
                Console.WriteLine(Kikkers.naam);
            }
        }
    }
}
