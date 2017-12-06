using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                SiteContext siteContext = new SiteContext();
                DbSet<SliderOfWork> dbSet = siteContext.SliderOfWorks;
                if (!dbSet.Any()) // проверка на наличие БД и записей в слайдере
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

            #region Slider
            SiteContext siteContext = new SiteContext();
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
                SiteAdress =("http://70ans.inra.fr/").ToString(),
                SlideName = "Сайт номер 20",
                SlidePicture = "slide20-min.jpg",
                SlideDescription = "Пример сайта номер 20",
                SlideDateCreate = DateTime.Now
            });
            siteContext.SaveChanges();


            #endregion

            #region Orders

            siteContext.OrderSites.Add(new OrderSite
            {
                ClientName = "Вася",
                ClientEmail = "vasia@gmail.com",
                ClientPhone = "999999999999",
                OrderStatus = false,
                OrderDescription = "Хочу хороший сайту нама нама!",
                OrderDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.OrderSites.Add(new OrderSite
            {
                ClientName = "Дуся",
                ClientEmail = "dusia@gmail.com",
                ClientPhone = "999999999999",
                OrderStatus = false,
                OrderDescription = "Хочу сайтуууу!",
                OrderDateCreate = DateTime.Now
            });
            Thread.Sleep(10);
            siteContext.OrderSites.Add(new OrderSite
            {
                ClientName = "Петя",
                ClientEmail = "petr@gmail.com",
                ClientPhone = "999999999999",
                OrderStatus = false,
                OrderDescription = "Хочу бублик советский с маком",
                OrderDateCreate = DateTime.Now
            });
            Thread.Sleep(10);


            #endregion

            #region CalcModule
            CalcContext calcContext = new CalcContext();
            
            var module1 = new CalcSite
            {
                ModuleName = "Модуль 1",
                ModulePrice = 1000,
                ModuleDescription = "Описание модуля 1",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module2 = new CalcSite
            {
                ModuleName = "Модуль 2",
                ModulePrice = 100,
                ModuleDescription = "Описание модуля 2",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module3 = new CalcSite
            {
                ModuleName = "Модуль 3",
                ModulePrice = 1100,
                ModuleDescription = "Описание модуля 3",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module4 = new CalcSite
            {
                ModuleName = "Модуль 4",
                ModulePrice = 900,
                ModuleDescription = "Описание модуля 4",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module5 = new CalcSite
            {
                ModuleName = "Модуль 5",
                ModulePrice = 500,
                ModuleDescription = "Описание модуля 5",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module6 = new CalcSite
            {
                ModuleName = "Модуль 6",
                ModulePrice = 900,
                ModuleDescription = "Описание модуля 6",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module7 = new CalcSite
            {
                ModuleName = "Модуль 7",
                ModulePrice = 1200,
                ModuleDescription = "Описание модуля 7",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module8 = new CalcSite
            {
                ModuleName = "Модуль 8",
                ModulePrice = 1600,
                ModuleDescription = "Описание модуля 8",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module9 = new CalcSite
            {
                ModuleName = "Модуль 9",
                ModulePrice = 1000,
                ModuleDescription = "Описание модуля 9",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module10 = new CalcSite
            {
                ModuleName = "Модуль 10",
                ModulePrice = 1900,
                ModuleDescription = "Описание модуля 10",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module11 = new CalcSite
            {
                ModuleName = "Модуль 11",
                ModulePrice = 800,
                ModuleDescription = "Описание модуля 11",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module12 = new CalcSite
            {
                ModuleName = "Модуль 12",
                ModulePrice = 300,
                ModuleDescription = "Описание модуля 12",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module13 = new CalcSite
            {
                ModuleName = "Модуль 13",
                ModulePrice = 400,
                ModuleDescription = "Описание модуля 13",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module14 = new CalcSite
            {
                ModuleName = "Модуль 14",
                ModulePrice = 1100,
                ModuleDescription = "Описание модуля 14",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module15 = new CalcSite
            {
                ModuleName = "Модуль 15",
                ModulePrice = 600,
                ModuleDescription = "Описание модуля 15",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module16 = new CalcSite
            {
                ModuleName = "Модуль 16",
                ModulePrice = 900,
                ModuleDescription = "Описание модуля 16",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module17 = new CalcSite
            {
                ModuleName = "Модуль 17",
                ModulePrice = 1000,
                ModuleDescription = "Описание модуля 17",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module18 = new CalcSite
            {
                ModuleName = "Модуль 18",
                ModulePrice = 400,
                ModuleDescription = "Описание модуля 18",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module19 = new CalcSite
            {
                ModuleName = "Модуль 19",
                ModulePrice = 2000,
                ModuleDescription = "Описание модуля 19",
                ModuleDateCreate = DateTime.Now
            };
            Thread.Sleep(10);
            var module20 = new CalcSite
            {
                ModuleName = "Модуль 20",
                ModulePrice = 1500,
                ModuleDescription = "Описание модуля 20",
                ModuleDateCreate = DateTime.Now
            };
            calcContext.CalcSites.Add(module1);
            calcContext.CalcSites.Add(module2);
            calcContext.CalcSites.Add(module3);
            calcContext.CalcSites.Add(module4);
            calcContext.CalcSites.Add(module5);
            calcContext.CalcSites.Add(module6);
            calcContext.CalcSites.Add(module7);
            calcContext.CalcSites.Add(module8);
            calcContext.CalcSites.Add(module9);
            calcContext.CalcSites.Add(module10);
            calcContext.CalcSites.Add(module11);
            calcContext.CalcSites.Add(module12);
            calcContext.CalcSites.Add(module13);
            calcContext.CalcSites.Add(module14);
            calcContext.CalcSites.Add(module15);
            calcContext.CalcSites.Add(module16);
            calcContext.CalcSites.Add(module17);
            calcContext.CalcSites.Add(module18);
            calcContext.CalcSites.Add(module19);
            calcContext.CalcSites.Add(module20);
            calcContext.SaveChanges();
            #endregion

            #region ModuleCategory

            ModuleCategoryes category1 = new ModuleCategoryes
            {
                ModuleCategory = "Сайт - визитка",
                CalcSites = new List<CalcSite>()
            };
            ModuleCategoryes category2 = new ModuleCategoryes
            {
                ModuleCategory = "Landing Page",
                CalcSites = new List<CalcSite>()
            };
            ModuleCategoryes category3 = new ModuleCategoryes
            {
                ModuleCategory = "Интернет - Магазин",
                CalcSites = new List<CalcSite>()
            };
            ModuleCategoryes category4 = new ModuleCategoryes
            {
                ModuleCategory = "Корпоративный Сайт",
                CalcSites = new List<CalcSite>()
            };
            calcContext.ModuleCategoryes.Add(category1);
            calcContext.ModuleCategoryes.Add(category2);
            calcContext.ModuleCategoryes.Add(category3);
            calcContext.ModuleCategoryes.Add(category4);
            calcContext.SaveChanges();

            ModuleCategoryes moduleCategoryes1 =
                calcContext.ModuleCategoryes.FirstOrDefault(x => x.ModuleCategory == category1.ModuleCategory);
            if (moduleCategoryes1!=null)
            {
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module1.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module2.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module3.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module4.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module5.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module6.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module7.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module8.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module9.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module10.ModuleName));
                moduleCategoryes1.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module11.ModuleName));
            }
            ModuleCategoryes moduleCategoryes2 =
               calcContext.ModuleCategoryes.FirstOrDefault(x => x.ModuleCategory == category2.ModuleCategory);
            if (moduleCategoryes2 != null)
            {
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module12.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module20.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module3.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module7.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module17.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module16.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module19.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module8.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module13.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module12.ModuleName));
                moduleCategoryes2.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module11.ModuleName));
            }
            ModuleCategoryes moduleCategoryes3 =
               calcContext.ModuleCategoryes.FirstOrDefault(x => x.ModuleCategory == category3.ModuleCategory);
            if (moduleCategoryes3 != null)
            {
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module2.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module10.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module8.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module16.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module15.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module19.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module9.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module4.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module20.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module3.ModuleName));
                moduleCategoryes3.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module7.ModuleName));
            }
            ModuleCategoryes moduleCategoryes4 =
               calcContext.ModuleCategoryes.FirstOrDefault(x => x.ModuleCategory == category4.ModuleCategory);
            if (moduleCategoryes4 != null)
            {
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module20.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module1.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module5.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module15.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module12.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module11.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module6.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module8.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module18.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module9.ModuleName));
                moduleCategoryes4.CalcSites.Add(calcContext.CalcSites.FirstOrDefault(x => x.ModuleName == module2.ModuleName));
            }

            calcContext.SaveChanges();
            #endregion
        }
    }
}