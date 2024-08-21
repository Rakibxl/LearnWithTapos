namespace ProductCategoryApi.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
