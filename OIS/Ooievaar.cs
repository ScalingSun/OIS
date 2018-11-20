using System;
using System.Collections.Generic;
using System.Text;

namespace OIS
{
    class Ooievaar
    {

        public void eetKikker(List<Kikker> Kikkers)
        {
            Random r = new Random();
            int randomnumber = r.Next(0,Kikkers.Count);
            Console.WriteLine(Kikkers[randomnumber].naam + " is opgegeten!");
            Kikkers.RemoveAt(randomnumber);
        }
    }
}
