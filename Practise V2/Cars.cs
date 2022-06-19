using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_V2
{
    internal class Cars:Interface1
    {
        private int age;
        private string name;
        private int releasedata;
        private int price;
        

        public Cars(int age, string name, int releasedata, int price)
        {
            this.age = age;
            this.name = name;
            this.releasedata = releasedata;
            this.price = price;
        }
       public int Speed1   { get; set; }
        
        public virtual void Printvalues()
        {
            Console.WriteLine($"Age:{age}, Name:{name}, Releasedata:{releasedata}г., Price:{price}$");
        }
        public void CarsSpeed()
        {
            Console.WriteLine("Машинка гонит с кайфом");
        }
        
    }
}
