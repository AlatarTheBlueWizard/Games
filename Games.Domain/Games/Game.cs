using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Games
{
    //Have all domain classes extend the entity class.
    //Entity class is abstract and contains characteristics that all
    //domain models have or will inherit.

    public class Game : Entity
    {
        // Define constructor for creating and updating from db
        // converts a view model to a domain model in services
        // to use as an argument to the repo to create new data.
        public Game(string title, string genre, int releaseYear, string company)
        {
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
            Company = company;
        }

        // Games table will have a column with an id (inherited from
        // the entity class) with a type of integer. The title, genre,
        // and company column will have a type of string. Finally the
        // release year will be a column with a type of integer.
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Company { get; set; }
    }
}
