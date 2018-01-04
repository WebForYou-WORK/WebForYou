using System.Collections.Generic;
using Domain.Entityes;

namespace Domain.Abstrac
{
   public interface IOrderSite
    {
        IEnumerable<OrderSite> OrderSites { get; }
        void SaveOrder(OrderSite orderSite);
        void RemoveOrder(int orderId);
        void ChangeOfStatus(int orderId);
    }
}
