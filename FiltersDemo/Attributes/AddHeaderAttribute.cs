using FiltersDemo.Filters;
using Microsoft.AspNetCore.Mvc;

namespace FiltersDemo.Attributes
{
    public class AddHeaderAttribute:TypeFilterAttribute
    {
        public AddHeaderAttribute() : base(typeof(AddHeaderFilter))
        {

        }
    }
}
