using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace AlugaJogos.Product.Api.Filters
{
    public class ApiResponsesOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            operation.Responses.Add(
                "401",
                new OpenApiResponse { Description = "Unauthorized" });
        }
    }
}
