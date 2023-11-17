using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();

            Console.WriteLine("Car car is as follows " 
				+ car.Make + " " 
				+ car.Model + " " 
				+ car.Price);
        }
	}
}
