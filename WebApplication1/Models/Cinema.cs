using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "logo")]
        public string logo { get; set; }
        [Display(Name = "name")]
        public string name { get; set; }
        [Display(Name = "description")]
        public string description { get; set; }
        //relationship
        public List<Movie> Movies { get; set; }
    }
}
