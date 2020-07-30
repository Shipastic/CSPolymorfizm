using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
  public  class Versioning2
    {
        public void DoWork()
        {
            PreDoWork();
            CoreDoWork();
        }
        protected virtual void PreDoWork() { Console.WriteLine("метод PreDoWork класса  {0}", GetType().Name); }
        protected virtual void CoreDoWork() { Console.WriteLine("метод CoreDoWork класса  {0}", GetType().Name); }
    }
    public class Derived2 : Versioning2
    {
        protected override void CoreDoWork()
        {
            Console.WriteLine("метод CoreDoWork класса  {0}", GetType().Name);
        }
       
    }
}
