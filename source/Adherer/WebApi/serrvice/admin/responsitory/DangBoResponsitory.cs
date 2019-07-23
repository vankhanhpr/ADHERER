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
    public class DangBoResponsitory : Responsitory<DangBo>, IDangBoResponsitory
    {
        private DbSet<DangBo> dangBoEntiry;
        public DangBoResponsitory(MyDBContext context): base(context)
        {
            dangBoEntiry = context.Set<DangBo>();
        }
        public dynamic getAllDangBo()
        {
            throw new NotImplementedException();
        }

        public void insertDangBo(DangBo db)
        {
            throw new NotImplementedException();
        }

        public void updateDangBo(DangBo db)
        {
            throw new NotImplementedException();
        }
    }
}
