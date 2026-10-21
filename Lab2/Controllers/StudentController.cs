using Microsoft.AspNetCore.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();

        public StudentController()
        {
            listStudents = new List<Student>()
            {
                new Student() { Id = 101, Name = "Hải Nam", Branch = "CNTT", Gender = Gender.Nam, IsRegular = true, Address = "A1-2018", Email = "nam@g.com" },
                new Student() { Id = 102, Name = "Minh Tú", Branch = "Kinh tế", Gender = Gender.Nữ, IsRegular = true, Address = "A1-2019", Email = "tu@g.com" },
                new Student() { Id = 103, Name = "Hoàng Phong", Branch = "Công trình", Gender = Gender.Nam, IsRegular = false, Address = "A1-2020", Email = "phong@g.com" },
                new Student() { Id = 104, Name = "Xuân Mai", Branch = "Điện - Điện tử", Gender = Gender.Nữ, IsRegular = false, Address = "A1-2021", Email = "mai@g.com" }
            };
        }

        public IActionResult Index()
        {
            return View(listStudents);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
