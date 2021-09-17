﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FiltersDemo.Filters
{
    public class AuthorizeActionFilter : IAuthorizationFilter
    {
        private readonly string _permission;
        public AuthorizeActionFilter(string permission)
        {
            _permission = permission;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isAuthorized = Check(context.HttpContext.User, _permission);

            if (!isAuthorized) 
                context.Result = new UnauthorizedResult();
        }

        private bool Check(ClaimsPrincipal user, string permission)
        {
            //some logic
            return permission == "read";
        }
    }
}
