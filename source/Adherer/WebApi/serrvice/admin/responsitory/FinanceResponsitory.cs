using AdhererClassLib.area.main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.data;
using WebApi.interfaces.responsitory;
using WebApi.responsitory;
using WebApi.serrvice.admin.interfaces;

namespace WebApi.serrvice.admin.responsitory
{

    public class FinanceResponsitory:Responsitory<Finance>, IFinanceResponsitory
    {
        private DbSet<Finance> financeEntity;
        public FinanceResponsitory(MyDBContext context) : base(context)
        {
            financeEntity = context.Set<Finance>();
        }

        public void deleteFinance(int id)
        {
            var fi = getFinanceById(id);
            financeEntity.Remove(fi);
            context.SaveChanges();
        }

        public Finance getFinanceById(int id)
        {
            return context.Finance.Where(m => m.financeid == id).FirstOrDefault();
        }

        public dynamic getFinanceByStatus(int status)
        {
            return context.Finance.Where(m => m.status == status).ToList();
        }

        public void insertFinance(Finance finance)
        {
            context.Entry(finance).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateFinance(Finance finance)
        {
            context.Update(finance);
            context.SaveChanges();
        }
    }
}
