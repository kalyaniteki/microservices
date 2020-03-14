using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemServices.Models;


namespace ItemServices.repositories
{
    public interface IItem
    {
        List<Items> GetAllItems();
        Items GetById(string id);
        void AddItems(Items items);
        void delete(string id);
        void update(Items item);


    }
}
