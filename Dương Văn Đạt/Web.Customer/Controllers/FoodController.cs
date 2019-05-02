using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Services;

namespace Web.Customer.Controllers
{
    public class FoodController : Controller
    {
        IFoodManager _manager;
        public FoodController(IFoodManager manager)
        {
            _manager = manager;

        }

        public async Task<IActionResult> Index()
        {

            var rs = await _manager.GetTablesAsync();
            ViewBag.table = rs;
            return View();


        }
    }
}
