using Microsoft.AspNetCore.Mvc;
using Pizza.Data;
using Pizza.Data.Models;
using System.Linq;

namespace Pizza.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDBcontent _context;

        public ContactController(AppDBcontent context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contact = _context.Contacts.FirstOrDefault();
            return View(contact);
        }
    }
}
