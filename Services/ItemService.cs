using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using DNCT5.Data;
using DNCT5.Models;

namespace DNCT5.Services 
{

    public class ItemService : IItemService
    {

        private readonly ApplicationDbContext _db;
        public ItemService(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<Item[]> GetIncompleteItemsAsync()
        {
            var items = await _db.Items.ToArrayAsync();
            return items;
        }

    }



}