using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.Repository;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        private readonly BlogyContext _context;

        public EfWriterDal(BlogyContext context)
        {
            _context = context;
        }

        public void MakeActiveWriter(int id)
        {
            var values = _context.Writers.Find(id);
            values.Status = true;
            _context.Update(values);
            _context.SaveChanges(); 
        }

        public void MakePassiveWriter(int id)
        {
            var values = _context.Writers.Find(id);
            values.Status = false;
            _context.Update(values);
            _context.SaveChanges();
        }
    }
}
