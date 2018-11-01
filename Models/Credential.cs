using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAssignment.Models
{
    public class Credential
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string SecretToken { get; set; }
        public long UserId { get; set; }
        public long CreatedTimeMls { get; set; }
        public long ExpiredTimeMls { get; set; }
        public int Status { get; set; }
        public Member Member { get; set; }
    }
}
