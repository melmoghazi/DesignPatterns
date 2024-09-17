using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Core.Workflow
{
    internal class CTOApprovalHandler : ApprovalHandler
    {
        public override void Process(VacationRequest request)
        {
            // CTO can approve Technical Manager requests.
            if (request.Employee.JobTitle == JobTitle.TechnicalManager)
                Console.WriteLine("Request has been approved by CTO");
            else 
                CallNext(request);
        }
    }
}
