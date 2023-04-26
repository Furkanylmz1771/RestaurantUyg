using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantExample
{
    public class program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            restaurant.Name = "BigRess";
            restaurant.Address = "İstiklal cad.";
            restaurant.BahşişOranı = .20;


            Console.WriteLine("{0}", restaurant.Name);
            Console.WriteLine("{0}", restaurant.Address);


            restaurant.GenerateReceipt();

        }
    }
}
