using System.Drawing.Text;
using learn.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace learn.Controllers
{
    public class Category : Controller
    {
        private readonly ApplicationDbContext _db;

        public Category(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public ActionResult Index()
        {
            IEnumerable<Models.Category> objCategoryList = _db.Categories;
            
            return View(objCategoryList);
        }

      
        }

        
}
