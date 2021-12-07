using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            LineParam MyEquation = new LineParam();  

            MyEquation.k = 10;
            MyEquation.b = 20;

            MyEquation.ResolveEquation();

            Console.WriteLine("Ответ: {0}", MyEquation.result);

            Console.ReadKey();

        }
    }

    public struct LineParam
    {
        public double k;
        public double b;
        public double result;

        public void ResolveEquation()
        {
            result = -b / k;
        }
    }

}
