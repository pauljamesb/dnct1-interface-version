using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNCT5.Models;

namespace DNCT5.Services
{
    public interface IItemService
    {
        Task<Item[]> GetIncompleteItemsAsync();
    }
}