using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_V2
{
    internal class truck : Cars, Interface1
    {
        public int power { get; set; }

        public truck(int age, string name, int releasedata, int price, int power) : base(age, name, releasedata, price)
        {
            this.power = power;
        }
       public int Speed1   { get; set; }
        public override void Printvalues()
        {
            base.Printvalues();
            Console.WriteLine("Мощность:" + power +" " + "Лошадиных сил");
        }
        public void CarsSpeed()
        {
            Console.WriteLine("Фура едет с кайфом");
        }
        

    }
}
