using System;
using System.Linq;
using System.Threading;
using Domain.Concrete;
using Domain.Entityes;

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
            #region BlogPhoto

            BlogPhotoContext blogPhotoContext = new BlogPhotoContext();
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog1 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog2 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog3 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog4 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog5 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog6 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog7 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog8 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog9 - min.jpg"
            });
            blogPhotoContext.BlogPhotos.Add(new BlogPhoto
            {
                PhotoUrl = "blog10 - min.jpg"
            });
            blogPhotoContext.SaveChanges();

            #endregion

            #region Site
            SiteContext siteContext = new SiteContext();
            #region Slider

            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 1,
                SiteAdress = "http://2016.makemepulse.com/",
                SlideName = "Сайт номер 1",
                SlidePicture = "slide1-min.jpg",
                SlideDescription = "Пример сайта номер 1",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 2,
                SiteAdress = "https://www.ifly50.com/en_ua/50",
                SlideName = "Сайт номер 2",
                SlidePicture = "slide2-min.jpg",
                SlideDescription = "Пример сайта номер 2",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 3,
                SiteAdress = "http://lederniergaulois.nouvelles-ecritures.francetv.fr/",
                SlideName = "Сайт номер 3",
                SlidePicture = "slide3-min.jpg",
                SlideDescription = "Пример сайта номер 3",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 4,
                SiteAdress = "http://www.because-recollection.com/",
                SlideName = "Сайт номер 4",
                SlidePicture = "slide4-min.jpg",
                SlideDescription = "Пример сайта номер 4",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 5,
                SiteAdress = "http://sonsofgallipoli.com/#!/",
                SlideName = "Сайт номер 5",
                SlidePicture = "slide5-min.jpg",
                SlideDescription = "Пример сайта номер 5",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 6,
                SiteAdress = "https://www.subaru.com/csr/environment.html#!/2016/01/22",
                SlideName = "Сайт номер 6",
                SlidePicture = "slide6-min.jpg",
                SlideDescription = "Пример сайта номер 6",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 7,
                SiteAdress = "http://www.philippundkeuntje.de/de#",
                SlideName = "Сайт номер 7",
                SlidePicture = "slide7-min.jpg",
                SlideDescription = "Пример сайта номер 7",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 8,
                SiteAdress = "http://void.hi-res.net/",
                SlideName = "Сайт номер 8",
                SlidePicture = "slide8-min.jpg",
                SlideDescription = "Пример сайта номер 8",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 9,
                SiteAdress = "http://silenza.it/",
                SlideName = "Сайт номер 9",
                SlidePicture = "slide9-min.jpg",
                SlideDescription = "Пример сайта номер 9",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 10,
                SiteAdress = "http://robinmastromarino.com/",
                SlideName = "Сайт номер 10",
                SlidePicture = "slide10-min.jpg",
                SlideDescription = "Пример сайта номер 10",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 11,
                SiteAdress = "http://www.plasticbcn.com/",
                SlideName = "Сайт номер 11",
                SlidePicture = "slide11-min.jpg",
                SlideDescription = "Пример сайта номер 11",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 12,
                SiteAdress = "https://stevenmengin.com/",
                SlideName = "Сайт номер 12",
                SlidePicture = "slide12-min.jpg",
                SlideDescription = "Пример сайта номер 12",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 13,
                SiteAdress = "http://viewfromabove.emirates.com/3d",
                SlideName = "Сайт номер 13",
                SlidePicture = "slide13-min.jpg",
                SlideDescription = "Пример сайта номер 13",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 14,
                SiteAdress = "https://www.spotify.com/int/why-not-available/",
                SlideName = "Сайт номер 14",
                SlidePicture = "slide14-min.jpg",
                SlideDescription = "Пример сайта номер 14",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 1,
                SiteAdress = "http://inspacewetrust.org/ru/",
                SlideName = "Сайт номер 15",
                SlidePicture = "slide15-min.jpg",
                SlideDescription = "Пример сайта номер 15",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 16,
                SiteAdress = "http://jetlag.photos/",
                SlideName = "Сайт номер 16",
                SlidePicture = "slide16-min.jpg",
                SlideDescription = "Пример сайта номер 16",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 17,
                SiteAdress = "http://www.doyoustillbelieve.com/",
                SlideName = "Сайт номер 17",
                SlidePicture = "slide17-min.jpg",
                SlideDescription = "Пример сайта номер 17",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 18,
                SiteAdress = "http://www.ashortjourney.com/",
                SlideName = "Сайт номер 18",
                SlidePicture = "slide18-min.jpg",
                SlideDescription = "Пример сайта номер 18",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 19,
                SiteAdress = "http://www.200miles.com/",
                SlideName = "Сайт номер 19",
                SlidePicture = "slide19-min.jpg",
                SlideDescription = "Пример сайта номер 19",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.SliderOfWorks.Add(new SliderOfWork
            {
                PrioritySlide = 20,
                SiteAdress = "http://70ans.inra.fr/",
                SlideName = "Сайт номер 20",
                SlidePicture = "slide20-min.jpg",
                SlideDescription = "Пример сайта номер 20",
                SlideDateCreate = DateTime.Now
            });
            Thread.Sleep(10);



            #endregion

            #region Калькулятор модулей

            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            siteContext.CalcSites.Add(new CalcSite
            {
                ModuleCategory = "Сайт-Визитка",
                ModuleName = "Модуль 1",
                ModuleDescription = "Описание модуля 1",
                ModulePrice = 300,
                ModuleDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            #endregion


            #endregion
        }
    }
}