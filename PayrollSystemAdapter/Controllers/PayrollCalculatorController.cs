using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollSystemAdapter.Core;

namespace PayrollSystemAdapter.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PayrollCalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<Decimal> Calculate(Employee employee)
        {
            var calculator=new PayrollCalculator();
            return Ok(calculator.Calculate(employee));
        }
    }
}
