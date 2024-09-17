using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Core.Workflow
{
    internal class TeamLeaderApprovalHandler : ApprovalHandler
    {
        public override void Process(VacationRequest request)
        {
            // Team Leader can approve Developer request up to 3 days otherwise goes to Technical Manager.

            if (request.Employee.JobTitle == JobTitle.Developer && request.TotalDays <=3)
                Console.WriteLine("Request has been approved by Team Leader.");
            else
                CallNext(request);
        }        
    }
}
