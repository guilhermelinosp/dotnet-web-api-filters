using Microsoft.AspNetCore.Mvc.Filters;

namespace Sample.API.Configurations.Filters
{
    public class AsyncActionFilterAttribute : Attribute,IAsyncActionFilter, IOrderedFilter
    {
        private readonly string _actionName;
        public int Order { get; set; }
        public AsyncActionFilterAttribute(string actionName, int order)
        {
            _actionName = actionName;
            Order = order;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"{_actionName} - Async FIlter : During Execution");
            await next();
            Console.WriteLine($"{_actionName} - Async FIlter : After Execution");
        }


    }
}
