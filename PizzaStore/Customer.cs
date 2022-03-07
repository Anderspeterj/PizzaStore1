using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Customer
    {
        string _navn;
        string _efterNavn;
        string _addresse;
        int _telefonNummer;


        public Customer(string Navn, string EfterNavn, string Addresse, int TelefonNummer)
        {

            _navn = Navn;
            _efterNavn = EfterNavn;
            _addresse = Addresse;
            _telefonNummer = TelefonNummer;

        }



        public string Navn
        {
            get { return _navn; }
        }
        
        public string EfterNavn
        {
            get { return _efterNavn; }
        }

        public string Addresse
        {
            get { return _addresse; }
        }

        public int TelefonNummer
        {
            get { return _telefonNummer; }
        }


        public override string ToString() {
            return $" {Navn} {EfterNavn} : {Addresse} : {TelefonNummer}";
        }



    }

    

}
