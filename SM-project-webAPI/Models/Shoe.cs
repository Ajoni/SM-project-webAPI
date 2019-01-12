using System.ComponentModel.DataAnnotations;

namespace SMprojectWebAPI.Models
{
    public class Shoe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }
        public string ImgurImageId { get; set; }
    }
}
