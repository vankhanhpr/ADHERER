using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.data;
using WebApi.responsitory;
using WebApi.serrvice.admin.interfaces;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.admin.responsitory
{
    public class AdToabroadResponsitory:Responsitory<Toabroad>, IAdToabroadResponsitory
    {
        private DbSet<Toabroad> toabroadsEntity;
        public AdToabroadResponsitory(MyDBContext context) : base(context)
        {
            toabroadsEntity = context.Set<Toabroad>();
        }

        public void deleteToabroad(int id)
        {
            Toabroad toabroad = findToabroadById(id);
            if (toabroad != null)
            {
                toabroadsEntity.Remove(toabroad);
                context.SaveChanges();
            }
        }

        public Toabroad findToabroadById(int id)
        {
            return context.Toabroad.Where(m => m.brid == id).FirstOrDefault();
        }

        public IEnumerable<Toabroad> getAllToabroad(int fileid)
        {
            return context.Toabroad.Where(m => m.fileid == fileid).ToList();
        }

        public void insertToabroad(Toabroad toabroad)
        {
            context.Entry(toabroad).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateToabraod(Toabroad toabroad)
        {
            context.Update(toabroad);
            context.SaveChanges();
        }
    }
}
