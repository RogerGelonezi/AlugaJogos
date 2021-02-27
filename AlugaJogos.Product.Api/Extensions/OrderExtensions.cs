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
                if (!string.IsNullOrEmpty(order.OrderThirdyPriority))
                {
                    query = query.OrderBy(order.OrderThirdyPriority);
                }

                if (!string.IsNullOrEmpty(order.OrderSecondaryPriority))
                {
                    query = query.OrderBy(order.OrderSecondaryPriority);
                }

                if (!string.IsNullOrEmpty(order.OrderPrimaryPriority))
                {
                    query = query.OrderBy(order.OrderPrimaryPriority);
                }
            }

            return query;
        }
    }
}
