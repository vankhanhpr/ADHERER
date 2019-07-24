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
    public class AdDisciplineResponsitory:Responsitory<Discipline>, IAdDisciplineResponsitory
    {
        private DbSet<Discipline> disciplinesEntity;
        public AdDisciplineResponsitory(MyDBContext context) : base(context)
        {
            disciplinesEntity = context.Set<Discipline>();
        }

        public void deleteDiscipline(int id)
        {
            Discipline discipline = findDisciplineById(id);
            if (discipline != null)
            {
                disciplinesEntity.Remove(discipline);
            }
        }

        public Discipline findDisciplineById(int id)
        {
            return context.Discipline.Where(m => m.dsid == id).FirstOrDefault();
        }

        public IEnumerable<Discipline> getAllDiscipline(int fileid)
        {
            return context.Discipline.Where(m => m.fileid == fileid).ToList();
        }

        public void insertDiscipline(Discipline discipline)
        {
            context.Entry(discipline).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateDisciplines(Discipline discipline)
        {
            context.Update(discipline);
            context.SaveChanges();
        }
    }
}
