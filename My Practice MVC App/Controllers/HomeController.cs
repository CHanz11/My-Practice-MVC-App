using Microsoft.AspNetCore.Mvc;
using My_Practice_MVC_App.Models; // Import the models name space

namespace My_Practice_MVC_App.Controllers
{
    public class HomeController : Controller
    {
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
                //Redirect to the Details page with the submitted Data
                return RedirectToAction("Details", person);
            }

            return View(person);
        }

        //Display the submitted Details
        public IActionResult Details(Person person)
        {
            return View(person);
        }

        
    }
}
