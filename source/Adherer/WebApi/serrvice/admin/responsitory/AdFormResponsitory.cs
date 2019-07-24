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
    public class AdFormResponsitory:Responsitory<Forms>,IAdFormResponsitory
    {

        private DbSet<Forms> formEntity;
        public AdFormResponsitory(MyDBContext context) : base(context)
        {
            formEntity = context.Set<Forms>();
        }

        public void deleteForm(int id)
        {
            Forms form = findFormById(id);
            if (form!=null)
            {
                formEntity.Remove(form);
                context.SaveChanges();
            }
        }

        public Forms findFormById(int id)
        {
            return context.Forms.Where(m => m.formid == id).FirstOrDefault();
        }

        public IEnumerable<Forms> getAllForm()
        {
            return context.Forms.ToList();
        }

        public void insertForm(Forms form)
        {
            context.Entry(form).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateForm(Forms form)
        {
            context.Update(form);
            context.SaveChanges();
        }
    }
}
