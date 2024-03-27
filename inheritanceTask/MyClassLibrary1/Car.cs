using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1;
public class Car
    {
        public Car(string name,string model, double year, string version)
        {
            Name = name;
            Model = model;
            Year = year;
            Version = version;
        }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Year { get; set; }
        public string Version { get; set; }
        
    public virtual void AboutCar()
    {
        Console.WriteLine($"\nCar's Name:{Name}\nModel:{Model}\nYear:{Year}\nVersion:{Version}");
    } 
  }


