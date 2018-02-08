using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/7 15:56:06
    /// Mail : tanz01@haid.com.cn
    /// Description : 
    /// </summary>
    public  class Square:Shape
    {
        public void Draw()
        {
            Console.WriteLine("我是正方形.");
        }
    }
}
