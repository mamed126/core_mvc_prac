using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace FiltersDemo.Filters
{
    public class CacheResourceFilter : IResourceFilter
    {
        private static  readonly Dictionary<string, object> _cache = new Dictionary<string, object>();
        private string _cacheKey;

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            if (!string.IsNullOrEmpty(_cacheKey) && !_cache.ContainsKey(_cacheKey))
            {
                var result = context.Result as ContentResult;

                if (result != null)
                    _cache.Add(_cacheKey, result.Content);
            }
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _cacheKey = context.HttpContext.Request.Path.ToString();

            if (_cache.ContainsKey(_cacheKey))
            {
                var cachedValue = _cache[_cacheKey] as string;

                if (cachedValue != null)
                {
                    context.Result = new ContentResult() { Content = cachedValue };
                }
            }
          
        }
    }
}
