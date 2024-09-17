using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Core.Workflow
{
    internal class TechnicalManagerApprovalHandler : ApprovalHandler
    {
        public override void Process(VacationRequest request)
        {
            // Technical Manager can approve Developer request with more than 3 days and Team Leader requests.
            if (request.Employee.JobTitle == JobTitle.Developer && request.TotalDays > 3 ||
                            request.Employee.JobTitle == JobTitle.TeamLeader)
            {
                Console.WriteLine("Request has been approved by Technical Manager");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
