using System.Collections.Generic;

namespace AlugaJogos.Product.Api.Models
{
    public class Pagination
    {
        public int Page { get; set; } = 1;
        public int Size { get; set; } = 25;
    }

    public class Paged<TEntity> where TEntity : class
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public IList<TEntity> Result { get; set; }
        public string Previous { get; set; }
        public string Next { get; set; }
    }
}
