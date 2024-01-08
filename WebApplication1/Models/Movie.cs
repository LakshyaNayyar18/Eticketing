using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Controllers.Data.Enums;

namespace WebApplication1.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string ImageURL { get; set; }
     
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        //producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
     
        public Producer Producer { get; set; }


    }
}
