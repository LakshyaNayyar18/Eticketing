using System.Net.Mime;
using WebApplication1.Controllers.Data.Enums;
using WebApplication1.Models;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication1.Controllers.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                        {
                        new Cinema()
                        {
                            name="cinema1",
                            logo="",
                            description="this is description 1"
                        },
                        new Cinema()
                        {
                            name="cinema1",
                            logo="",
                            description="this is description 1"

                        },
                        new Cinema()
                        {
                             name="cinema1",
                            logo="",
                            description="this is description 1"
                        },
                    });
                    context.SaveChanges();

                }
                //actors
                if (!context.Actors.Any())

                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName="Actor1",
                            bio="This is the bio of the actor",
                            ProfilePictureURL=""
                        },
                         new Actor()
                        {
                            FullName="Actor1",
                            bio="This is the bio of the actor",
                            ProfilePictureURL=""
                        },
                          new Actor()
                        {
                            FullName="Actor1",
                            bio="This is the bio of the actor",
                            ProfilePictureURL=""
                        },

                    });
                    context.SaveChanges();
                }
                //producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                        {
                        new Producer()
                        {
                            FullName="producer1",
                            bio="this is the bio",
                            ProfilePictureURL=""
                        },
                         new Producer()
                         {
                             FullName = "producer1",
                             bio = "this is the bio",
                             ProfilePictureURL = ""
                         },
                          new Producer()
                          {
                              FullName = "producer1",
                              bio = "this is the bio",
                              ProfilePictureURL = ""
                          }
                    });
                    context.SaveChanges();

                }
                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            name="life",
                            description="this is the life movie description",
                           
                            ImageURL="",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(10),
                            CinemaId=3,
                            ProducerId=5,
                            MovieCategory=MovieCategory.Drama

                        },
                        new Movie()
                        {
                            name="life",
                            description="this is the life movie description",
                            ImageURL="",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(10),
                            CinemaId=2,
                            ProducerId=4,
                            MovieCategory=MovieCategory.Drama

                        },
                        new Movie()
                        {
                            name="life",
                            description="this is the life movie description",
                            ImageURL="",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(10),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Drama

                        }
                    });
                    context.SaveChanges();

                }
                //actors&movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=1
                        },
                         new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=1
                        },
                          new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=2
                        },
                          new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=2
                        },
                          new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=3
                        },
                          new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=3
                        },
                          new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=3
                        },
                          new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=4
                        },
                         new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=4
                        },
                         new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=4
                        },
                          new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=5
                        },
                           new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=5
                        },
                            new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=5
                        },
                             new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=5
                        },

                    });
                    context.SaveChanges();
                }


            }
        }
    }
}
