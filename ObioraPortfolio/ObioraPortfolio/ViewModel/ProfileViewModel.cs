using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ObioraPortfolio.ViewModel
{
    public class ProfileViewModel
    {
        
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Profession { get; set; }
        public string Qualification { get; set; }
        public string LinkedInUrl { get; set; }
        public string GitHubUrl { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Address
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int AddressId { get; set; }


        // Work Experience
        [DataType(DataType.Date)]
        public DateTime YearStarted { get; set; }
        [DataType(DataType.Date)]
        public DateTime YearEnded { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int WorkExperienceId { get; set; }
    }
}
