using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class EfCalcSite : ICalcSite
    {
        readonly CalcContext _context = new CalcContext();
        public IEnumerable<CalcSite> CalcSites => _context.CalcSites;
        public void SaveModule(CalcSite calcSite,int categoryId)
        {
            if (calcSite.ModuleId == 0)
            {
                 CalcSite newCalcSite = new CalcSite 
                {
                    ModuleDescription = calcSite.ModuleDescription,
                    ModuleName = calcSite.ModuleName,
                    ModulePrice = calcSite.ModulePrice,
                    ModuleDateCreate = DateTime.Now
                };
                _context.CalcSites.Add(newCalcSite);
                _context.SaveChanges();

                ModuleCategoryes categoryes =       //связываем таблицы 
                   _context.ModuleCategoryes.FirstOrDefault(x => x.ModuleCategoryesId == categoryId);
                categoryes?.CalcSites.Add(_context.CalcSites.FirstOrDefault(x=>x.ModuleId == newCalcSite.ModuleId));
                _context.SaveChanges();
            }
            else
            {
                CalcSite editModule = _context.CalcSites.FirstOrDefault(x => x.ModuleId == calcSite.ModuleId);
                if (editModule != null)
                {
                    editModule.ModuleDescription = calcSite.ModuleDescription;
                    editModule.ModuleName = calcSite.ModuleName;
                    editModule.ModulePrice = calcSite.ModulePrice;
                    _context.SaveChanges();
                }
                else
                    throw new Exception();

                ModuleCategoryes categoryes =
                  _context.ModuleCategoryes.FirstOrDefault(x => x.ModuleCategoryesId == categoryId);
                categoryes?.CalcSites.Add(_context.CalcSites.FirstOrDefault(x => x.ModuleId == editModule.ModuleId));
                _context.SaveChanges();

            }
        }

        public void RemoveModule(int moduleId)
        {
            CalcSite removeModule = _context.CalcSites.FirstOrDefault(x => x.ModuleId == moduleId);
            if (removeModule != null)
            {
                _context.CalcSites.Remove(removeModule);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }
    }
}
