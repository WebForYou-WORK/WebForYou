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
                        _context.SaveChanges();
                }
                else
                    throw new Exception();
            }
        }

        public void RemoveNews(int blogId)
        {
            Blog removeBlog = _context.Blogs.FirstOrDefault(x => x.NewsId == blogId);
            if (removeBlog!=null)
            {
                    _context.Blogs.Remove(removeBlog);
                    _context.SaveChanges();
            }
            else
                throw new Exception();
        }
    }
}
