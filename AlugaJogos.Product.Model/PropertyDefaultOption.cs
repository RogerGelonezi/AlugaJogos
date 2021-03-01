namespace AlugaJogos.Model
{
    public class PropertyDefaultOption
    {
        public int Id { get; set; }
        public Property Property { get; set; }
        public string DefaultValue { get; set; }
        public int Order { get; set; }
    }
}
