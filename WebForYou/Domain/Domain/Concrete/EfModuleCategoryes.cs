using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class EfModuleCategoryes : IModuleCategoryes
    {
        readonly CalcContext _context = new CalcContext();
        public IEnumerable<ModuleCategoryes> ModuleCategoryes => _context.ModuleCategoryes;

        public void SaveModuleCategory(ModuleCategoryes moduleCategoryes)
        {
            if (moduleCategoryes.ModuleCategoryesId == 0)
            {
                _context.ModuleCategoryes.Add(new ModuleCategoryes
                {
                    ModuleCategory = moduleCategoryes.ModuleCategory
                });
                _context.SaveChanges();
            }
            else
            {
                ModuleCategoryes editModuleCategoryes =
                    _context.ModuleCategoryes.FirstOrDefault(x => x.ModuleCategoryesId == moduleCategoryes.ModuleCategoryesId);
                if (editModuleCategoryes != null)
                {
                    editModuleCategoryes.ModuleCategory = moduleCategoryes.ModuleCategory;
                    _context.SaveChanges();
                }
                else
                    throw new Exception();
            }
        }

        public void RemoveModuleCategory(int moduleId)
        {
            ModuleCategoryes removeModuleCategoryes =
                _context.ModuleCategoryes.FirstOrDefault(x => x.ModuleCategoryesId == moduleId);
            if (removeModuleCategoryes != null)
            {
                _context.ModuleCategoryes.Remove(removeModuleCategoryes);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }
    }
}
