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
    public class FamilyResponsitory:Responsitory<Family>, IFamilyResponsitory
    {
        private DbSet<Family> familyEntity;
        public FamilyResponsitory(MyDBContext context) : base(context)
        {
            familyEntity = context.Set<Family>();
        }

        public IEnumerable<Family> getFamilyByFileId(int fileid)
        {
            return context.Family.Where(m => m.fileid == fileid).ToList();
        }
    }
}
