using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPThree
{
    internal class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing Credit Calculate");
        }

        public void Explanation()
        {
            throw new NotImplementedException();
        }
    }
}
