using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Time
    {
        public int addTen(int num1)
        {
            int answer = num1 + 10;
            return answer;
        }
        public int addTwenty(int num2)
        {
            int answer = num2 + 20;
            return answer;
        }
        public int addThirty(int num3)
        {
            int answer = num3 + 30;
            return answer;
        }

    }
}

