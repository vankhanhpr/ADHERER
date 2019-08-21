using Microsoft.AspNetCore.Mvc;
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

    public class AdFileResponsitory : Responsitory<Files>, IAdFileResponsitory
    {
        private DbSet<Files> fileEntity;
        public AdFileResponsitory(MyDBContext context) : base(context)
        {
            fileEntity = context.Set<Files>();
        }

        public Files getFileById(int id)
        {
            return context.Files.Where(m => m.fileid == id).FirstOrDefault();
        }

        public dynamic getFileByUsid(int id)
        {
            var dangvien = context
                .Users
                .Where(m => m.usid == id)
                .Select(user => new
                {
                    user,
                    file = (from filesdv in context.Files
                            join nation in context.Nation
                            on filesdv.dantoc equals nation.nationid
                            where filesdv.usid == user.usid
                            select new
                            {
                                user.usid,
                                user.madv,
                                filesdv.fileid,
                                filesdv.hotenkhaisinh,
                                filesdv.hotendangdung,
                                filesdv.ngaythangnamsinh,
                                filesdv.dantoc,
                                filesdv.gioitinh,
                                nation.name,
                                filesdv.tongiao,
                                filesdv.quequan,
                                filesdv.nghenghiep,
                                filesdv.solylich,
                                filesdv.donvi,
                                filesdv.sdt,
                                filesdv.email,
                                filesdv.ngayvaodangct,
                                filesdv.ngayvaodangdb,
                                filesdv.ngayvaodoan,
                                filesdv.trinhdovanhoa,
                                filesdv.chuyenmon,
                                filesdv.matp,
                                filesdv.maqh,
                                filesdv.xaid,
                                filesdv.noicutru,
                                filesdv.cmnd,
                                filesdv.daycmnd,
                                filesdv.noicapcmnd,
                                filesdv.hokhauthuongtru,
                                filesdv.honnhan,
                                filesdv.suckhoe,
                                filesdv.avatar
                            }).FirstOrDefault()
                }).FirstOrDefault();
            return dangvien;
        }

        public void insertFile(Files file)
        {
            context.Entry(file).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateFile(Files file, Boolean bol)
        {
            if (!bol)
            {
                context.Entry(file).State = EntityState.Added;
                context.SaveChanges();
            }
            else
            {
                context.Update(file);
                context.SaveChanges();
            }
        }
    }
}
