using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAssignment.Models
{
    public class Song
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Singer { get; set; }
        public string Author { get; set; }
        public string Thumbnail { get; set; }
        public string Link { get; set; }
        public int MemberId { get; set; }
        public long CreatedAt { get; set; }
        public long UpdatedAt { get; set; }
        public int Status { get; set; }

        public Member Member { get; set; }
    }
}
