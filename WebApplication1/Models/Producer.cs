using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string bio { get; set; }
        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
