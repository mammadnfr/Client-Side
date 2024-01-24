using Microsoft.AspNetCore.Mvc;
using Jalese6.Models;
namespace Jalese6.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly Context contextdbs;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ShoppingController(Context contextdbs, IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.contextdbs = contextdbs;
        }
        public IActionResult Index()
        {
            var query = contextdbs.Products.ToList();
            return View(query);
        }
        public IActionResult SaveForms(Product product)
        {
            #region Upload
            string GET = Path.GetExtension(product.Image.FileName);

            string UnicFileName = Guid.NewGuid() + product.Image.FileName;
            string UploadFolder = Path.Combine(webHostEnvironment.WebRootPath, UnicFileName);
            using (FileStream fs = new FileStream(UploadFolder, FileMode.Create))
            {
                product.Image.CopyTo(fs);
            }
            #endregion

            #region Save_to_db
            product.ImagePath = UnicFileName;
            contextdbs.Products.Add(product);
            contextdbs.SaveChanges();
            #endregion
            return RedirectToAction("Index");
        }
    }
}