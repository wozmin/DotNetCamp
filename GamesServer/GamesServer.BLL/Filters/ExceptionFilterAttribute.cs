using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GamesServer.BLL.Filters
{
    class ExceptionFilterAttribute:Attribute,IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            
        }
    }
}

