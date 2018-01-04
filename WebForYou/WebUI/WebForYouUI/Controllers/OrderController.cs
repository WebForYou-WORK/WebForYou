using System;
using System.Web.Mvc;
using Domain.Entityes;

namespace WebForYouUI.Controllers
{
    public class OrderController : Controller
    {
        
        public ActionResult NewOrder() //плавающая кнопка
        {
            return View();
        }
        [HttpPost]
        public ActionResult OrderForm(int type) //вызов формы заказа
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewGneralOrder(OrderSite orderSite) //ответ на заказ
        {
           //todo
          return View();
        }
    }
}