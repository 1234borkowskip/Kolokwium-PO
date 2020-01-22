using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        abstract class Osoba
        {
            readonly string nazwa;
            public Osoba(string nazwa)
            {
                this.nazwa = nazwa;
            }
        }

        class Klient : Osoba
        {
            public Klient(string nazwa) : base(nazwa)
            {
            }
        }

        interface IKasjer
        {
            void Obsluz(Klient k);
        }

        interface IBok
        {
             void Obsluz(Klient k);
        }

        class PracownikMiesiaca : Osoba, IKasjer, IBok
        {
            public PracownikMiesiaca(string nazwa) : base(nazwa)
            {
            }

            public void Obsluz(Klient k)
            {

            }
        }

    }
}
