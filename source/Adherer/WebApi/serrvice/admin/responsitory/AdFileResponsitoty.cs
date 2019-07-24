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

        public Files getFileByUsid(int id)
        {
            return context.Files.Where(m=>m.usid==id).FirstOrDefault();
        }

        public void insertFile(Files file)
        {
            context.Entry(file).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateFile(Files file)
        {
            context.Update(file);
            context.SaveChanges();
        }
    }
}
