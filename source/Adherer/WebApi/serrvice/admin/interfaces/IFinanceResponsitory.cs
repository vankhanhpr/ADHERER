using AdhererClassLib.area.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.interfaces.responsitory;
using WebApi.responsitory;

namespace WebApi.serrvice.admin.interfaces
{
    public interface IFinanceResponsitory:IResponsitory<Finance>
    {
        dynamic getFinanceByStatus(int status);
        Finance getFinanceById(int id);
        void insertFinance(Finance finance);
        void updateFinance(Finance finance);
        void deleteFinance(int id);

        dynamic revanue(int year);
        dynamic getTotalMoney();
    }
}
