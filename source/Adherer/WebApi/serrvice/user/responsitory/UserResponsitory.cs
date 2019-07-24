using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.data;
using WebApi.responsitory;
using WebApi.serrvice.admin.model;
using WebApi.serrvice.user.interfaces;

namespace WebApi.serrvice.user.responsitory
{
    public class UserResponsitory: Responsitory<Users>, IUserResponsitory
    {
        private DbSet<Users> userEntiry;
        public UserResponsitory(MyDBContext context) : base(context)
        {
            userEntiry = context.Set<Users>();
        }

        public dynamic getUserByMaDv(string madv)
        {
            return context.Users.Where(m => m.madv == madv).Select(user => new {
                user,
                file = context.Files.Where(m => m.usid == user.usid).FirstOrDefault()
            });
        }
    }
}
