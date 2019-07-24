using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.data;
using WebApi.model;
using WebApi.responsitory;
using WebApi.serrvice.admin.interfaces;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.admin.responsitory
{
    public class AdUserResponsitory : Responsitory<Users>, IAdUserResponsitory
    {
        private DbSet<Users> userEntity;
        public AdUserResponsitory(MyDBContext context) : base(context)
        {
            userEntity = context.Set<Users>();
        }
        public dynamic getAllUser(int page, int pagesize)
        {
            var dangvien = context.Users.Select(user => new
            {
                user,
                file = from file1 in context.Files
                       join nation in context.Nation on file1.dantoc equals nation.nationid
                       select new
                       {
                           file1,
                           nation
                       }
            }).Where(n=>n.user.active==true).Skip(page*pagesize).Take(pagesize).ToList();
            return dangvien;
        }

        public void insertUser(Users user)
        {
            context.Entry(user).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateUser(Users user)
        {
            context.Update(user);
            context.SaveChanges();
        }
    }
}
