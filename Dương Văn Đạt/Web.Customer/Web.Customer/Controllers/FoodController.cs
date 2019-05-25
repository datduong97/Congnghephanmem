using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Customer.Data;
using Web.Customer.Models;
using Web.Customer.Services;

namespace Web.Customer.Controllers
{
    public class FoodController : Controller
    {
        private IFoodManager _manager;

        public FoodController(IFoodManager manager)
        {
            _manager =manager;
        }

        // GET: Food
        public async Task<IActionResult> Index()
        {
            return View(await _manager.GetTablesAsync());
        }


        [HttpGet]
        public virtual async Task<IActionResult> Create()
        {
            var rs = await _manager.GetTablesAsync();
            ViewBag.table = rs;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idFood,Name,idCategoryFood,price,image")] FoodModel foodModel)
        {

            var entyti = await _manager.AddAsync(foodModel.ToModel());
            //return RedirectToAction(nameof(Index));
            return Json(entyti);

        }

    }
}
