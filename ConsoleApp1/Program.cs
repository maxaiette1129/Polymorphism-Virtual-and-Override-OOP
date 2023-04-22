using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            MainBranch mb = new MainBranch("Nestlea", "Tan", "Manila");
            MainBranch sb = new Class1("Kopiko", "Max", "Cubao","1");

           
            mb.print();
            sb.print();

        }
    }
}
