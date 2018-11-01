using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAssignment.Models
{
    public class Member
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Introduction { get; set; }
        public int Gender { get; set; }
        public long Birthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public long CreatedAt { get; set; }
        public long UpdatedAt { get; set; }
        public int Status { get; set; }
        public List<Credential> Credentials { get; set; }
        public List<Song> Songs { get; set; }
    }

    //private long id;
    //private String firtName;
    //private String lastName;
    //private String avatar;
    //private String phone;
    //private String address;
    //private String introduction;
    //private int gender;
    //private Date birthday;

    //private String email;
    //private String password;
    //private String salt;

    //private Date createdAt;
    //private Date updatedAt;
    //private int status;
}
