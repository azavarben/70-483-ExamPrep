using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {

        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        
        public string ToString(string name, Func<string, string> formatter)
        {
            return formatter(name);
        }
    }
}
