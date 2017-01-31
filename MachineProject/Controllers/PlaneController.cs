using MachineProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MachineProject.Controllers
{
    public class PlaneController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize(Roles = "admin")]
        // GET: PlaneController/GetPlanes
        public ActionResult GetPlanes()
        {
            return View(db.Planes.ToList());
        }

        // GET: PlaneController/GetPlaneById/Id
        public ActionResult GetPlaneById(int Id)
        {
            var res = db.Players.FirstOrDefault(s => s.ID == Id);
            if (res == null)
            {
                // ...
            }
            return View(res);
        }
    }
}