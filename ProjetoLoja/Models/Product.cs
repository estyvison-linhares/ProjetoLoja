namespace ProjetoLoja.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Validade { get; set; }
    }
}
