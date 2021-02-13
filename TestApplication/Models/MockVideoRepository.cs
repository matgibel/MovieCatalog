using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class MockVideoRepository : IVideoRepository
    {
        private readonly ICategoryRepository _category = new MockCategoryRepository();
        public IEnumerable<Video> GetAllVideos()
        {
            return new List<Video>()
            {
                new Video{VideoId=1, Title="Django Unchained",Director="Quenton Tarentino",ImageUrl="https://images.app.goo.gl/u4AxSYaJX3C6oBja7",ShortDescription="Freed Slave turned Bounty-Hunter",LongDescription="Jamie Fox Plays a freed slave turned Bounty-Hunter",Price=15,InStock=true,CategoryId=1,Category=_category.GetCategoryById(1)},
                new Video{VideoId=2, Title="Batman vs Superman",Director="Zack Snyder",ImageUrl="https://images.app.goo.gl/MB2RCJsrHUzaaCHy9",ShortDescription="Batman vs Superman",LongDescription="Batman and Superman face off conspired by Lex Luther",Price=15,InStock=true,CategoryId=1,Category=_category.GetCategoryById(1)},
                new Video{VideoId=3, Title="Polar",Director="Jonas Akerlund",ImageUrl="https://images.app.goo.gl/WH5eyG6knQcmT5GY7",ShortDescription="Retired Hitman Betrayed",LongDescription="Retired Hitman Duncan is betrayed by his employer after 40 yrs of service to cheat him out of his retirment fund",Price=15,InStock=true,CategoryId=1,Category=_category.GetCategoryById(1)},
                new Video{VideoId=4, Title="Under Siege",Director="Andrew Davis",ImageUrl="https://images.app.goo.gl/BUrDheQrtM3oZZnW7",ShortDescription="Naval Chief Casey Ryback stops naval hijacking",LongDescription="Naval Chief Casey Ryback stops naval hijacking kicking ass and taking names",Price=15,InStock=true,CategoryId=1,Category=_category.GetCategoryById(1)},
                new Video{VideoId=5, Title="Commando",Director="Mark L. Lester",ImageUrl="https://images.app.goo.gl/jCRRH5bDgguZwFV68",ShortDescription="Arnold Is not playing around",LongDescription="A retired Special Forces colonel tries to save his daughter",Price=15,InStock=true,CategoryId=1,Category=_category.GetCategoryById(1)},

                new Video{VideoId=6, Title="Jacobs Ladder",Director="Adrian Lyne",ImageUrl="https://images.app.goo.gl/8beZ6qBMsZyfQAax8",ShortDescription="Vietnam Vet suffers hallucinations",LongDescription="Vietnam Vet Jacob Singer Falls into purgatory",Price=15,InStock=true,CategoryId=2,Category=_category.GetCategoryById(2)},
                new Video{VideoId=7, Title="Dawn of the Dead",Director="Zack Snyder",ImageUrl="https://images.app.goo.gl/3cHXDM65RNwV7DBE6",ShortDescription="Trapped in a mall zombies outside",LongDescription="A nurse, policeman, a couple and others survive in a mall with zombies outside",Price=15,InStock=true,CategoryId=2,Category=_category.GetCategoryById(2)},
                new Video{VideoId=8, Title="Misery",Director="Rob Reiner",ImageUrl="https://images.app.goo.gl/y7Sb3TMKoneEt6Em8",ShortDescription="Crazy fan kidnaps her favorite Author",LongDescription="Crazy Lady kidnaps her favorite Author and forces him to rewrite a book from a series",Price=15,InStock=true,CategoryId=2,Category=_category.GetCategoryById(2)},
                new Video{VideoId=9, Title="Saw",Director="James Wan",ImageUrl="https://images.app.goo.gl/e1ynpTmvEXH9vfTj9",ShortDescription="Mastermind traps people in elaborite ways",LongDescription="Mastermind who likes puppets traps people in elaborite ways to teach them a lession",Price=15,InStock=true,CategoryId=2,Category=_category.GetCategoryById(2)},
                new Video{VideoId=10, Title="It Follows",Director="David Robert Mitchell",ImageUrl="https://images.app.goo.gl/BdsGkXqoSw2gm8mA9",ShortDescription="Sexually Transmitted Ghost",LongDescription="A Ghost that hunts and kills the last person you sleep with.",Price=15,InStock=true,CategoryId=2,Category=_category.GetCategoryById(2)},

                new Video{VideoId=11, Title="Prometheus",Director="Ridley Scott",ImageUrl="https://images.app.goo.gl/W7TYJkHDoRB5rRKZ8",ShortDescription="Human Explorers search for their creators",LongDescription="Human Explorers follow ancient clues to find their creators",Price=15,InStock=true,CategoryId=3,Category=_category.GetCategoryById(3)},
                new Video{VideoId=12, Title="Dredd",Director="Pete Travis",ImageUrl="https://images.app.goo.gl/EPQKJbqRCmREhsEk8",ShortDescription="The law of the wasteland",LongDescription="Judges are the jugde, jury, and executioner of the apocolyptic future.",Price=15,InStock=true,CategoryId=3,Category=_category.GetCategoryById(3)},
                new Video{VideoId=13, Title="Mad Max 2",Director="George Miller",ImageUrl="https://images.app.goo.gl/ruRo2L3qWazM88jT9",ShortDescription="JUST WALK AWAY",LongDescription="Lord of the Wasteland Humongous, the iatola of rock and rolla",Price=15,InStock=true,CategoryId=3,Category=_category.GetCategoryById(3)},
                new Video{VideoId=14, Title="The Thing",Director="John Carpenter",ImageUrl="https://images.app.goo.gl/kQP4APYWYUTpdGSw9",ShortDescription="Alien shape-shifter in Antartica",LongDescription="Shape-shifting alien found in the artic that is dangerous.",Price=15,InStock=true,CategoryId=3,Category=_category.GetCategoryById(3)},
                new Video{VideoId=15, Title="Edge of Tomorrow",Director="Doug Liman",ImageUrl="https://images.app.goo.gl/Ad7z3QVMx7oDtXXH7",ShortDescription="Tom Cruise is amazing",LongDescription="I dont care if he is a scientologist",Price=15,InStock=true,CategoryId=3,Category=_category.GetCategoryById(3)},

                new Video{VideoId=16, Title="The Hobbit",Director="Peter Jackson",ImageUrl="https://images.app.goo.gl/cvFZ3Lp12McQDiAf8",ShortDescription="A Hobbit journeys with a ring",LongDescription="A Hobbit journeys with a ring with a band of Dwarfs",Price=15,InStock=true,CategoryId=4,Category=_category.GetCategoryById(4)},
                new Video{VideoId=17, Title="Fantastic Beasts, The Crimes Of Grindelwald",Director="David Yates",ImageUrl="https://images.app.goo.gl/SJBJ5jwKwxvJipNZ7",ShortDescription="Wizard/Animal enthusiast also facism",LongDescription="I feel bad for Johnny Depth",Price=15,InStock=true,CategoryId=4,Category=_category.GetCategoryById(4)},
                new Video{VideoId=18, Title="Harry Potter and the Sorcerer's Stone",Director="Chris Columbus",ImageUrl="https://images.app.goo.gl/wxRGn4M313dFp3d66",ShortDescription="Daniel Radcliffe",LongDescription="An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family",Price=15,InStock=true,CategoryId=4,Category=_category.GetCategoryById(4)},
                new Video{VideoId=19, Title="Witches",Director="Robert Zemeckis",ImageUrl="https://images.app.goo.gl/X4Us56u7LnpQJM3v7",ShortDescription="Witches in a hotel",LongDescription="A young boy and his grandmother have a run-in with a coven of witches and thier leader",Price=15,InStock=true,CategoryId=4,Category=_category.GetCategoryById(4)},
                new Video{VideoId=20, Title="Dolittle",Director="Stephen Gaghan",ImageUrl="https://images.app.goo.gl/LSVTvriPdfGn5oQx6",ShortDescription="Robert Downey Jr is Dr. Dolittle",LongDescription="A physician who can talk to animals",Price=15,InStock=true,CategoryId=4,Category=_category.GetCategoryById(4)},

                new Video{VideoId=21, Title="Casablanca",Director="Michael Curtiz",ImageUrl="https://images.app.goo.gl/DheAmQBQroLhgapw5",ShortDescription="Rick Blaine owns a nightclub",LongDescription="Boring",Price=15,InStock=true,CategoryId=5,Category=_category.GetCategoryById(5)},
                new Video{VideoId=22, Title="A Night at the Opera",Director="Sam Wood",ImageUrl="https://images.app.goo.gl/ZohAj8Z7wisSRejN9",ShortDescription="Boring",LongDescription="A physician who can talk to animals",Price=15,InStock=true,CategoryId=5,Category=_category.GetCategoryById(5)},
                new Video{VideoId=23, Title="It Happened One Night",Director="Frank Capra",ImageUrl="https://images.app.goo.gl/NzeVD7wEFBF7ftxd9",ShortDescription="Boring",LongDescription="A physician who can talk to animals",Price=15,InStock=true,CategoryId=5,Category=_category.GetCategoryById(5)},
                new Video{VideoId=24, Title="The Shape Of Water",Director="Guillermo del Toro",ImageUrl="https://images.app.goo.gl/rU6XUBtQ5SFE2UmT9",ShortDescription="Boring",LongDescription="A physician who can talk to animals",Price=15,InStock=true,CategoryId=5,Category=_category.GetCategoryById(5)},
                new Video{VideoId=25, Title="Singin in the rain",Director="Stanley Donen",ImageUrl="https://images.app.goo.gl/xQv7HnKduTRriwhd9",ShortDescription="Boring",LongDescription="A physician who can talk to animals",Price=15,InStock=true,CategoryId=5,Category=_category.GetCategoryById(5)},

                new Video{VideoId=26, Title="Half Baked",Director="Tamra Davis",ImageUrl="https://images.app.goo.gl/wGDWcz7x5rVMHuFRA",ShortDescription="Friends sell weed",LongDescription="Friends are forced to sell weed to get friend out of jail.",Price=15,InStock=true,CategoryId=6,Category=_category.GetCategoryById(6)},
                new Video{VideoId=27, Title="How High",Director="Jesse Dylan",ImageUrl="https://images.app.goo.gl/Uz8oqQFfrBL4XznF8",ShortDescription="Red-man and Method man",LongDescription="Red-man and Method Man go to Harvard.",Price=15,InStock=true,CategoryId=6,Category=_category.GetCategoryById(6)},
                new Video{VideoId=28, Title="Hot Fuzz",Director="Edgar Wright",ImageUrl="https://images.app.goo.gl/93t3RaSogwXEn5Jo8",ShortDescription="Buddy Cop film",LongDescription="Cop gets transferred",Price=15,InStock=true,CategoryId=6,Category=_category.GetCategoryById(6)},
                new Video{VideoId=29, Title="Tropic Thunder",Director="Ben Stiller",ImageUrl="https://images.app.goo.gl/bvASu3uJHsHhD28N8",ShortDescription="Hilarious",LongDescription="Hilarious",Price=15,InStock=true,CategoryId=6,Category=_category.GetCategoryById(6)},
                new Video{VideoId=30, Title="Beverly Hills Ninja",Director="Chris Farley",ImageUrl="https://images.app.goo.gl/XD9qsD686io5xHJh7",ShortDescription="Fat Ninja",LongDescription="Fat Ninja",Price=15,InStock=true,CategoryId=6,Category=_category.GetCategoryById(6)},

            };
        }

        public Video GetVideoById(int idVideo)
        {
            return GetAllVideos().FirstOrDefault(b=> b.VideoId == idVideo);
        }
    }
}
