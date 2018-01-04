using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Domain.Abstrac;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class EfBlogPhotoRepossitory : IBlogPhotoRepossitory
    {
        readonly BlogPhotoContext _context = new BlogPhotoContext();
        public IEnumerable<BlogPhoto> BlogPhotos => _context.BlogPhotos;


        public void SaveBlogPhoto(string urlName)
        {
                if (!string.IsNullOrEmpty(urlName))
                {
                    _context.BlogPhotos.Add(new BlogPhoto
                    {
                        PhotoUrl = urlName
                    });
                    _context.SaveChanges();
                }
                else
                    throw new Exception();
        }

        public void RemoveBlogPhoto(int photoId, DirectoryInfo directory)
        {
            BlogPhoto photo = _context.BlogPhotos.FirstOrDefault(x => x.BlogPhotoId == photoId);
            if (photo != null)
            {
                    var urlDell = photo.PhotoUrl;
                    _context.BlogPhotos.Remove(photo);
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
