using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Core.Workflow
{
    internal interface IApprovalHandler
    {
        void SetNextHandler(IApprovalHandler nextHandler);
        void Process(VacationRequest request);
    }
}
