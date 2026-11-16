using System;
using System.Collections.Generic;
using System.Text;

namespace test_OOP_meerdere_klassen
{
    internal class Factuurlijn
    {
        public int Aantal { get; set; }
        public double Prijs { get; set; }
        public string ProductNaam { get; set; }

        public Factuurlijn()
        {

        }

        public Factuurlijn(int aantal, string productNaam, double prijs)
        {
            aantal = Aantal;
            productNaam = ProductNaam;
            prijs = Prijs;
        }

        public override string ToString()
        {
            return 
        }
    }
}
