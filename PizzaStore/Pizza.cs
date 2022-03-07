using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
   public class Pizza
    {
       private string _navn;
       private string _tilbehør;
       private int _pris;

      

        public Pizza(string Navn, string Tilbehør, int Pris)
        {

            _navn = Navn;
            _tilbehør = Tilbehør;
            _pris = Pris;


        }


        public string Navn
        {
            get { return _navn;  }
        }



        public string Tilbehør
        {
            get { return _tilbehør; }
        }

        

        public int Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

       

        public override string ToString() {
            return $": {Navn} - Tilbehør: {Tilbehør} - Pris: {Pris}"; 
        }




    }


}
