using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class EfBlogRepository : IBlogRepository
    {
        readonly BlogContext _context = new BlogContext();
        public IEnumerable<Blog> Blogs => _context.Blogs;

        public void SaveNews(Blog blog)
        {
            if (blog.NewsId == 0)
            {
                _context.Blogs.Add(new Blog
                {
                    NewsCategory = blog.NewsCategory,
                    NewsDescription = blog.NewsDescription,
                    NewsName = blog.NewsName,
                    MiniPhoto = blog.MiniPhoto,
                    MainPhoto = blog.MainPhoto,
                    AltPhoto = blog.AltPhoto,
                    TitlePhoto = blog.TitlePhoto,
                    NewsContent = blog.NewsContent,
                    PopularityNews = blog.PopularityNews,
                    NewsDateCreate = DateTime.Now
                });
                _context.SaveChanges();
            }
            else
            {
                Blog editBlog = _context.Blogs.FirstOrDefault(x => x.NewsId == blog.NewsId);
                if (editBlog != null)
                {
                    editBlog.NewsCategory = blog.NewsCategory;
                    editBlog.NewsDescription = blog.NewsDescription;
                    editBlog.NewsName = blog.NewsName;
                    editBlog.MiniPhoto = blog.MiniPhoto;
                    editBlog.MainPhoto = blog.MainPhoto;
                    editBlog.AltPhoto = blog.AltPhoto;
                    editBlog.TitlePhoto = blog.TitlePhoto;
                    editBlog.NewsContent = blog.NewsContent;
                    editBlog.PopularityNews = blog.PopularityNews;
                    _context.SaveChanges();
                }
                else
                    throw new Exception();
            }
        }

        public void RemoveNews(int blogId)
        {
            Blog removeBlog = _context.Blogs.FirstOrDefault(x => x.NewsId == blogId);
            if (removeBlog != null)
            {
                _context.Blogs.Remove(removeBlog);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }

        public void PopularityUp(int blogId)
        {
            Blog newsUp = _context.Blogs.FirstOrDefault(x => x.NewsId == blogId);
            if (newsUp!=null)
            {
                newsUp.PopularityNews++;
                _context.SaveChanges();
            }
            else
             throw new Exception();
        }
    }
}
