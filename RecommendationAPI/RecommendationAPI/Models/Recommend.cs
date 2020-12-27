using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationAPI.Models
{
    public class Recommend
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string urlImg { get; set; }
        public string webUrl { get; set; }
        public string UserId { get; set; }
    }
}
