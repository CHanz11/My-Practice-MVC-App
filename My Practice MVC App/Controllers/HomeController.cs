using Microsoft.AspNetCore.Mvc;
using My_Practice_MVC_App.Models; // Import the models name space

namespace My_Practice_MVC_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        //Process the submitted form POST request
        [HttpPost]
        public IActionResult Create(Person person)
        {
            if(ModelState.IsValid)
            {
                _context.People.Add(person); // Add data to the database
                _context.SaveChanges(); //Save Changes
                return RedirectToAction("List");
            }

            return View(person);
        }

        //Display the submitted List
        public IActionResult List()
        {
            var people = _context.People.ToList(); // Get all records
            return View(people);

        }

        
    }
}
