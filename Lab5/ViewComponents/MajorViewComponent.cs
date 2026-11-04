using Microsoft.AspNetCore.Mvc;
using Lab5.Data;
using Lab5.Models;

namespace Lab5.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        private readonly SchoolContext db;
        private List<Major> majors;

        public MajorViewComponent(SchoolContext context)
        {
            db = context;
            majors = db.Majors.ToList();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", majors);
        }
    }
}