using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    [Table("Author")]
    public partial class Author

    {
        public string AuthorName { get; set; } = null!;
        public int AuthorId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
       
    }
}
