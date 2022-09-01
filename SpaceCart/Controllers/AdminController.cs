using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpaceCart.Data;
using SpaceCart.Models.ViewModel;

namespace SpaceCart.Controllers
{
    public class AdminController : Controller
    {
        UnitOfWork unit = new UnitOfWork();
        [Route("admin/products")]
        public IActionResult AdminProducts()
        {
            Console.WriteLine(User.Identity.IsAuthenticated);
            //if (User.Identity.IsAuthenticated)
            //{
                var user = unit
                    .UserRepository
                    .Get(x => x.Email == User.Identity.Name, includeProperties: "Role")
                    .FirstOrDefault();
                //if (user.Role.Name != "Administrator")
                //    return RedirectToAction("Index", "Home");

                var products = unit.ProductRepository.Get(includeProperties: "CreatorUser").ToList();

                AdminProducts model = new AdminProducts()
                {
                    Products = products
                };
                return View("Products", model);

            //}
            //return RedirectToAction("Index", "Home");
        }
        [Route("admin/users")]
        public IActionResult AdminUsers()
        {
            var users = unit.UserRepository.Get(includeProperties: "Role").ToList();

            var index = users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            users.Remove(index);

            var admins = users.Where(x => x.Role.Name == "Administrator").ToList();
            var moderators = users.Where(x => x.Role.Name == "Moderator").ToList();
            var simple = users.Where(x => x.Role.Name == "SimpleUser").ToList();

            AdminUsers model = new AdminUsers()
            {
                Users = simple,
                Admins = admins,
                Moderators = moderators
            };
            return View("Users", model);
        }
    }
}