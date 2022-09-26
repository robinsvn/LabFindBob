using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabFindBob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppgave
            //lag en metode som finner ut hvor mange bob's det er i stringen under.
            string bob = "obobobobobobobbbooobboboobobobobobobooobbboobooboboboobboodfdfdob4bobbobooob";
            string word = "bob";
            int count = 0;
            foreach (Match match in Regex.Matches(bob, word, RegexOptions.IgnoreCase))
            {
                count++;
            }
            Console.WriteLine("{0}" + " Found " + "{1}" + " Times", word, count);
            Console.ReadLine();

        }
    }
}
