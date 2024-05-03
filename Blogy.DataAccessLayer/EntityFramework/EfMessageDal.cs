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
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        private readonly BlogyContext _context;

        public EfMessageDal(BlogyContext context)
        {
            _context = context;
        }

        public List<Message> GetMessageListByWriter(string p)
        {
            var values = _context.Messages.Where(x => x.ReceiverMail == p).OrderByDescending(y => y.Date).ToList();
            return values;
        }
    }
}
