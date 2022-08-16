using LMSApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LMSAPP1.Controllers
{
    public class UserController : Controller
    {
        private readonly LMSContext _context;
        public UserController(LMSContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString, string name)
        {
            Account user = new Account();
            user.UserName = name;
            var bookCard = from b in _context.Books select b;

            if (!string.IsNullOrEmpty(searchString))
            {
                bookCard = bookCard.Where(s =>
                    s.BookTitle.Contains(searchString) ||
                    s.NoOfCopies == System.Convert.ToInt32(searchString) ||
                    s.Author.AuthorName.Contains(searchString) ||
                    s.Category.Contains(searchString)
                );
            }
            
            return View(Tuple.Create(user, (bookCard.ToList())));
        }


    //public async Task<IActionResult> Index1()
    //{
    //    var lMSContext = _context.Books.Include(b => b.Author).Include(b => b.Publisher);
    //    return View(await lMSContext.ToListAsync());
    //}
}
}