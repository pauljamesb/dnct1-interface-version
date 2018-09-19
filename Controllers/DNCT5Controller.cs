using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNCT5.Data;
using Microsoft.AspNetCore.Mvc;

using DNCT5.Models;
using DNCT5.Services;

namespace DNCT5.Controllers
{
    public class DNCT5Controller : Controller
    {

        private readonly IItemService _itemService;

        public DNCT5Controller(IItemService itemService)
        {
            _itemService = itemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _itemService.GetIncompleteItemsAsync();
            var model = new ItemsViewModel()
            {
                AllMyItems = items
            };

            return View(model);
            //return View(_db.Items.ToList());
        }
    }
}