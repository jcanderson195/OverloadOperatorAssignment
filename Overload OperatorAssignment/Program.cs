using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_OperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Justin = new Person("Justin", "Anderson", 20, new DateTime(1995, 06, 10));
            Justin.Overloadperson();
            Console.ReadKey();


        }
    }
}
