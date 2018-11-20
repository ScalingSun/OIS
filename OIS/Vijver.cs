using System;
using System.Collections.Generic;
using System.Text;

namespace OIS
{
    class Vijver
    {
        public List<Eend> eendjes = new List<Eend>();
        public Vijver()
        {
            Eend eendje1 = new Eend("Tygo","man");
            Eend eendje2 = new Eend("Lara", "vrouw");
            Eend eendje3 = new Eend("Niels", "man");
            Eend eendje4 = new Eend("Cynthia", "vrouw");
            Eend eendje5 = new Eend("Puck", "man");
            Eend eendje6 = new Eend("Anouk", "vrouw");
            eendjes.Add(eendje1);
            eendjes.Add(eendje2);
            eendjes.Add(eendje3);
            eendjes.Add(eendje4);
            eendjes.Add(eendje5);
            eendjes.Add(eendje6);
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
