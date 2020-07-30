using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
   public  class Derived : BaseClass
    {
        public override void DoWork() // Переопределяет виртуальный метод из базового класса BaseClass
        {
            Console.WriteLine("Метод из производного класса"); 
        }
       public void DoWork2() { Console.WriteLine("Этого метода не видно при апкасте до базового класса"); }
    }
}
