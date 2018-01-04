using System.Collections.Generic;
using System.IO;
using Domain.Entityes;

namespace Domain.Abstrac
{
    public interface IBlogPhotoRepossitory
    {
        IEnumerable<BlogPhoto> BlogPhotos { get; }
        void SaveBlogPhoto(string urlName);
        void RemoveBlogPhoto(int photoId, DirectoryInfo directory);
    }
}
