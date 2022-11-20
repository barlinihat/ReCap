using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPThree
{
    class RecourseManager
    {
        public void RecourseDo(ICreditManager creditManager, ILoggerService loggerService)
        {
            HousingCreditManager housingCreditManager = new HousingCreditManager(); 
            creditManager.Calculate();

            loggerService.Log();
        }

        public void CreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate(); 
            }
        }
    }
}
