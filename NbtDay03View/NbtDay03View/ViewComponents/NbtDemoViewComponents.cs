using Microsoft.AspNetCore.Mvc;
using NbtDay03View.Models;

namespace NbtDay03View.ViewComponents
{
    public class NbtDemoViewComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Category> categories = new List<Category>()
            {
                new Category {Id=1,Name= "Dien tu" },
                new Category {Id=2,Name= "Dien lanh" },
                new Category {Id=3,Name= "Do gia dung" },
                new Category {Id=4,Name= "Tien ich" },
            };
            return View(categories);
            

        }
    }
}
