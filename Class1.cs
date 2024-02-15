using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment2
{
    public class Class1
    {
        public int checkFact(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * checkFact(n - 1);

        }
    }
}
