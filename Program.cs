using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance = new Derived(); // Апкаст производного класса до базового
            // При таком способе приведения будут доступны методы только из базвого класса
            instance.DoWork();
            Derived derived = new Derived();
            Console.WriteLine(new string('=',30));
            derived.DoWork2();  // А так доступны все методы
            Console.WriteLine(new string('=', 30));
            Versioning2 versioning2 = new Derived2();
            versioning2.DoWork();
            Console.ReadKey();
        }
    }
}
