using ASP.NET_CORE_HTML5_WebSite.Domain.Entities;
using ASP.NET_CORE_HTML5_WebSite.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_CORE_HTML5_WebSite.Domain.Repositories.EntityFramwork
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext _context;

        public EFServiceItemsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return _context.ServiceItems;
        }


        public ServiceItem GetServiceItemById(Guid id)
        {
            return _context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }


        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            _context.ServiceItems.Remove(new ServiceItem() { Id = id });
            _context.SaveChanges();
        }

    }
}
