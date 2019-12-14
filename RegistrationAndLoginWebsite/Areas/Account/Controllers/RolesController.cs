using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RegistrationAndLoginWebsite.Areas.Account.Models;
using RegistrationAndLoginWebsite.Data.Entity;

namespace RegistrationAndLoginWebsite.Areas.Account.Controllers
{
    [Area("Account")]
    public class RolesController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }


        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model)
        {

            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.name
                };

                var result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    ViewBag.message = " '' " + model.name + " '' " + " Role Created Successfully";

                    return View();
                }
                else
                {
                    ViewBag.message = "Sorry ! " + " '' " + model.name + " '' " + " This Role Can't Created";

                    return View();
                }
            }

            return View(model);
        }
    }
}