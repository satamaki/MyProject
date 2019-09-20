using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest1
{
    public class MyPower
    {
        public static double power (double x , int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return x * power(x, n - 1);
            else
                return power(x, n + 1) / x;
        }
    }
}
