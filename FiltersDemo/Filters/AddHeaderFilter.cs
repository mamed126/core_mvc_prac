using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FiltersDemo.Filters
{
    public class AddHeaderFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
           // throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("OnResultExecuting", "This header added by result filter");
        }
    }
}
