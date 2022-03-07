using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Order
    {
        private string _orderNavn; 
        private double _skatPct;
        private double _leveringsomkostninger;
        Pizza _pizza;
        Customer _customer;
        Order _order; 
        


        public Order(Pizza pizza, Customer customer, string orderNavn, double skatPct, double leveringsomkostninger)
        {

            _orderNavn = orderNavn;
            _skatPct = skatPct;
            _leveringsomkostninger = leveringsomkostninger;
            _pizza = pizza;
            _customer = customer; 

        }


        public double SkatPct
        {
            get { return _skatPct; }
            set { _skatPct = value; }
        }

        public double LeveringsOmkostninger
        {
            get { return _leveringsomkostninger; }
            set { _leveringsomkostninger = value; }
        }


       
            

        public void PrintOrder()
        {
            Console.WriteLine($"{_orderNavn} : {_pizza.Navn}, med {_pizza.Tilbehør}, til {_pizza.Pris}");
            Console.WriteLine();
            Console.WriteLine($"Er lige blevet bestilt af {_customer.Navn} {_customer.EfterNavn} - {_customer.Addresse} - {_customer.TelefonNummer}");
            Console.WriteLine();
            Console.WriteLine($"Prisen for orderen med tax og levering inkluderet, bliver {CalculateTotalPrice()}");
        }
       

        public override string ToString() {
            return $"Procent: {SkatPct} - Levering: {LeveringsOmkostninger}:";
        }


        public double CalculateTotalPrice() 
        {
            double totalPris = (_pizza.Pris + LeveringsOmkostninger) * SkatPct;
            return totalPris; 

        }
                                   




    }
}
