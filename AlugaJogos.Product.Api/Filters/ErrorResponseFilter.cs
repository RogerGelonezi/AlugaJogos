using AlugaJogos.Product.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AlugaJogos.Product.Api.Filters
{
    public class ErrorResponseFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var errorResponse = ErrorResponse.FromException(context.Exception);
            context.Result = new ObjectResult(errorResponse) { StatusCode = 500 };
        }
    }
}
