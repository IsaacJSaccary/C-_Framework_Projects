using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class math1
    {
        public int SubFive(int num1)
        {
            return num1 - 5;
            
        }
        public int SubFive(decimal num1)
        {
            int newnum = Convert.ToInt32(num1);
            return newnum / 2;
        }
        public int SubFive(string num1)
        {
            int newnum = Convert.ToInt32(num1);
            return newnum * 63;
        }
    }
}
