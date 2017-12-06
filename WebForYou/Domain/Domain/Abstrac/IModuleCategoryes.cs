using System.Collections.Generic;
using Domain.Entityes;

namespace Domain.Abstrac
{
    public interface IModuleCategoryes
    {
        IEnumerable<ModuleCategoryes> ModuleCategoryes { get; }
        void SaveModuleCategory(ModuleCategoryes moduleCategoryes);
        void RemoveModuleCategory(int moduleId);
    }
}
