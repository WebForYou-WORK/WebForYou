using System.Collections.Generic;
using System.IO;
using Domain.Entityes;

namespace Domain.Abstrac
{
    public interface IShares
    {
        IEnumerable<Shares> Shareses { get; }
        void SaveShares(Shares shares);
        void RemoveShares(int sharesId, DirectoryInfo directory);
        void SaveSharesPhoto(int sharesId, string url);
        void RemoveSharesPhoto(int sharesId, DirectoryInfo directory);
    }
}
