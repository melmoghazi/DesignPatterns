using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Core.Workflow
{
    internal class VacationRequestDaysValidationHandler : ApprovalHandler
    {
        public override void Process(VacationRequest request)
        {
            if (request != null && request.TotalDays < 1)
                Console.WriteLine("Request has been rejected because of invalid days.");
            else
                CallNext(request);
        }
    }
}
