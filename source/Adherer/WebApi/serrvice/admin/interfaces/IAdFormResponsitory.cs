using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.interfaces.responsitory;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.admin.interfaces
{
    public interface IAdFormResponsitory: IResponsitory<Forms>
    {
        IEnumerable<Forms> getAllForm(int type);
        void insertForm(Forms form);
        void updateForm(Forms form);
        void deleteForm(int id);
        Forms findFormById(int id);
    }
}
