using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1 : MainBranch
    {
        public string branchid { get; set; }
        public Class1(string name,string location, string ceo, string branchid) : base(name, location, ceo)
        {
            this.branchid = branchid;
        }
        public override void print()
        {

            Console.WriteLine(name + " " + location + " " + ceo + " " + branchid);
            
         
        }

    }
}
