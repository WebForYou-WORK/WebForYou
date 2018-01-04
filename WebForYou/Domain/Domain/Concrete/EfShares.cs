using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Domain.Abstrac;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class EfShares: IShares
    {
        readonly SharesContext _context = new SharesContext();
        public IEnumerable<Shares> Shareses => _context.Shareses;
        public void SaveShares(Shares shares)
        {
            if (shares.SharesId == 0)
            {
                _context.Shareses.Add(new Shares
                {
                    SharesName = shares.SharesName,
                    PictureShares = shares.PictureShares,
                    SharesDescription = shares.SharesDescription,
                    ShareDateCreate = DateTime.Now
                });
                _context.SaveChanges();
            }
            else
            {
                Shares editShares = _context.Shareses.FirstOrDefault(x => x.SharesId == shares.SharesId);
                if (editShares!= null)
                {
                    editShares.SharesName = shares.SharesName;
                    editShares.SharesDescription = shares.SharesDescription;
                    _context.SaveChanges();
                }
                else
                throw new Exception();
               
            }
        }

        public void RemoveShares(int sharesId, DirectoryInfo directory)
        {
            Shares removeShares = _context.Shareses.FirstOrDefault(x => x.SharesId == sharesId);
            if (removeShares!= null)
            {
                string photoUrl = removeShares.PictureShares;
                _context.Shareses.Remove(removeShares);
                _context.SaveChanges();
                foreach (FileInfo info in directory.GetFiles())
                {
                    if (photoUrl.Equals(info.ToString()))
                     info.Delete();
                }
            }
            else
                throw new Exception();
        }

        public void SaveSharesPhoto(int sharesId, string url)
        {
            Shares newShares = _context.Shareses.FirstOrDefault(x=>x.SharesId == sharesId);
            if (newShares!=null)
            {
                newShares.PictureShares = url;
                _context.SaveChanges();
            }
            else 
                throw new Exception();
        }

        public void RemoveSharesPhoto(int sharesId, DirectoryInfo directory)
        {
            Shares removePicture = _context.Shareses.FirstOrDefault(x => x.SharesId== sharesId);
            if (removePicture != null)
            {
                string urlDell = removePicture.PictureShares;
                removePicture.PictureShares = "new";
                _context.SaveChanges();
                foreach (FileInfo file in directory.GetFiles())
                {
                    if (file.ToString() == urlDell)
                        file.Delete();
                }
            }
            else
                throw new Exception();
        }
    }
}
