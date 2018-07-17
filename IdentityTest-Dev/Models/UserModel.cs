using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IdentityTest_Dev.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImage { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public int ApprovedStatus { get; set; }
        public int PrivilegeLevel { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}