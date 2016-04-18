using Alunos_Gest_Up.Models;
using System.Linq;
using System.Web.Mvc;

namespace Alunos_Gest_Up.Controllers
{
    public class HomeController : Controller
    {
        private StudentsMock objStudentsMock = new StudentsMock();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult FindAllStudents()
        {
            var studentsList = objStudentsMock.findAll().Select(s => new
            {
                Matricula = s.Matricula,
                Nome = s.Nome,
                Idade = s.Idade,
            });
            return Json(studentsList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult FindStudents(int take = 0)
        {
            var studentsList = objStudentsMock.findAll().Select(s => new
            {
                Matricula = s.Matricula,
                Nome = s.Nome,
                Idade = s.Idade,
            }).Take(take);
            return Json(studentsList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult FindOlderStudent()
        {
            var studentsList = objStudentsMock.findAll().Select(s => new
            {
                Matricula = s.Matricula,
                Nome = s.Nome,
                Idade = s.Idade,
            }).OrderByDescending(o=>o.Idade).Take(1);
            return Json(studentsList, JsonRequestBehavior.AllowGet);
        }
    }
}