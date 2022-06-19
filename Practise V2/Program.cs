using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что вас интересует Машина, Грузовик или Тачка?");
            string answ = Console.ReadLine();
            switch (answ)
            {
                case "Машина":
                    {
                        Cars car = new Cars(12, "Хонда Аккорд", 2010, 500);
                        car.Printvalues();
                        car.CarsSpeed();
                        break;
                    }
                case "Грузовик":
                    {
                        truck truck = new truck(15, "Грузовая тачила", 2018, 1000, 500);
                        truck.Printvalues();
                        truck.CarsSpeed();
                        break;

                    }
                case "Тачка":
                    {
                        Ta4ka ta4ka = new Ta4ka(5, "Тачка крутачка",2020, 100, 20);
                        ta4ka.Printvalues();
                        ta4ka.CarsSpeed();
                        break;
                    }
            }
           
        }
    }
}
