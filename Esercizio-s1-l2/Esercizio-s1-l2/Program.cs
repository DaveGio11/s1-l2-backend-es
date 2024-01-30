using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_s1_l2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("", "", 0);

            persona1.getName();
            persona1.getSurname();
            persona1.getAge();
            persona1.getGeneral();
            Console.ReadLine();
        }
    }
}
