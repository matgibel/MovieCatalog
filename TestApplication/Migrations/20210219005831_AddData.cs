using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Action", "Action & Adventure" },
                    { 2, "Horror", "Horror , Suspense , Fear" },
                    { 3, "Science Fiction", "Futuristic and Technologic" },
                    { 4, "Fantasy", "Magic and Wonder" },
                    { 5, "Romance", "Love Story" },
                    { 6, "Comedy", "Laugh feel good humor" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "CategoryId", "Director", "ImageUrl", "InStock", "LongDescription", "Price", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Quenton Tarentino", "https://m.media-amazon.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_UY1200_CR90,0,630,1200_AL_.jpg", true, "Jamie Fox Plays a freed slave turned Bounty-Hunter", 15m, "Freed Slave turned Bounty-Hunter", "Django Unchained" },
                    { 28, 6, "Edgar Wright", "https://m.media-amazon.com/images/M/MV5BMzg4MDJhMDMtYmJiMS00ZDZmLThmZWUtYTMwZDM1YTc5MWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg", true, "Cop gets transferred", 15m, "Buddy Cop film", "Hot Fuzz" },
                    { 27, 6, "Jesse Dylan", "https://resizing.flixster.com/5374dDGmXYamiLqRJ9DG1rjidOc=/206x305/v2/https://flxt.tmsimg.com/assets/p28741_p_v10_aa.jpg", true, "Red-man and Method Man go to Harvard.", 15m, "Red-man and Method man", "How High" },
                    { 26, 6, "Tamra Davis", "https://m.media-amazon.com/images/M/MV5BZWMxZWE1ZjQtYzAyNS00NjEwLTgwM2ItMWI2NWVhZGJiYjk3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY1200_CR86,0,630,1200_AL_.jpg", true, "Friends are forced to sell weed to get friend out of jail.", 15m, "Friends sell weed", "Half Baked" },
                    { 25, 5, "Stanley Donen", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Singin%27_in_the_Rain_%281952_poster%29.jpg/1200px-Singin%27_in_the_Rain_%281952_poster%29.jpg", true, "A physician who can talk to animals", 15m, "Boring", "Singin in the rain" },
                    { 24, 5, "Guillermo del Toro", "https://images-na.ssl-images-amazon.com/images/I/81+H9++xgTL.jpg", true, "A physician who can talk to animals", 15m, "Boring", "The Shape Of Water" },
                    { 23, 5, "Frank Capra", "https://upload.wikimedia.org/wikipedia/commons/d/dc/It-happened-one-night-poster.jpg", true, "A physician who can talk to animals", 15m, "Boring", "It Happened One Night" },
                    { 22, 5, "Sam Wood", "https://upload.wikimedia.org/wikipedia/commons/a/aa/A_Night_at_the_Opera_film_poster.jpg", true, "A physician who can talk to animals", 15m, "Boring", "A Night at the Opera" },
                    { 21, 5, "Michael Curtiz", "https://m.media-amazon.com/images/M/MV5BY2IzZGY2YmEtYzljNS00NTM5LTgwMzUtMzM1NjQ4NGI0OTk0XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UY1200_CR83,0,630,1200_AL_.jpg", true, "Boring", 15m, "Rick Blaine owns a nightclub", "Casablanca" },
                    { 20, 4, "Stephen Gaghan", "https://m.media-amazon.com/images/M/MV5BMDNkODA5ZGQtODczOS00OTQxLThhMTItMjk0ZmNhMDM0YjNmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg", true, "A physician who can talk to animals", 15m, "Robert Downey Jr is Dr. Dolittle", "Dolittle" },
                    { 19, 4, "Robert Zemeckis", "https://deadline.com/wp-content/uploads/2020/10/witches-1-e1601613994504.jpg", true, "A young boy and his grandmother have a run-in with a coven of witches and thier leader", 15m, "Witches in a hotel", "Witches" },
                    { 18, 4, "Chris Columbus", "https://m.media-amazon.com/images/M/MV5BNjQ3NWNlNmQtMTE5ZS00MDdmLTlkZjUtZTBlM2UxMGFiMTU3XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UY1200_CR90,0,630,1200_AL_.jpg", true, "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family", 15m, "Daniel Radcliffe", "Harry Potter and the Sorcerer's Stone" },
                    { 17, 4, "David Yates", "https://tuftsdaily.com/wp-content/uploads/2018/11/i1G4sQb.jpg", true, "I feel bad for Johnny Depth", 15m, "Wizard/Animal enthusiast also facism", "Fantastic Beasts, The Crimes Of Grindelwald" },
                    { 16, 4, "Peter Jackson", "https://m.media-amazon.com/images/M/MV5BMTcwNTE4MTUxMl5BMl5BanBnXkFtZTcwMDIyODM4OA@@._V1_UY1200_CR90,0,630,1200_AL_.jpg", true, "A Hobbit journeys with a ring with a band of Dwarfs", 15m, "A Hobbit journeys with a ring", "The Hobbit" },
                    { 15, 3, "Doug Liman", "https://upload.wikimedia.org/wikipedia/en/f/f9/Edge_of_Tomorrow_Poster.jpg", true, "I dont care if he is a scientologist", 15m, "Tom Cruise is amazing", "Edge of Tomorrow" },
                    { 14, 3, "John Carpenter", "https://m.media-amazon.com/images/M/MV5BNGViZWZmM2EtNGYzZi00ZDAyLTk3ODMtNzIyZTBjN2Y1NmM1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg", true, "Shape-shifting alien found in the artic that is dangerous.", 15m, "Alien shape-shifter in Antartica", "The Thing" },
                    { 13, 3, "George Miller", "https://i.ytimg.com/vi/i2gVXd7FzhQ/maxresdefault.jpg", true, "Lord of the Wasteland Humongous, the iatola of rock and rolla", 15m, "JUST WALK AWAY", "Mad Max 2" },
                    { 12, 3, "Pete Travis", "https://upload.wikimedia.org/wikipedia/en/thumb/1/16/Dredd2012Poster.jpg/220px-Dredd2012Poster.jpg", true, "Judges are the jugde, jury, and executioner of the apocolyptic future.", 15m, "The law of the wasteland", "Dredd" },
                    { 11, 3, "Ridley Scott", "https://thumbor.forbes.com/thumbor/237x300/http://b-i.forbesimg.com/daviddisalvo/files/2013/07/prometheus_main-237x300.jpg", true, "Human Explorers follow ancient clues to find their creators", 15m, "Human Explorers search for their creators", "Prometheus" },
                    { 10, 2, "David Robert Mitchell", "https://m.media-amazon.com/images/M/MV5BMmU0MjBlYzYtZWY0MC00MjliLWI3ZmUtMzhlZDVjMWVmYWY4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY1200_CR90,0,630,1200_AL_.jpg", true, "A Ghost that hunts and kills the last person you sleep with.", 15m, "Sexually Transmitted Ghost", "It Follows" },
                    { 9, 2, "James Wan", "https://images-na.ssl-images-amazon.com/images/I/41J9mRV5AUL.jpg", true, "Mastermind who likes puppets traps people in elaborite ways to teach them a lession", 15m, "Mastermind traps people in elaborite ways", "Saw" },
                    { 8, 2, "Rob Reiner", "https://static.wikia.nocookie.net/stephenking/images/3/30/Miseryfilm.jpg/revision/latest/scale-to-width-down/340?cb=20150727205054", true, "Crazy Lady kidnaps her favorite Author and forces him to rewrite a book from a series", 15m, "Crazy fan kidnaps her favorite Author", "Misery" },
                    { 7, 2, "Zack Snyder", "https://upload.wikimedia.org/wikipedia/en/1/16/Dawn_of_the_Dead_2004_movie.jpg", true, "A nurse, policeman, a couple and others survive in a mall with zombies outside", 15m, "Trapped in a mall zombies outside", "Dawn of the Dead" },
                    { 6, 2, "Adrian Lyne", "https://images-na.ssl-images-amazon.com/images/I/51BAJ8zc13L._SY445_.jpg", true, "Vietnam Vet Jacob Singer Falls into purgatory", 15m, "Vietnam Vet suffers hallucinations", "Jacobs Ladder" },
                    { 5, 1, "Mark L. Lester", "https://upload.wikimedia.org/wikipedia/en/thumb/d/d9/Commandoposter.jpg/220px-Commandoposter.jpg", true, "A retired Special Forces colonel tries to save his daughter", 15m, "Arnold Is not playing around", "Commando" },
                    { 4, 1, "Andrew Davis", "https://upload.wikimedia.org/wikipedia/en/3/3d/StevenSeagalUnderSiege_cover.jpg", true, "Naval Chief Casey Ryback stops naval hijacking kicking ass and taking names", 15m, "Naval Chief Casey Ryback stops naval hijacking", "Under Siege" },
                    { 3, 1, "Jonas Akerlund", "https://m.media-amazon.com/images/M/MV5BMzA5MjNjODEtOWYxYi00OTdmLTlhNTAtN2VhMTMxNWJjM2ZmXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_UY1200_CR90,0,630,1200_AL_.jpg", true, "Retired Hitman Duncan is betrayed by his employer after 40 yrs of service to cheat him out of his retirment fund", 15m, "Retired Hitman Betrayed", "Polar" },
                    { 2, 1, "Zack Snyder", "https://upload.wikimedia.org/wikipedia/en/2/20/Batman_v_Superman_poster.jpg", true, "Batman and Superman face off conspired by Lex Luther", 15m, "Batman vs Superman", "Batman vs Superman" },
                    { 29, 6, "Ben Stiller", "https://upload.wikimedia.org/wikipedia/en/d/d6/Tropic_thunder_ver3.jpg", true, "Hilarious", 15m, "Hilarious", "Tropic Thunder" },
                    { 30, 6, "Chris Farley", "https://upload.wikimedia.org/wikipedia/en/1/16/Beverly_Hills_Ninja_poster.jpg", true, "Fat Ninja", 15m, "Fat Ninja", "Beverly Hills Ninja" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);
        }
    }
}
