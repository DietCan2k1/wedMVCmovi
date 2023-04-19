namespace MoviWed.Models
{
    public class CategoryModels : BaseModels
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Slug { get; set; } = null!;

        public int Status { get; set; }

    }
}
