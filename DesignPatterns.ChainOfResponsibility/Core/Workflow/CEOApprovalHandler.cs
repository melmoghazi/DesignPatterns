using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Core.Workflow
{
    internal class CEOApprovalHandler : ApprovalHandler
    {
        public override void Process(VacationRequest request)
        {
            // CEO can approve CTO requests.
            if (request.Employee.JobTitle == JobTitle.CTO)
                Console.WriteLine("Request has been approved by CEO");
            else
                CallNext(request);
        }
    }
}
