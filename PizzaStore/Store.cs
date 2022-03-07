using System;

namespace PizzaStore
{
    class Store
    {
        public static void Start() 
        {

            
                Pizza pizza1 = new Pizza("Hawaii", "Ananas", 70);
                Pizza pizza2 = new Pizza("SkinkePiza", "Skinke", 65);
                Pizza pizza3 = new Pizza("PepperoniPizza", "Pepperoni", 60);

    

                Customer Customer1 = new Customer("Hans", "Hansen", "4100 Ringsted", 1234567890);
                Customer Customer2 = new Customer("Jens", "Jensen", "4300 Holbæk", 1234567890);
                Customer Customer3 = new Customer("Jørgen", "Jørgnesen", "4440 Mørkøv", 1234567890);

                Order order1 = new Order(pizza1, Customer1, "Ordre nummer 1", 1.1, 40);
                Order order2 = new Order(pizza2, Customer2, "Ordre nummer 2", 1.1, 40);
                Order order3 = new Order(pizza3, Customer3, "Ordre nummer 3", 1.1, 40);



                    Console.WriteLine("Velkommen til Big mamas pizzaria, nedenunder kan du se menukortet");
                    Console.WriteLine();
                    Console.WriteLine(pizza1.ToString());
                    Console.WriteLine();
                    Console.WriteLine(pizza2.ToString());
                    Console.WriteLine();
                    Console.WriteLine(pizza3.ToString());

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"Tryk på en hvilket som helst knap for at se de seneste ordre");
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Der er kommet en ordre!");
                    Console.WriteLine();
                    order1.PrintOrder();
                    Console.WriteLine();
                    Console.WriteLine("Tryk på en tast for at fortsætte");
                    Console.ReadLine();
                    Console.WriteLine();
                    order2.PrintOrder();
                    Console.WriteLine();
                    Console.WriteLine("Tryk på en tast for at fortsætte");
                    Console.ReadLine();
                    Console.WriteLine();
                    order3.PrintOrder();
                }
            }
      }
    

