using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecTube.Models
{
    [Table("User")]
    public class User : IdentityUser
    {
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(20)]
        public string Nickname { get; set; }

        public int UserNameChangeLimit { get; set; } = 10;

        public byte[] ProfilePicture { get; set; }
    }
}