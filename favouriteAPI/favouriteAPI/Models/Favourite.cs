using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace favouriteAPI.Models
{
    public class Favourite
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        [BsonId]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string UserName { get; set; }
    }
}
