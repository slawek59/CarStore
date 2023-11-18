﻿using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Car carOne = new Car() { Make = "Audi", Model = "A6", Price = 10.000M};
            //Car carTwo = new Car() { Make = "Volkswagen", Model = "Passat", Price = 100.000M};

            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

			int action = chooseAction();

			while (action != 0)
			{
                Console.WriteLine($"You chose {action}.");
				action = chooseAction();
            }

   //         Car carOne = new Car("Audi", "A6", 10.000M);
			//Car carTwo = new Car("Volkswagen", "Passat", 100.000M);
			
   //         Console.WriteLine("Car carOne is as follows: " 
			//	+ carOne.Make + " " 
			//	+ carOne.Model + " " 
			//	+ carOne.Price + "$");

   //         Console.WriteLine("Car carTwo is as follows: " 
			//	+ carTwo.Make + " " 
			//	+ carTwo.Model + " " 
			//	+ carTwo.Price + "$");

			//Store storeOne = new Store();

			//storeOne.ShoppingList.Add(carOne);
			//storeOne.ShoppingList.Add(carTwo);

			//decimal total = storeOne.Checkout();

   //         Console.WriteLine("Total: " + total);

        }
		static public int chooseAction()
		{
			int choice = 0;
            Console.WriteLine("Choose an action (0) to quit, (1) to add a new car to the inventory, (2) to add a car to the cart or (3) to checkout.");

			try
			{
				choice = int.Parse(Console.ReadLine());

			}
			catch (Exception)
			{

				throw new Exception("Action number should be an int.");
			}
			return choice;
        }
	}
}
