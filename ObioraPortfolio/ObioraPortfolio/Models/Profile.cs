using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ObioraPortfolio.Models
{
    public class Profile : IdentityUser
    {
        public Profile()
        {
            Addresses = new List<Address>();
            WorkExperiences = new List<WorkExperience>();
        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Profession { get; set; }
        public string Qualification { get; set; }
        public string LinkedInUrl { get; set; }
        public string GitHubUrl { get; set; }
        
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
