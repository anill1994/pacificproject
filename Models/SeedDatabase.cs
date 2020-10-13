using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacificProject.Models
{
    public static class SeedDatabase
    {
        public static void Seed(IApplicationBuilder app)
        {
            PacificContext context = app.ApplicationServices.GetRequiredService<PacificContext>();
            context.Database.Migrate();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Destinations.Count() == 0)
                {
                    context.Destinations.AddRange(Destinations);
                }
                if (context.Blogs.Count() == 0)
                {
                    context.Blogs.AddRange(Blogs);
                }
                if (context.Comments.Count() == 0)
                {
                    context.Comments.AddRange(Comments);
                }
            }
            context.SaveChanges();
        }
             private static Destination[] Destinations =
               {
                    new Destination(){DestinationId=1,Country="Turkey",Place="Kuş Adası",Tour=4,CountryImage="1.jpg",PlaceImage="1.jpg",Price=550,TourDayCount=7},
                    new Destination(){DestinationId=2,Country="Canada",Place="Green Mountain",Tour=3,CountryImage="1.jpg",PlaceImage="1.jpg",Price=600,TourDayCount=10},
                    new Destination(){DestinationId=3,Country="Philippines",Place="Long Valley",Tour=2,CountryImage="1.jpg",PlaceImage="1.jpg",Price=700,TourDayCount=8}
                };
             private static Blog[] Blogs =
             {
                    new Blog(){BlogId=1,Title="Most Beatufil Places",Date=DateTime.Now,Image="1.jpg"},
                    new Blog(){BlogId=2,Title="Interesting Places",Date=DateTime.Now,Image="1.jpg"},
                    new Blog(){BlogId=3,Title="Our Choices",Date=DateTime.Now,Image="1.jpg"},
             };
            private static Comment[] Comments =
            {
                    new Comment(){CommentId=1,Name="John Doe", Explanation="This place was really good",Image="1.jpg", Job="Customer Manager", Star=5},
                    new Comment(){CommentId=2,Name="Anıl Aydın", Explanation="Güzel bir yerdi",Image="1.jpg", Job="Software Engineer", Star=5},
                    new Comment(){CommentId=3,Name="Mary Jane", Explanation="Çok iyi yerdi",Image="1.jpg", Job="Web Designer", Star=5},
             };
    }
}


