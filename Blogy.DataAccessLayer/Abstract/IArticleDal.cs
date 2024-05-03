using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Abstract
{
    public interface IArticleDal:IGenericDal<Article>
    {
        List<Article> GetArticlesWithWriter();
        Writer GetWriterInfoByArticleWriter(int id);
        List<Article> GetArticlesByWriter(int id);
        Article GetArticleByIdWithWriterAndCategory(int id);


        List<Article> Last4PostList();
        List<Article> GetOtherBlogPostByWriter(int id);
        List<Article> GetArticleSearch(string search);
        List<Article> GetArticleByWriterAndCategory(int id);

    }
}
