using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Models;
using Web.Customer.Services;

namespace Web.Customer.Controllers
{
    public class BookedTableController: Controller
    {
        ITableManager _tablemanager;
        IBookedTableManager _manager;
        public BookedTableController(IBookedTableManager manager,ITableManager tableManager)
        {
            _manager = manager;
            _tablemanager = tableManager;
        }

        public virtual async Task<IActionResult> Create()
        {
            var rs = await _tablemanager.GetTablesAsync();
            ViewBag.table = rs; ;
            var retail = new BookedTableEditViewModel();
            return View(retail);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BookedTable bookedTable)
        {
            int idTable = bookedTable.idTable;
            string CustomerPhone = bookedTable.CustomerPhone;
            string CustomerName = bookedTable.CustomerName;
            string CustomerAddress = bookedTable.CustomerAddress;
            string BookDate = bookedTable.BookDate;
            string BookTimeStart = bookedTable.BookTimeStart;
            string BookTimeEnd = bookedTable.BookTimeEnd;

            var entity = await _manager.AddAsync(new BookedTable
            {
                idTable=idTable,
                CustomerAddress = CustomerAddress,
                CustomerName = CustomerName,
                CustomerPhone = CustomerPhone,
                BookDate = BookDate,
                BookTimeStart= BookTimeStart,
                BookTimeEnd= BookTimeEnd
            });
            return Json(entity);
        }



    }
}
