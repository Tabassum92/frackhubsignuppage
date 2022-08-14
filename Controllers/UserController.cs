using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using frackhubsignup9.Models;

namespace frackhubsignup9.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
     public ActionResult signup(User U)
        {
            if (ModelState.IsValid)
            {
                using (Database1Entities dc = new Database1Entities())
                {
                    dc.Users.Add(U);
                    dc.SaveChanges();
                    ModelState.Clear();
                    U = null;
                    ViewBag.Message = "successfully registered";

                }
            }
            return View(U);
        }

    }
}