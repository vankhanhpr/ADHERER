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
    public class AdBonusResponsitory: Responsitory<Bonus>, IAdBonusResponsitory
    {
        private DbSet<Bonus> bonusEntinty;
        public AdBonusResponsitory(MyDBContext context) : base(context)
        {
            bonusEntinty = context.Set<Bonus>();
        }

        public void deleteBonus(int id)
        {
            bonusEntinty.Remove(getBonusById(id));
            context.SaveChanges();
        }

        public IEnumerable<Bonus> getAllBonus(int fileid)
        {
            return context.Bonus.Where(m=>m.fileid==fileid).ToList();
        }

        public Bonus getBonusById(int id)
        {
            return context.Bonus.Where(m => m.bnid == id).FirstOrDefault();
        }

        public void insertBonus(Bonus bonus)
        {
            context.Entry(bonus).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateBonus(Bonus bonus)
        {
            context.Update(bonus);
            context.SaveChanges();
        }
    }
}
