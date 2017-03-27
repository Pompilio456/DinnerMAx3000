using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000Console
{
    //truco para acceder a la clase de cualquier obj : F12
    //truco para volver a la clase anterioir : ctrl, -
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Norwegian salmon with butter", 25.50);
            summerMenu.AddMenuItem("Robalo", "Colombian robalo with butter", 25.50);
            summerMenu.HospitalDirections="Alli abajito";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code";
            outsideDrinks.AddMenuItem("Aguila", "Cerveza colombiana",4);
            outsideDrinks.AddMenuItem("Apostol", "Cerveza colombiana", 4);

            Order hungryGuestOrder = new Order();

            for (int i = 0; i <= summerMenu.Items.Count-1; i++)
            {
                MenuItem currentItem = summerMenu.Items[i];
                hungryGuestOrder.Item.Add(currentItem);
            }
            foreach (MenuItem currentItem in outsideDrinks.Items)
            {
                hungryGuestOrder.Item.Add(currentItem);
            }

            Console.WriteLine("The total is: "+hungryGuestOrder.Total);

            try
            {
                outsideDrinks.AddMenuItem("Apostol", "Cerveza colombiana", 0);
            }
            catch(Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }

            Console.ReadKey();
        }
    }
}
