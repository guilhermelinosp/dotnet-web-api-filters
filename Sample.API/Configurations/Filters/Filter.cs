using Microsoft.AspNetCore.Mvc.Filters;

namespace Sample.API.Configurations.Filters
{
    public class Filter: IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"This Filter Executed on: OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"This Filter Executed on: OnActionExecuted");
        }
    }
}
