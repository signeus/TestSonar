using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclomatic
{
    class Program
    {
        static void Main(string[] args)
        {
            StartRace race = new StartRace();
            Console.WriteLine(race.Resultado(1,2));
        }
    }
}
