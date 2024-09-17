using DesignPatterns.ChainOfResponsibility.Core;
using DesignPatterns.ChainOfResponsibility.Core.Workflow;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class Program
    {
        /*
         * 15- Chain of Responsibility Design Pattern
            In 23 Design Patterns
            Type? Behavioural
            Why? chain of objects to process a request.
            Example: middlewares in dotnet.
            Example: Vacation day request approval workflow.
         */
        static void Main(string[] args)
        {
            /*
             * Vacation Request Workflow:
             * Team Leader can approve Developer request up to 3 days otherwise goes to Technical Manager.
             * Technical Manager can approve Developer request with more than 3 days and Team Leader requests.
             * CTO can approve Technical Manager requests.
             * CEO can approve CTO requests.
             */

            Employee employee = new Employee();
            employee.Name = "Mohammed Ali";
            employee.JobTitle = JobTitle.Developer;


            VacationRequest vacationRequest = new VacationRequest();
            vacationRequest.Employee = employee;
            vacationRequest.StartDate = DateTime.Today.AddDays(5);
            vacationRequest.EndDate = DateTime.Today.AddDays(6);

            var validationHandler = new VacationRequestDaysValidationHandler();
            var teamLeader = new TeamLeaderApprovalHandler();
            var technicalManager=new TechnicalManagerApprovalHandler();
            var cto=new CTOApprovalHandler();
            var ceo=new CEOApprovalHandler();
            validationHandler.SetNextHandler(teamLeader);
            teamLeader.SetNextHandler(technicalManager);
            technicalManager.SetNextHandler(cto);
            cto.SetNextHandler(ceo);


            validationHandler.Process(vacationRequest);

            Console.ReadKey();
        }
    }
}
