using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action", Description = "Action & Adventure", }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 2, CategoryName = "Horror", Description = "Horror , Suspense , Fear" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 3, CategoryName = "Science Fiction", Description = "Futuristic and Technologic" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 4, CategoryName = "Fantasy", Description = "Magic and Wonder" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 5, CategoryName = "Romance", Description = "Love Story" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 6, CategoryName = "Comedy", Description = "Laugh feel good humor" }
                );

            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 1, Title = "Django Unchained", Director = "Quenton Tarentino", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_UY1200_CR90,0,630,1200_AL_.jpg", ShortDescription = "Freed Slave turned Bounty-Hunter", LongDescription = "Jamie Fox Plays a freed slave turned Bounty-Hunter", Price = 15, InStock = true, CategoryId = 1}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 2, Title = "Batman vs Superman", Director = "Zack Snyder", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/20/Batman_v_Superman_poster.jpg", ShortDescription = "Batman vs Superman", LongDescription = "Batman and Superman face off conspired by Lex Luther", Price = 15, InStock = true, CategoryId = 1 }
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 3, Title = "Polar", Director = "Jonas Akerlund", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzA5MjNjODEtOWYxYi00OTdmLTlhNTAtN2VhMTMxNWJjM2ZmXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_UY1200_CR90,0,630,1200_AL_.jpg", ShortDescription = "Retired Hitman Betrayed", LongDescription = "Retired Hitman Duncan is betrayed by his employer after 40 yrs of service to cheat him out of his retirment fund", Price = 15, InStock = true, CategoryId = 1}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 4, Title = "Under Siege", Director = "Andrew Davis", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/3d/StevenSeagalUnderSiege_cover.jpg", ShortDescription = "Naval Chief Casey Ryback stops naval hijacking", LongDescription = "Naval Chief Casey Ryback stops naval hijacking kicking ass and taking names", Price = 15, InStock = true, CategoryId = 1}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 5, Title = "Commando", Director = "Mark L. Lester", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d9/Commandoposter.jpg/220px-Commandoposter.jpg", ShortDescription = "Arnold Is not playing around", LongDescription = "A retired Special Forces colonel tries to save his daughter", Price = 15, InStock = true, CategoryId = 1}
                );

            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 6, Title = "Jacobs Ladder", Director = "Adrian Lyne", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51BAJ8zc13L._SY445_.jpg", ShortDescription = "Vietnam Vet suffers hallucinations", LongDescription = "Vietnam Vet Jacob Singer Falls into purgatory", Price = 15, InStock = true, CategoryId = 2}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 7, Title = "Dawn of the Dead", Director = "Zack Snyder", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/16/Dawn_of_the_Dead_2004_movie.jpg", ShortDescription = "Trapped in a mall zombies outside", LongDescription = "A nurse, policeman, a couple and others survive in a mall with zombies outside", Price = 15, InStock = true, CategoryId = 2}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 8, Title = "Misery", Director = "Rob Reiner", ImageUrl = "https://static.wikia.nocookie.net/stephenking/images/3/30/Miseryfilm.jpg/revision/latest/scale-to-width-down/340?cb=20150727205054", ShortDescription = "Crazy fan kidnaps her favorite Author", LongDescription = "Crazy Lady kidnaps her favorite Author and forces him to rewrite a book from a series", Price = 15, InStock = true, CategoryId = 2}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 9, Title = "Saw", Director = "James Wan", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41J9mRV5AUL.jpg", ShortDescription = "Mastermind traps people in elaborite ways", LongDescription = "Mastermind who likes puppets traps people in elaborite ways to teach them a lession", Price = 15, InStock = true, CategoryId = 2}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 10, Title = "It Follows", Director = "David Robert Mitchell", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMmU0MjBlYzYtZWY0MC00MjliLWI3ZmUtMzhlZDVjMWVmYWY4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY1200_CR90,0,630,1200_AL_.jpg", ShortDescription = "Sexually Transmitted Ghost", LongDescription = "A Ghost that hunts and kills the last person you sleep with.", Price = 15, InStock = true, CategoryId = 2}
                );

            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 11, Title = "Prometheus", Director = "Ridley Scott", ImageUrl = "https://thumbor.forbes.com/thumbor/237x300/http://b-i.forbesimg.com/daviddisalvo/files/2013/07/prometheus_main-237x300.jpg", ShortDescription = "Human Explorers search for their creators", LongDescription = "Human Explorers follow ancient clues to find their creators", Price = 15, InStock = true, CategoryId = 3}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 12, Title = "Dredd", Director = "Pete Travis", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/16/Dredd2012Poster.jpg/220px-Dredd2012Poster.jpg", ShortDescription = "The law of the wasteland", LongDescription = "Judges are the jugde, jury, and executioner of the apocolyptic future.", Price = 15, InStock = true, CategoryId = 3}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 13, Title = "Mad Max 2", Director = "George Miller", ImageUrl = "https://i.ytimg.com/vi/i2gVXd7FzhQ/maxresdefault.jpg", ShortDescription = "JUST WALK AWAY", LongDescription = "Lord of the Wasteland Humongous, the iatola of rock and rolla", Price = 15, InStock = true, CategoryId = 3}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 14, Title = "The Thing", Director = "John Carpenter", ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGViZWZmM2EtNGYzZi00ZDAyLTk3ODMtNzIyZTBjN2Y1NmM1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg", ShortDescription = "Alien shape-shifter in Antartica", LongDescription = "Shape-shifting alien found in the artic that is dangerous.", Price = 15, InStock = true, CategoryId = 3}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 15, Title = "Edge of Tomorrow", Director = "Doug Liman", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/f9/Edge_of_Tomorrow_Poster.jpg", ShortDescription = "Tom Cruise is amazing", LongDescription = "I dont care if he is a scientologist", Price = 15, InStock = true, CategoryId = 3}
                );

            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 16, Title = "The Hobbit", Director = "Peter Jackson", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTcwNTE4MTUxMl5BMl5BanBnXkFtZTcwMDIyODM4OA@@._V1_UY1200_CR90,0,630,1200_AL_.jpg", ShortDescription = "A Hobbit journeys with a ring", LongDescription = "A Hobbit journeys with a ring with a band of Dwarfs", Price = 15, InStock = true, CategoryId = 4}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 17, Title = "Fantastic Beasts, The Crimes Of Grindelwald", Director = "David Yates", ImageUrl = "https://tuftsdaily.com/wp-content/uploads/2018/11/i1G4sQb.jpg", ShortDescription = "Wizard/Animal enthusiast also facism", LongDescription = "I feel bad for Johnny Depth", Price = 15, InStock = true, CategoryId = 4}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 18, Title = "Harry Potter and the Sorcerer's Stone", Director = "Chris Columbus", ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjQ3NWNlNmQtMTE5ZS00MDdmLTlkZjUtZTBlM2UxMGFiMTU3XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UY1200_CR90,0,630,1200_AL_.jpg", ShortDescription = "Daniel Radcliffe", LongDescription = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family", Price = 15, InStock = true, CategoryId = 4}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 19, Title = "Witches", Director = "Robert Zemeckis", ImageUrl = "https://deadline.com/wp-content/uploads/2020/10/witches-1-e1601613994504.jpg", ShortDescription = "Witches in a hotel", LongDescription = "A young boy and his grandmother have a run-in with a coven of witches and thier leader", Price = 15, InStock = true, CategoryId = 4}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 20, Title = "Dolittle", Director = "Stephen Gaghan", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDNkODA5ZGQtODczOS00OTQxLThhMTItMjk0ZmNhMDM0YjNmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg", ShortDescription = "Robert Downey Jr is Dr. Dolittle", LongDescription = "A physician who can talk to animals", Price = 15, InStock = true, CategoryId = 4}
                );

            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 21, Title = "Casablanca", Director = "Michael Curtiz", ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2IzZGY2YmEtYzljNS00NTM5LTgwMzUtMzM1NjQ4NGI0OTk0XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UY1200_CR83,0,630,1200_AL_.jpg", ShortDescription = "Rick Blaine owns a nightclub", LongDescription = "Boring", Price = 15, InStock = true, CategoryId = 5}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 22, Title = "A Night at the Opera", Director = "Sam Wood", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/aa/A_Night_at_the_Opera_film_poster.jpg", ShortDescription = "Boring", LongDescription = "A physician who can talk to animals", Price = 15, InStock = true, CategoryId = 5}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 23, Title = "It Happened One Night", Director = "Frank Capra", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/dc/It-happened-one-night-poster.jpg", ShortDescription = "Boring", LongDescription = "A physician who can talk to animals", Price = 15, InStock = true, CategoryId = 5}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 24, Title = "The Shape Of Water", Director = "Guillermo del Toro", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81+H9++xgTL.jpg", ShortDescription = "Boring", LongDescription = "A physician who can talk to animals", Price = 15, InStock = true, CategoryId = 5}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 25, Title = "Singin in the rain", Director = "Stanley Donen", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Singin%27_in_the_Rain_%281952_poster%29.jpg/1200px-Singin%27_in_the_Rain_%281952_poster%29.jpg", ShortDescription = "Boring", LongDescription = "A physician who can talk to animals", Price = 15, InStock = true, CategoryId = 5}
                );

            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 26, Title = "Half Baked", Director = "Tamra Davis", ImageUrl = "https://m.media-amazon.com/images/M/MV5BZWMxZWE1ZjQtYzAyNS00NjEwLTgwM2ItMWI2NWVhZGJiYjk3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY1200_CR86,0,630,1200_AL_.jpg", ShortDescription = "Friends sell weed", LongDescription = "Friends are forced to sell weed to get friend out of jail.", Price = 15, InStock = true, CategoryId = 6}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 27, Title = "How High", Director = "Jesse Dylan", ImageUrl = "https://resizing.flixster.com/5374dDGmXYamiLqRJ9DG1rjidOc=/206x305/v2/https://flxt.tmsimg.com/assets/p28741_p_v10_aa.jpg", ShortDescription = "Red-man and Method man", LongDescription = "Red-man and Method Man go to Harvard.", Price = 15, InStock = true, CategoryId = 6}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 28, Title = "Hot Fuzz", Director = "Edgar Wright", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzg4MDJhMDMtYmJiMS00ZDZmLThmZWUtYTMwZDM1YTc5MWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg", ShortDescription = "Buddy Cop film", LongDescription = "Cop gets transferred", Price = 15, InStock = true, CategoryId = 6}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 29, Title = "Tropic Thunder", Director = "Ben Stiller", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d6/Tropic_thunder_ver3.jpg", ShortDescription = "Hilarious", LongDescription = "Hilarious", Price = 15, InStock = true, CategoryId = 6}
                );
            modelBuilder.Entity<Video>().HasData(
                new Video { VideoId = 30, Title = "Beverly Hills Ninja", Director = "Chris Farley", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/16/Beverly_Hills_Ninja_poster.jpg", ShortDescription = "Fat Ninja", LongDescription = "Fat Ninja", Price = 15, InStock = true, CategoryId = 6}
                );
        }
    }
}
