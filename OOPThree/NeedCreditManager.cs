using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPThree
{
    internal class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Nedd Credit Calculate");
        }

        public void Explanation()
        {
            throw new NotImplementedException();
        }
    }
}
