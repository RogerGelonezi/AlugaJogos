using AlugaJogos.Model;
using AlugaJogos.Product.Api.Models;
using System.Linq;
using System.Linq.Dynamic.Core;


namespace AlugaJogos.Product.Api.Extensions
{
    public static class OrderExtensions
    {
        public static IQueryable<IClass> ApplyOrder(this IQueryable<IClass> query, Order order)
        {
            if (order != null)
            {
                if (!string.IsNullOrEmpty(order.ThirdyPriority))
                {
                    query = query.OrderBy(order.ThirdyPriority);
                }

                if (!string.IsNullOrEmpty(order.SecondaryPriority))
                {
                    query = query.OrderBy(order.SecondaryPriority);
                }

                if (!string.IsNullOrEmpty(order.PrimaryPriority))
                {
                    query = query.OrderBy(order.PrimaryPriority);
                }
            }

            return query;
        }
    }
}
