using System.Collections.Generic;

namespace AlugaJogos.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Category> CategoryChild { get; set; }
        public Category CategoryFather { get; set; }
        public IList<Product> Products { get; set; }
    }
}
