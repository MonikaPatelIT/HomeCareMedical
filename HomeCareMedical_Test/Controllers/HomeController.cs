using System.Linq;
using System.Web.Mvc;
using HomeCareMedical_Test.Models;

namespace HomeCareMedical_Test.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDBContext _context ;
        public HomeController()
        {
            _context = new ApplicationDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET://Home/Index
        public ActionResult Index(string searchText)
        {
            //Filter context with searchText, can be First name or Surname if is not empty
            // On page load is null will return all 
            var personalView = _context.Personal
                                       .Where(p=>p.FirstName.Contains(searchText) // match to First name
                                       || p.SurName.Contains(searchText) // match to surname
                                       || searchText == null) //null on page load
                                       .ToList();
            
            return View(personalView);
        }

        //GET://Home/PersonForm
        public ActionResult PersonForm()
        {
            return View("PersonForm");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateNewRecord( Personal person)
        {               
            if (!ModelState.IsValid)
            {
                return View("PersonForm"); // will stay on Person Form on invalid state
            }
            else
            {
                //Filter indexed value with exisitng record to find duplicate entry by First name, middle name and surname
                var personDB = (from p in _context.Personal
                                where p.FirstName == person.FirstName &&
                                p.MiddleName == person.MiddleName &&
                                p.SurName == person.SurName
                                select p).ToList();

                if (personDB.Count> 0)
                {
                    //Restrict duplicate entry 
                    ViewBag.DuplicateError = "Person already exists in the database."; 
                    return View("PersonForm");
                }                
                else
                {
                    // Add new person in db
                    _context.Personal.Add(person);
                    _context.SaveChanges();
                    ViewBag.SuccessMessage = "Person added in the database.";
                    ModelState.Clear();
                    return View("PersonForm");
                }
            }
        }

        
    }
}