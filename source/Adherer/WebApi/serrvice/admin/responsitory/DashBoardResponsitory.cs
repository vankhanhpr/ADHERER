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
    public class DashBoardResponsitory : Responsitory<DangBo>, IDashBoardResponsitory
    {
        private DbSet<DangBo> dangBoEntity;
        public DashBoardResponsitory(MyDBContext contex) : base(contex)
        {
            dangBoEntity = contex.Set<DangBo>();
        }

        public dynamic coundDangVienByMounth(int year)
        {
            var group = (from dav in context.Users
                         where(dav.ngaydenchibo.Year==year)
                         group dav by new { month = dav.ngaydenchibo.Month, year = dav.ngaydenchibo.Year } into d
                         select new
                         {
                             time = d.Key,
                             total = d.Count()
                         }).OrderBy(x=>x.time.month);
                return group;
        }
        public dynamic getDashBoard()
        {
            var dashboard = new
            {
                dangbo = context.Dangbo.Count(),
                daydangbo= context.Dangbo.OrderByDescending(m=>m.createday).FirstOrDefault().createday,
                chibo = context.Chibo.Count(),
                daychibo = context.Chibo.OrderByDescending(m => m.createday).FirstOrDefault().createday,
                dangvien = context.Users.Count(),
                daydangvien = context.Users.OrderByDescending(m => m.createday).FirstOrDefault().createday,
                donvi = context.Organization.Count(),
                daydonvi = context.Organization.OrderByDescending(m => m.createday).FirstOrDefault().createday,
                bieumau = context.Forms.Count(),
                dayform = context.Forms.OrderByDescending(m => m.updateday).FirstOrDefault().updateday,

            };
            return dashboard;
        }

        
    }
}
