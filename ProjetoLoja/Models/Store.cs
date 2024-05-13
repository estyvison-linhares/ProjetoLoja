namespace ProjetoLoja.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        public ProductSupplier ProductSupplier { get; set; }
        public int ProductSupplierId { get; set; }
    }
}
