using FiltersDemo.Filters;
using Microsoft.AspNetCore.Mvc;

namespace FiltersDemo.Attributes
{
    public class CacheResourceAttribute:TypeFilterAttribute
    {
        public CacheResourceAttribute():base(typeof(CacheResourceFilter))
        {

        }
    }
}
