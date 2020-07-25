using System;
using System.ComponentModel.DataAnnotations;

namespace Games.Domain
{

    // Have the entity class be an abstract class that will be extended.
    // It is abstract because it has characteristics that all domain 
    // classes will contain.

    public abstract class Entity
    {
        //Set your ID as a primary key
        [Key]

        // all domain classes contain an id of type integer
        public Guid Id { get; set; }
    }
}
