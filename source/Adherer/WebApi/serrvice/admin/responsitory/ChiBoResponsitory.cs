﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApi.data;
using WebApi.responsitory;
using WebApi.serrvice.admin.interfaces;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.admin.responsitory
{
    public class ChiBoResponsitory : Responsitory<ChiBo>, IChiBoResponsitory
    {
        private DbSet<ChiBo> chiBoEntity;
        public ChiBoResponsitory(MyDBContext context) : base(context)
        {
            chiBoEntity = context.Set<ChiBo>();
        }
        public dynamic getAllChiBo()
        {
            return context.Chibo.ToList();
        }

        public dynamic getChiBoByDB(int id)
        {
            return context.Chibo.Where(m => m.dbid == id).ToList();
        }

        public ChiBo getChiBoById(int id)
        {
            return context.Chibo.Where(m => m.cbid == id).FirstOrDefault();
        }

        public void insertChoBo(ChiBo cb)
        {
            context.Entry(cb).State = EntityState.Added;
            context.SaveChanges();
        }

        public void updateChiBo(ChiBo cb)
        {
            context.Update(cb);
            context.SaveChanges();
        }
    }
}
