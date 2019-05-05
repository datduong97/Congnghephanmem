using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Models;
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
        
        public virtual async Task<IActionResult> Create()
        {
            var retail = new TableEditViewModel();
            return View(retail);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Table table)
        {
            string name = table.name;
            bool status = table.status;
            var entity = await _manager.AddAsync(new Table
            {
                name = name,
                status = status,
            });
            return Json(entity);
        }

    }
}
