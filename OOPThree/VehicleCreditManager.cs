using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPThree
{
    internal class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit Calculate");
        }

        public void Explanation()
        {
            throw new NotImplementedException();
        }
    }
}
