using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            Shape cir = factory.getShape("Circle");
            cir.Draw();
            Shape squrae = factory.getShape("Square");
            squrae.Draw();
            Shape rec = factory.getShape("Rectangle");
            rec.Draw();
            Console.ReadLine();
        }
    }
}
