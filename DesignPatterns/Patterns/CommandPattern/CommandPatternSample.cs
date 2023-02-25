﻿namespace DesignPatterns.Patterns.CommandPattern
{
    public class CommandPatternSample : ISampleRunner
    {
        public void Run()
        {
            var customer = new Customer();
            var fries = new MenuItem("French Fries", 2, 1.99);

            customer.SetCommand(1 /*Add*/);
            customer.SetMenuItem(fries);
            customer.ExecuteCommand();

            customer.SetCommand(1 /*Add*/);
            customer.SetMenuItem(new MenuItem("Hamburger", 2, 2.59));
            customer.ExecuteCommand();

            customer.SetCommand(1 /*Add*/);
            customer.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            customer.ExecuteCommand();

            customer.ShowCurrentOrder();

            //Remove the french fries
            customer.SetCommand(3 /*Remove*/);
            customer.SetMenuItem(fries);
            customer.ExecuteCommand();

            customer.ShowCurrentOrder();

            //Now we want 4 hamburgers rather than 2
            customer.SetCommand(2 /*Edit*/);
            customer.SetMenuItem(new MenuItem("Hamburger", 4, 2.59));
            customer.ExecuteCommand();

            customer.ShowCurrentOrder();

            Console.ReadKey();
        }
    }
}
