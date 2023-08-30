using Microsoft.AspNetCore.Mvc.Filters;

namespace Sample.API.Configurations.Filters
{
    public class ActionFilterAttribute : Attribute,IActionFilter
    {
        private readonly string _callerName;

        public ActionFilterAttribute(string callerName)
        {
            _callerName = callerName;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"{_callerName} - This Filter Executed on: OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"{_callerName} - This Filter Executed on: OnActionExecuted");
        }
    }
}
 