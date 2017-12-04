using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class EfCalcSite : ICalcSite
    {
        readonly SiteContext _context = new SiteContext();
        public IEnumerable<CalcSite> CalcSites => _context.CalcSites;
        public void SaveModule(CalcSite calcSite)
        {
            if (calcSite.ModuleId == 0)
            {
                _context.CalcSites.Add(new CalcSite
                {
                    ModuleCategory = calcSite.ModuleCategory,
                    ModuleDescription = calcSite.ModuleDescription,
                    ModuleName = calcSite.ModuleName,
                    ModulePrice = calcSite.ModulePrice,
                    ModuleDateCreate = DateTime.Now
                });
                _context.SaveChanges();
            }
            else
            {
                CalcSite editModule = _context.CalcSites.FirstOrDefault(x => x.ModuleId == calcSite.ModuleId);
                if (editModule != null)
                {
                    editModule.ModuleCategory = calcSite.ModuleCategory;
                    editModule.ModuleDescription = calcSite.ModuleDescription;
                    editModule.ModuleName = calcSite.ModuleName;
                    editModule.ModulePrice = calcSite.ModulePrice;
                    _context.SaveChanges();
                }
                else
                    throw new Exception();
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
