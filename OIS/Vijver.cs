using System;
using System.Collections.Generic;
using System.Text;

namespace OIS
{
    class Vijver
    {
        public List<Eend> eendjes = new List<Eend>();
        public List<Kikker> kikkers = new List<Kikker>();
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
        public void FirstQuestionResult(string input)
        {
            foreach (Eend eend in eendjes)
            {
                if (input == eend.naam)
                {
                    Console.WriteLine(eend.naam + " is een " + eend.geslacht);
                    return;
                }
            }
            Console.WriteLine("Voer Aub een goede naam in.");
        }
    }
}
