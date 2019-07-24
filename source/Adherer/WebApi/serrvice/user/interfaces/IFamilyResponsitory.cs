using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.interfaces.responsitory;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.user.interfaces
{
    public interface IFamilyResponsitory: IResponsitory<Family>
    {
        IEnumerable<Family> getFamilyByFileId(int fileid);
    }
}
