using System.Linq;
using Domain.Concrete;

namespace WebForYouUI.Models
{
    public class DebugDb
    {
        public static void TestDb()
        {
            SiteContext siteContext  = new SiteContext();
            if (!siteContext.SliderOfWorks.Any()) // проверка на наличие БД и записей в слайдере
                AddToDb();// Если БД пустая - заполнит "тестовыми значениями"
        }
        public static void AddToDb()
        {
           
        }
    }
}