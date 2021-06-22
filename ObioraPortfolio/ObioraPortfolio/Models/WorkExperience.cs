using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ObioraPortfolio.Models
{
    public class WorkExperience
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime YearStarted { get; set; }
        [DataType(DataType.Date)]
        public DateTime YearEnded { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; }
    }
}
