using System;
using System.Collections.Generic;
using System.Text;

namespace OIS
{
    class Vijver
    {
        public List<Eend> eendjes = new List<Eend>();
        public List<Kikker> kikkers = new List<Kikker>();
        Ooievaar ooievaren = new Ooievaar();

        public Vijver()
        {
            Eend eendje1 = new Eend("Tygo","man");
            Eend eendje2 = new Eend("Lara", "vrouw");
            Eend eendje3 = new Eend("Niels", "man");
            Eend eendje4 = new Eend("Cynthia", "vrouw");
            Eend eendje5 = new Eend("Puck", "man");
            Eend eendje6 = new Eend("Anouk", "vrouw");
            Kikker kikker1 = new Kikker("bob");
            Kikker kikker2 = new Kikker("vis");
            Kikker kikker3 = new Kikker("kikkah");
            Kikker kikker4 = new Kikker("tut");
            Kikker kikker5 = new Kikker("pop");
            Kikker kikker6 = new Kikker("gug");

            eendjes.Add(eendje1);
            eendjes.Add(eendje2);
            eendjes.Add(eendje3);
            eendjes.Add(eendje4);
            eendjes.Add(eendje5);
            eendjes.Add(eendje6);

            kikkers.Add(kikker1);
            kikkers.Add(kikker2);
            kikkers.Add(kikker3);
            kikkers.Add(kikker4);
            kikkers.Add(kikker5);
            kikkers.Add(kikker6);
        }

        public void firstQuestion()
        {
            Console.WriteLine("Stel eens een vraag? over welke eendje wil je iets weten? kies uit:");
            foreach (Eend eend in eendjes)
            {
                Console.WriteLine(eend.naam);
            }
            string firstQuestionAnswer = Console.ReadLine().ToString();
            FirstQuestionResult(firstQuestionAnswer);
        }



        public void SecondQuestion()
        {
            Console.WriteLine("Deze vijver bevat ook Kikkers & Ooievaren. Ooievaren eten ook kikkers. Hier volgt een lijst met kikkers.");
            foreach (Kikker kikkers in kikkers)
            {
                Console.WriteLine(kikkers.naam);
            }
            Console.WriteLine("De Ooievaren in de vijver kiezen willekeurig een kikker uit om op te eten.");
            Console.WriteLine("Druk op enter om verder te gaan.");
            Console.ReadLine();

            ooievaren.eetKikker(kikkers);
            Console.WriteLine("de overgebleven kikkers zijn:");
            foreach (Kikker Kikkers in kikkers)
            {
                Console.WriteLine(Kikkers.naam);
            }
            Console.Read();
        }




        private void FirstQuestionResult(string input)
        {
            foreach (Eend eend in eendjes)
            {
                if (input == eend.naam)
                {
                    Console.WriteLine(eend.naam + " is een " + eend.geslacht);
                   return; 
                }
            }
        }
    }
}
