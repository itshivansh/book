using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RecommendationAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Utilities
{
    public class ExceptionHandlerAttribute: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exceptionType = context.Exception.GetType();
            var message = context.Exception.Message;
            // if recomend not found exception is encountered
            if (exceptionType == typeof(RecommendNotFound))
            {
                var result = new NotFoundObjectResult(message);
                context.Result = result;
            }
            //if recomend not created exception is encountered
            else if (exceptionType == typeof(RecommendNotAdded))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }
            else
            {
                var result = new StatusCodeResult(500);
                context.Result = result;
            }
        }
    }
}
