namespace ProjetoLoja.Models
{
    public class ProductSupplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Store> Stores { get; set; }
    }
}
