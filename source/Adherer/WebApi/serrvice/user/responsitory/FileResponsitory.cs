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
    public class FileResponsitory:Responsitory<Files>,IFileResponsitory
    {
        private DbSet<Files> fileEntity;
        public FileResponsitory(MyDBContext context) : base(context)
        {
            fileEntity = context.Set<Files>();
        }

        public Files findFileById(int id)
        {
            return context.Files.Where(m => m.fileid == id).FirstOrDefault();
        }

        public Files getFileByUserId(int usid)
        {
            return context.Files.Where(m => m.usid == usid).FirstOrDefault();
        }

        public void insertFile(Files files)
        {
            context.Entry(files).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateFile(Files files)
        {
            context.Update(files);
            context.SaveChanges();
        }
    }
}
