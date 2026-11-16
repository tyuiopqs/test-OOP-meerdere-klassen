using System;
using System.Collections.Generic;
using System.Text;

namespace test_OOP_meerdere_klassen
{
    internal class Factuur
    {
        List<Factuurlijn> _factuurLijnen;
        public int FactuurID { get; set; }
        public List<Factuurlijn> FactuurLijnen { get; private set; }
        public int KlantID { get; set; }
        public string KlantNaam { get; set; }

        public Factuur()
        {

        }

        public Factuur(int factuurID, int klantID, string klantNaam)
        {
            factuurID = FactuurID;
            klantID = KlantID;
            klantNaam = KlantNaam;
        }

        public override string ToString()
        {
            
        }

        public double BerekenFactuurTotaal()
        {
            
        }

        public void VoegFactuurLijnToe(int aantal, string productNaam, double prijs)
        {
            Factuurlijn objFactuurlijn = new Factuurlijn(aantal, productNaam, prijs);

            _factuurLijnen.Add(objFactuurlijn);

            

            
            
        }



    }
}
