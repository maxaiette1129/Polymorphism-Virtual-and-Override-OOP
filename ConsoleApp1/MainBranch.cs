using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
     public class MainBranch
    {
        public  string name {get;set;}
        public  string location { get;set;}
        public   string ceo {get;set;}

        public MainBranch(string name, string location, string ceo)
        {
            this.name = name;
            this.location = location;
            this.ceo = ceo;
        }
        virtual public void print()
        {
            Console.WriteLine(name + " " + location + " " + ceo);
        }

        
    }
}
