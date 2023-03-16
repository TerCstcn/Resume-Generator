using Microsoft.AspNetCore.Mvc;
using Resume.Models;

namespace Resume.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            var vm = new HomeModel
            {
                Objectives = HomeController.Objectives,
                FirstName = HomeController.FirstName,
                Surname = HomeController.Surname,
                PlaceBirth = HomeController.PlaceBirth,
                DateBirth = HomeController.DateBirth,
                Gender = HomeController.Gender,
                Address = HomeController.Address,
                ContactNumber = HomeController.ContactNumber,
                Email = HomeController.Email,
                LinkedIn = HomeController.LinkedIn,
                Website = HomeController.Website,
                College = HomeController.College,
                CollegeAdd = HomeController.CollegeAdd,
                CollegeCourse = HomeController.CollegeCourse,
                CollegeGrad = HomeController.CollegeGrad,
                Highschool = HomeController.Highschool,
                HighschoolAdd = HomeController.HighschoolAdd,
                HighschoolStrand = HomeController.HighschoolStrand,
                HighschoolGrad = HomeController.HighschoolGrad,
            };
            return View(vm);
        }
    }
}
