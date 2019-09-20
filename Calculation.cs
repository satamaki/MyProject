using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest1
{
    public class Calculation
    {
        private int a, b;
        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int execute(string pheptoan)
        {
            int kq = 0;
            switch(pheptoan)
            {
                case "+":
                    kq = this.a + this.b;
                    break;
                case "-":
                    kq = this.a - this.b;
                    break;
                case "*":
                    kq = this.a * this.b;
                    break;
                case "/":
                    kq = this.a / this.b;
                    break;
                    if (b == 0)
                        new DivideByZeroException("error");
                    kq = this.a / this.b;
                    break;
            }
            return kq;
        }
    }
}
