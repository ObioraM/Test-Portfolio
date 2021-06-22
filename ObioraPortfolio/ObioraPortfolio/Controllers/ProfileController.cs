using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ObioraPortfolio.Data;
using ObioraPortfolio.Models;
using ObioraPortfolio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObioraPortfolio.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDbContext _appDbContext;
        
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ProfileController(UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager,
                                      AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult Index()
        {
            
            var details = _appDbContext.ProfileTbl.Include(pro => pro.Addresses)
                                                    .Include(pro => pro.WorkExperiences).FirstOrDefault();
            ProfileViewModel profile = new ProfileViewModel()
            {
                Id = details.Id,
                FirstName = details.FirstName,
                LastName = details.LastName,
                PhoneNumber = details.PhoneNumber,
                Email = details.Email,
                Profession = details.Profession,
                Qualification = details.Qualification,
                LinkedInUrl = details.LinkedInUrl,
                GitHubUrl = details.GitHubUrl,
                Street = details.Addresses[0].Street,
                City = details.Addresses[0].City,
                State = details.Addresses[0].State,
                Country = details.Addresses[0].Country,
                CompanyName = details.WorkExperiences[0].CompanyName,
                JobTitle = details.WorkExperiences[0].JobTitle,
                JobDescription = details.WorkExperiences[0].JobDescription,
                YearStarted = details.WorkExperiences[0].YearStarted,
                YearEnded = details.WorkExperiences[0].YearEnded,
                
            };
                                                    
            
            return View(profile);
        }



        [HttpPost]
        public async Task<IActionResult> Index(ProfileViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                var details = _appDbContext.ProfileTbl.Include(pro => pro.Addresses)
                                                   .Include(pro => pro.WorkExperiences).FirstOrDefault();


                
                details.FirstName = model.FirstName;
                details.LastName = model.LastName;
                details.PhoneNumber = model.PhoneNumber;
                details.Profession = model.Profession;
                details.LinkedInUrl = model.LinkedInUrl;
                details.GitHubUrl = model.GitHubUrl;
                details.Email = model.Email;
                details.Qualification = model.Qualification;
                details.LinkedInUrl = model.LinkedInUrl;
                details.Addresses[0].Street = model.Street;
                details.Addresses[0].State = model.State;
                details.Addresses[0].City = model.City;
                details.Addresses[0].Country = model.Country;
                details.WorkExperiences[0].CompanyName = model.CompanyName;
                details.WorkExperiences[0].JobDescription = model.JobDescription;
                details.WorkExperiences[0].JobTitle = model.JobTitle;
                details.WorkExperiences[0].YearStarted = model.YearStarted;
                details.WorkExperiences[0].YearEnded = model.YearEnded;
                


                var result = await _userManager.UpdateAsync(details);

            }
            return View(model);
            
        }
    }
}
