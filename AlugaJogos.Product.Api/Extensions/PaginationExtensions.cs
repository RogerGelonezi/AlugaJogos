using AlugaJogos.Model;
using AlugaJogos.Product.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AlugaJogos.Product.Api.Extensions
{
    public static class PaginationExtensions
    {
        public static async Task<Paged<IClass>> ToPagedAsync(this IQueryable<IClass> query, Pagination pagination, string controllerName)
        {
            int totalItems = query.Count();
            int totalPages = (int)Math.Ceiling(totalItems / (double)pagination.Size);
            return new Paged<IClass>()
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                PageNumber = pagination.Page,
                PageSize = pagination.Size,
                Result = await query
                    .Skip(pagination.Size * (pagination.Page - 1))
                    .Take(pagination.Size)
                    .ToListAsync(),
                Previous = (pagination.Page > 1) ? $"{controllerName}?page={pagination.Page - 1}&size={pagination.Size}" : "",
                Next = (pagination.Page < totalPages) ? $"{controllerName}?page={pagination.Page + 1}&size={pagination.Size}" : "",
            };
        }
    }
}
