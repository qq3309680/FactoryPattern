using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/7 15:57:19
    /// Mail : tanz01@haid.com.cn
    /// Description : 
    /// </summary>
    public  class Rectangle:Shape
    {
        public void Draw()
        {
            Console.WriteLine("我是长方形.");
        }
    }
}
