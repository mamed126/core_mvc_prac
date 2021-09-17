using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace FiltersDemo.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IModelMetadataProvider _provider;
        public CustomExceptionFilter(IModelMetadataProvider provider)
        {
            _provider = provider;
        }
        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult ();

            result.ViewName = "CustomError";
            result.ViewData = new ViewDataDictionary(_provider, context.ModelState);
            result.ViewData.Add("Exception", context.Exception);

            context.ExceptionHandled = true;
            context.Result = result;

        }
    }
}
