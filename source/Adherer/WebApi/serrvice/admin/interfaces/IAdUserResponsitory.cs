using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.interfaces.responsitory;
using WebApi.model;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.admin.interfaces
{
    public interface IAdUserResponsitory:IResponsitory<Users>
    {
        dynamic getAllUser(int page,int pagesize);
        void insertUser(Users user);
        void updateUser(Users user);
    }
}
