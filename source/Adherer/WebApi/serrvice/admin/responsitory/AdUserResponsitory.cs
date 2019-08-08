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

        public void blockUser(int id)
        {
            Users users = getUserById(id);
            users.active = false;
            context.Update(users);
            context.SaveChanges();
        }

        public dynamic getAllUser(int page, int pagesize)
        {
            var dangvien = context.Users.Select(user => new
            {
                user,
                file = context.Files.Where(m => m.usid == user.usid).FirstOrDefault()
                //file = from file1 in context.Files
                //       join nation in context.Nation on file1.dantoc equals nation.nationid
                //       select new
                //       {
                //           file1,
                //           nation
                //       }
            }).Where(n => n.user.active == true).Skip(page * pagesize).Take(pagesize).ToList();
            return dangvien;
        }

        public dynamic getUserByActive(int active)
        {
            switch (active)
            {
                case 2:
                    {
                        var dangvien = context.Users.Select(user => new
                        {
                            user,
                            file = context.Files.Where(m => m.usid == user.usid).FirstOrDefault()
                        }).ToList();
                        return dangvien;
                    }
                    
                case 1:
                    {
                        var dangvien = context.Users.Select(user => new
                        {
                            user,
                            file = context.Files.Where(m => m.usid == user.usid).FirstOrDefault()
                        }).Where(n=>n.user.active==false).ToList();
                        return dangvien;
                    }

                case 0:
                    {
                        var dangvien = context.Users.Select(user => new
                        {
                            user,
                            file = context.Files.Where(m => m.usid == user.usid).FirstOrDefault()
                        }).Where(n => n.user.active == true).ToList();
                        return dangvien;
                    }
            }
            return null;
        }

        public dynamic getUserByBox(string filter)
        {
            var filterby = filter.Trim().ToLowerInvariant();
            var dangvien = context.Users.Select(user => new
            {
                user,
                file = context.Files.Where(m => m.usid == user.usid).FirstOrDefault()
            }).ToList().AsQueryable().Where(n=>
                  n.user.usid.ToString().ToLowerInvariant().Contains(filterby)
                ||n.user.madv.ToLowerInvariant().Contains(filterby)
                //||n.file.hotendangdung.ToLowerInvariant().Contains(filterby)
            );
            return dangvien;
        }

        public dynamic getUserByChiBo(int id, DateTime fromday, DateTime endday)
        {
            return context.Users.Where(m => m.cbid == id && m.ngaydenchibo >= fromday && m.ngaydenchibo <= endday ).ToList();
        }

        public Users getUserById(int id)
        {
            return context.Users.Where(m => m.usid == id).FirstOrDefault();
        }

        public Users getUserByMaDv(string madv)
        {
            return context.Users.Where(m => m.madv == madv).FirstOrDefault();
        }

        public dynamic getUserByRole(int role)
        {
            if (role == 0)
            {
                var dangvien = context.Users.Select(user => new
                {
                    user,
                    file = context.Files.Where(m => m.usid == user.usid).FirstOrDefault()
                }).ToList();
                return dangvien;
            }
            else
            {
                var dangvien = context.Users.Select(user => new
                {
                    user,
                    file = context.Files.Where(m => m.usid == user.usid).FirstOrDefault()
                }).Where(n => n.user.roleid == role).ToList();
                return dangvien;
            }
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
