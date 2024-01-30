using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_s1_l2
{
    internal class Persona
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Persona(string Name, string Surname, int Age)
        {
            Name = Name;
            Surname = Surname;
            Age = Age;
        }

        public void getName()
        {
            Console.WriteLine("inserisci qui il tuo nome");
            Name = Console.ReadLine();
        }

        public void getSurname()
        {
            Console.WriteLine("inserisci qui il tuo cognome");
            Surname = Console.ReadLine();
        }

        public void getAge()
        {
            Console.WriteLine("inserisci qui la tuà età");
            Age = int.Parse(Console.ReadLine());
        }

        public void getGeneral()
        {
            Console.WriteLine($"Il tuo nome è {Name}, il tuo cognome è {Surname}, la tua età è {Age}");
           
        }
    }
}
