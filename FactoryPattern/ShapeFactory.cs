using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/7 15:59:05
    /// Mail : tanz01@haid.com.cn
    /// Description : 
    /// </summary>
    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            switch (shapeType)
            {
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                case "Rectangle":
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}
