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
    public class BonusResponsitory: Responsitory<Bonus>, IBonusResponsitory
    {
        private DbSet<Bonus> bonusEntinty;
        public BonusResponsitory(MyDBContext context) : base(context)
        {
            bonusEntinty = context.Set<Bonus>();
        }

        public IEnumerable<Bonus> getBonusByFileId(int fileid)
        {
            return context.Bonus.Where(m => m.fileid == fileid).ToList();
        }
    }
}
