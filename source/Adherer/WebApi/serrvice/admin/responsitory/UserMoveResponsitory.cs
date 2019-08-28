using AdhererClassLib.area.main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.data;
using WebApi.responsitory;
using WebApi.serrvice.admin.interfaces;

namespace WebApi.serrvice.admin.responsitory
{
    public class UserMoveResponsitory:Responsitory<UserMove>, IUserMoveResponsitory
    {
        private DbSet<UserMove> userMovesEntiry;
        public UserMoveResponsitory(MyDBContext context) : base(context)
        {
            userMovesEntiry = context.Set<UserMove>();
        }

        public dynamic getUserByChiBo(int id)
        {
            var dangvien = from user in context.Users
                           join file in context.Files
                           on user.usid equals file.usid
                           where (user.cbid == id && user.active == false)
                           select new
                           {
                               user,
                               file
                           };
            return dangvien;
        }

        public void insertUserMove(UserMove userMove)
        {
            context.Entry(userMove).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateUserMove(UserMove userMove)
        {
            context.Update(userMove);
            context.SaveChanges();
        }
    }
}
