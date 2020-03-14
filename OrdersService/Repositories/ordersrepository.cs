using OrdersService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersService.Repositories
{
    public class ordersrepository : IOrders
    {
        private readonly ShopDBContext _context;
        public ordersrepository(ShopDBContext context)
        {
            _context = context;
        }
        
        public void AddItems(Orders order)
        {
            _context.Add(order);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Orders o = _context.Orders.Find(id);
            _context.Remove(o);
            _context.SaveChanges();
        }

        public Orders GetById(string id)
        {
            Orders o = _context.Orders.Find(id);
            return o;
        }

        public List<Orders> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public void Update(Orders order)
        {
            _context.Orders.Find(order);
            _context.SaveChanges();
        }
    }
}
