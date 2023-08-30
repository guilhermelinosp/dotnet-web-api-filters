using Microsoft.AspNetCore.Mvc.Filters;

namespace Sample.API.Configurations.Filters
{
    public class SecondAsyncActionFilterAttribute : Attribute,IAsyncActionFilter
    {
        private readonly string _actionName;

        public SecondAsyncActionFilterAttribute(string actionName)
        {
            _actionName = actionName;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"{_actionName} - Async FIlter : During Execution");
            await next();
            Console.WriteLine($"{_actionName} - Async FIlter : After Execution");
        }
    }
}
