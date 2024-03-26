using Blogy.DataAccessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleDal
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void Delete(int id)
        {
            if (id != 0)
            {
                _articleDal.Delete(id);
            }
            else
            {
                //hata mesajı
            }
        }

        public Article GetById(int id)
        {
            //eğer id değerine göre yetkisi varsa
            return _articleDal.GetById(id);
        }

        public List<Article> GetListAll()
        {
            return _articleDal.GetListAll();
        }

        public void Insert(Article entity)
        {
            if (entity != null && entity.Description.Length > 50 && entity.CategoryId >= 0)
            {
                _articleDal.Insert(entity);
            }
            else
            {
                //hata mesajı
            }
        }

        public void Update(Article entity)
        {
            if (entity != null && entity.Description.Length > 50 && entity.CategoryId >= 0)
            {
                _articleDal.Update(entity);
            }
            else
            {
                //hata mesajı
            }
        }
    }
}
