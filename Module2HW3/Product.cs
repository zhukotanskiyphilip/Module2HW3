namespace Module2HW3
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
            Price = 0f;
            Weight = 0;
        }

        public string? Name { get; set; }
        public float Price { get; set; }
        public int Weight { get; set; }
    }
}
