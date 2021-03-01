namespace AlugaJogos.Model
{
    public class ProductProperty
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Property Property { get; set; }
        public string Value { get; set; }
    }
}
