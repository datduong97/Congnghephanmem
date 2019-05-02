using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Services;
using Web.Customer.Stores;

namespace Web.Customer.Controllers
{
    public class TableController:Controller
    {
        ITableManager _manager;
        public TableController(ITableManager manager)
        {
            _manager = manager;
            
        }
        
        public async Task <IActionResult> Index()
        {

            var rs = await _manager.GetTablesAsync();
            ViewBag.table = rs;
            return View();

            
        }

        public async Task <IActionResult> AddAsync()
        {


            var entity = await _manager.AddAsync(new Table
            {
                name = "Ban1",
                status = true,
            });
            return Json(entity);


        }

    }
}
