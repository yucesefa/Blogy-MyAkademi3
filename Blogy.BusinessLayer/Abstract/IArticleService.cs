using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        public List<Article> TGetArticleWithWriter();
        Writer TGetWriterInfoByArticleWriter(int id);
        List<Article> TGetArticlesByWriter(int id);
        Article TGetArticleByIdWithWriterAndCategory(int id);
        List<Article> TLast4PostList();
        List<Article> TGetOtherBlogPostByWriter(int id);
        List<Article> TGetArticleSearch(string search);
        List<Article> TGetArticleByWriterAndCategory(int id);
    }
}
