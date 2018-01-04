using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac.Modules;
using Domain.Entityes.Modules;

namespace Domain.Concrete.Modules
{
    public class EfWebsiteCardCalc: IWebsiteCardCalc
    {
        readonly CalcWebsiteCardContext _context = new CalcWebsiteCardContext();
        public IEnumerable<WebsiteCardCalc> CalcWebsiteCardSites => _context.WebsiteCardCalcs;
        public void SaveModule(WebsiteCardCalc websiteCardCalc)
        {
            if (websiteCardCalc.ModuleId==0)
            {
                _context.WebsiteCardCalcs.Add(new WebsiteCardCalc
                {
                    ModuleName = websiteCardCalc.ModuleName,
                    ModuleDescription = websiteCardCalc.ModuleDescription,
                    ModulePrice = websiteCardCalc.ModulePrice,
                    ModuleCategory = websiteCardCalc.ModuleCategory
                });
                _context.SaveChanges();
            }
            else
            {
                WebsiteCardCalc editWebsiteCardCalc =
                    _context.WebsiteCardCalcs.FirstOrDefault(x => x.ModuleId == websiteCardCalc.ModuleId);
                if (editWebsiteCardCalc!= null)
                {
                    editWebsiteCardCalc.ModuleName = websiteCardCalc.ModuleName;
                    editWebsiteCardCalc.ModuleCategory = websiteCardCalc.ModuleCategory;
                    editWebsiteCardCalc.ModuleDescription = websiteCardCalc.ModuleDescription;
                    editWebsiteCardCalc.ModulePrice = websiteCardCalc.ModulePrice;
                    _context.SaveChanges();
                }
                else
                   throw new Exception();
            }
        }

        public void RemoveModule(int moduleId)
        {
            WebsiteCardCalc removeWebsiteCardCalc = _context.WebsiteCardCalcs.FirstOrDefault(x => x.ModuleId == moduleId);
            if (removeWebsiteCardCalc!=null)
            {
                _context.WebsiteCardCalcs.Remove(removeWebsiteCardCalc);
                _context.SaveChanges();
            }
            else
             throw new Exception();
        }
    }
}
