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
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        private readonly BlogyContext _context;

        public EfNotificationDal(BlogyContext context)
        {
            _context = context;
        }

        public List<Notification> GetListLast3Notification()
        {
            var values = _context.Notifications.OrderByDescending(x=>x.Date).Take(3).ToList();
            return values;
        }
    }
}
