using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyClassLibrary1;

public class BMW:Car
{
    public BMW(string name, string model, double year, string version) : base(name, model, year, version) 
    {

    }
    
}
