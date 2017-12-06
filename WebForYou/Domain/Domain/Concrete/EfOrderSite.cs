using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class EfOrderSite : IOrderSite
    {
        readonly SiteContext _context = new SiteContext();
        public IEnumerable<OrderSite> OrderSites => _context.OrderSites;

        public void SaveOrder(OrderSite orderSite)
        {
            if (orderSite != null)
            {
                _context.OrderSites.Add(new OrderSite
                {
                    ClientName = orderSite.ClientName,
                    ClientPhone = orderSite.ClientPhone,
                    ClientEmail = orderSite.ClientEmail,
                    OrderDescription = orderSite.OrderDescription,
                    OrderDateCreate = DateTime.Now,
                    OrderStatus = false
                });
            }
            else
                throw new Exception();
        }

        public void RemoveOrder(int orderId)
        {
            OrderSite remuveOrderSite = _context.OrderSites.FirstOrDefault(x => x.OrderId == orderId);
            if (remuveOrderSite != null)
            {
                _context.OrderSites.Remove(remuveOrderSite);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }

        public void ChangeOfStatus(int orderId)
        {
            OrderSite changeOfStatusOrderSite = _context.OrderSites.FirstOrDefault(x => x.OrderId == orderId);
            if (changeOfStatusOrderSite != null)
            {
                if (changeOfStatusOrderSite.OrderStatus)
                {
                    changeOfStatusOrderSite.OrderStatus = false;
                    _context.SaveChanges();
                }
                else
                {
                    changeOfStatusOrderSite.OrderStatus = true;
                    _context.SaveChanges();
                }
            }
            else
                throw new Exception();
        }
    }
}
