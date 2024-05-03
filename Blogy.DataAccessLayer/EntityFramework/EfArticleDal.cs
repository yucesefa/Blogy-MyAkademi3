using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.Repository;
using Blogy.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>,  IArticleDal
    {
        private readonly BlogyContext _context;

        public EfArticleDal(BlogyContext context)
        {
            _context = context;
        }

        public List<Article> GetArticlesByWriter(int id)
        {
            var values = _context.Articles.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public List<Article> GetArticlesWithWriter()
        {
            var values = _context.Articles.Include(x=>x.Writer).ToList();
            return values;
        }

        public Article GetArticleByIdWithWriterAndCategory(int id)
        {
            var values = _context.Articles.Where(x=>x.ArticleId==id).Include(x=>x.Writer).Include(x=>x.Category).FirstOrDefault();
            return values;
        }

        public Writer GetWriterInfoByArticleWriter(int id)
        {
            var values = _context.Articles.Where(x => x.ArticleId == id).Select(y => y.Writer).FirstOrDefault();
            return values;
        }

        public List<Article> Last4PostList()
        {
            var values = _context.Articles.OrderByDescending(x => x.CreatedDate).Take(4).ToList();
            return values;
        }

        public List<Article> GetOtherBlogPostByWriter(int id)
        {
            var values = _context.Articles.Where(x => x.AppUserId == id).OrderByDescending(x=>x.CreatedDate).Take(3).ToList();
            return values;
        }

        public List<Article> GetArticleSearch(string search)
        {
            var values = _context.Articles.Where(x => x.Title.Contains(search)).Include(x => x.Writer).ToList();
            return values;
        }

        public List<Article> GetArticleByWriterAndCategory(int id)
        {
            var values = _context.Articles.Where(x => x.AppUserId == id).Include(x => x.Category).ToList();
            return values;
        }
    }
}
