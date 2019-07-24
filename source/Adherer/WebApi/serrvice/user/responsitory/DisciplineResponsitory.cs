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
    public class DisciplineResponsitory:Responsitory<Discipline>, IDisciplineResponsitory
    {
        private DbSet<Discipline> disciplineEntity;
        public DisciplineResponsitory(MyDBContext context) : base(context)
        {
            disciplineEntity = context.Set<Discipline>();
        }

        public IEnumerable<Discipline> getDisciplineByFileId(int fileid)
        {
            return context.Discipline.Where(m => m.fileid == fileid).ToList();
        }
    }
}
