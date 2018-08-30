using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7Lab28.Domain.Models;

namespace Week7Lab28.Data
{
    class Week7Lab28Initializer: DropCreateDatabaseAlways<Week7Lab28Context>
    {
        protected override void Seed(Week7Lab28Context context) 
        {
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Quest",
                Category = "Fantasy",
                Description = "One boy's quest for Fantasy"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Wild Romance",
                Category = "Romance",
                Description = "One boy's wild forray into the dating scene"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Quest 2",
                Category = "Fantasy",
                Description = "One boy's quest for MacGuffin2"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Mild Romance",
                Category = "Romance",
                Description = "One boy's mild forray into the dating scene"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Harrowing Midnight Trip to the Bathroom",
                Category = "Horror",
                Description = "Wimblo needs to get to the bathroom, but it is late, all the lights are out and Wimblo's eyes have not adjusted to the dark"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Cruise",
                Category = "Thriller",
                Description = "Wimblo is on a two week cruise that seems fine, but there is a traitor among his 'friends'"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Lazy River",
                Category = "Action",
                Description = "Wimblo is at the waterpark, but it seems that some parkgoers are rowdier than others"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Race",
                Category = "Family",
                Description = "Wimblo is running a foot race for fun with his friends"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Car Race",
                Category = "Action",
                Description = "Wimblo is driving in a race, for fun with his friends, for his friends"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Flight",
                Category = "Thriller",
                Description = "Wimblo is on a two hour flight that seems fine, but there is a traitor among his 'friends'"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Fun Romp",
                Category = "Family",
                Description = "Wimblo plays pretend with his friends for an afternoon"
            });
            context.Movies.Add(new Movie()
            {
                Title = "Wimblo's Birthday Party",
                Category = "Horror",
                Description = "Wimblo attends a friend's birthday party, but not everything is as it appears"
            });
            context.SaveChanges();
            base.Seed(context);

        }
    }
}
