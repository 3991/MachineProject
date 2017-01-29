using MachineProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MachineProject.Controllers
{
    [Authorize]
    public class ResultOperationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ResultOperation/NewScore
        public ActionResult NewScore(int checkingAccountId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewScore(ResultOperation resultOperation)
        {
            if (ModelState.IsValid)
            {
                db.ResultOperations.Add(resultOperation);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}