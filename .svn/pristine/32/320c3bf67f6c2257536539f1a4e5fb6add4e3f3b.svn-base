using System;
using System.Collections.Generic;
using WebApi.interfaces.responsitory;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.admin.interfaces
{
    public interface IAdDisciplineResponsitory:IResponsitory<Discipline>
    {
        IEnumerable<Discipline> getAllDiscipline(int fileid);
        void insertDiscipline(Discipline discipline);
        void updateDisciplines(Discipline discipline);
        void deleteDiscipline(int id);
        Discipline findDisciplineById(int id);
    }
}
