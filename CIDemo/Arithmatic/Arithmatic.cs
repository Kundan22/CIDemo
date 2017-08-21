using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic
{
    /// <summary>
    /// Simple Arithmatic operations
    /// </summary>
    public class Arithmatic
    {
        public static Int32 Add(Int32 var1, Int32 var2)
        {
            return var1 + var2;
        }

        public static Int32 Subtract(Int32 var1, Int32 var2)
        {
            return var1 - var2;
        }

        public static Int32 Multiply(Int32 var1, Int32 var2)
        {
            return var1 * var2;
        }

        public static decimal Devide(double var1, double var2)
        {
            return decimal.Round((decimal)(var1 / var2), 2);
        }
    }
}