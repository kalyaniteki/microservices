using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersService.Models;

namespace OrdersService.Repositories
{
   public interface IOrders
    {
        List<Orders> GetOrders();
        Orders GetById(string id);
        void AddItems(Orders order);
        void Delete(int id);
        void Update(Orders order);

    }
}
