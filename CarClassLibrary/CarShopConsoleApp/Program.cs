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

			Store newStore = new Store();

            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

			int action = chooseAction();

			while (action != 0)
			{
                Console.WriteLine($"You chose {action}.");

				switch (action)
				{
					// Add to inventory
					case 1:
						Console.WriteLine("You chose to add a new car to the invenory.");

						string carMake = "";
						string carModel = "";
						decimal carPrice = 0;

                        Console.WriteLine("What is the car make?");
						carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model?");
						carModel = Console.ReadLine();

                        Console.WriteLine("What is the car price?");
						carPrice = int.Parse(Console.ReadLine());

						Car newCar = new Car(carMake, carModel, carPrice);

						newStore.CarList.Add(newCar);

						printInventory(newStore);
						break;

					// Add to cart
					case 2:

                        Console.WriteLine("You chose to add a car to your shopping cart.");
						printInventory(newStore);

                        Console.WriteLine("Which item would you like to buy? (number)");
						int carChosen = int.Parse(Console.ReadLine()) - 1;

						newStore.ShoppingList.Add(newStore.CarList[carChosen]);

						printShoppingList(newStore);

                        break;


                    default:
						break;
				}

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

		private static void printShoppingList(Store newStore)
		{
            Console.WriteLine("Cars you have chosen to buy:");
            for (int i = 0; i < newStore.ShoppingList.Count; i++)
			{
				Console.WriteLine(newStore.ShoppingList[i]);
				Console.WriteLine("___________");
			}
		}

		private static void printInventory(Store newStore)
		{
			Console.WriteLine("_______________________");

			for (int i = 0; i < newStore.CarList.Count; i++)
			{
                Console.WriteLine($"Car:\n#{i + 1}\n{newStore.CarList[i]}");
                Console.WriteLine("___________");
            }

			Console.WriteLine("_______________________");

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
