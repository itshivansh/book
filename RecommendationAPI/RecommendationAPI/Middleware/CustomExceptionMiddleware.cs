using Microsoft.AspNetCore.Http;
using RecommendationAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RecommendationAPI.Middleware
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context); //invoke next middleware in pipeline
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        public async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            var exceptionType = exception.GetType();
            var message = exception.Message;
            if (exceptionType == typeof(RecommendNotFound))
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            else if (exceptionType == typeof(RecommendNotAdded))
            {
                response.StatusCode = (int)HttpStatusCode.Conflict;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            response.ContentType = "application/json";
            await response.WriteAsync(message);
        }

    }
}
