using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_V2
{
    internal class Ta4ka : Cars, Interface1
    {
        public int speed { get; set; }

        public Ta4ka(int age, string name, int releasedata, int price, int speed) : base(age,name,releasedata,price)
        {
            this.speed= speed;
        }
        public int Speed1 { get; set; }

        public override void Printvalues()
        {
            base.Printvalues();
            Console.WriteLine("Скорость:" + speed + "Км/Ч");
        }
        public void CarsSpeed()
        {
            Console.WriteLine("Тачка гонит с кайфом");
        }
      
    }
}
