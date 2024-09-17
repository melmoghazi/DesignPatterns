using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Core.Workflow
{
    internal abstract class ApprovalHandler : IApprovalHandler
    {
        private IApprovalHandler _next;
        public abstract void Process(VacationRequest request);
        public void SetNextHandler(IApprovalHandler nextHandler)
        {
            _next = nextHandler;
        }
        protected void CallNext(VacationRequest request)
        {
            if (_next != null) 
                _next.Process(request);
        }
    }
}
