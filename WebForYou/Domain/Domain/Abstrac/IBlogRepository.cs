using System.Collections.Generic;
using Domain.Entityes;

namespace Domain.Abstrac
{
    public interface IBlogRepository
    {
        IEnumerable<Blog>Blogs { get; }
        void SaveNews(Blog blog);
        void RemoveNews(int blogId);
    }
}
