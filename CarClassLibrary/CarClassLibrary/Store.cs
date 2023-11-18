using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
	public class Store
	{
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            this.CarList = new List<Car>();
            this.ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (var car in ShoppingList)
            {
                totalCost += car.Price;
            }

            ShoppingList.Clear();
            return totalCost;
        }
    }
}
