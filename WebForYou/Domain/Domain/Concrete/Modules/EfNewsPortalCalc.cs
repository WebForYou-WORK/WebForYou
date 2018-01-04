using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac.Modules;
using Domain.Entityes.Modules;

namespace Domain.Concrete.Modules
{
    public class EfNewsPortalCalc: INewsPortalCalc
    {
        readonly CalcNewsPortalContext _context = new CalcNewsPortalContext();
        public IEnumerable<NewsPortalCalc> CalcNewsPortalSites => _context.NewsPortalCalcs;
        public void SaveModule(NewsPortalCalc newsPortalCalc)
        {
            if (newsPortalCalc.ModuleId==0)
            {
                _context.NewsPortalCalcs.Add(new NewsPortalCalc
                {
                    ModuleCategory = newsPortalCalc.ModuleCategory,
                    ModuleDescription = newsPortalCalc.ModuleDescription,
                    ModuleName = newsPortalCalc.ModuleName,
                    ModulePrice = newsPortalCalc.ModulePrice
                });
                _context.SaveChanges();
            }
            else
            {
                NewsPortalCalc editNewsPortalCalc =
                    _context.NewsPortalCalcs.FirstOrDefault(x => x.ModuleId == newsPortalCalc.ModuleId);
                if (editNewsPortalCalc!= null)
                {
                    editNewsPortalCalc.ModuleCategory = newsPortalCalc.ModuleCategory;
                    editNewsPortalCalc.ModuleDescription = newsPortalCalc.ModuleDescription;
                    editNewsPortalCalc.ModuleName = newsPortalCalc.ModuleName;
                    editNewsPortalCalc.ModulePrice = newsPortalCalc.ModulePrice;
                    _context.SaveChanges();
                }
                else
                 throw new Exception();
            }
        }

        public void RemoveModule(int moduleId)
        {
            NewsPortalCalc removeNewsPortalCalc = _context.NewsPortalCalcs.FirstOrDefault(x => x.ModuleId == moduleId);
            if (removeNewsPortalCalc != null)
            {
                _context.NewsPortalCalcs.Remove(removeNewsPortalCalc);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }
    }
}
