using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.model;
using WebApi.model.request;
using WebApi.model.roles;
using WebApi.serrvice.admin.interfaces;
using WebApi.serrvice.admin.model;

namespace WebApi.controllers.admin
{
    [Authorize(Roles = Roles.Admin)]
    [Route("api/[controller]")]
    [ApiController]
    public class AdDisciplineController : Controller
    {
        private IAdDisciplineResponsitory m_adDisciplineResponsitory;
        public AdDisciplineController(IAdDisciplineResponsitory adDisciplineResponsitory)
        {
            m_adDisciplineResponsitory = adDisciplineResponsitory;
        }
        [HttpGet("getDiscipline")]
        public DataRespond getDiscipline(int fileid)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_adDisciplineResponsitory.getAllDiscipline(fileid);
                data.message = "success";
            }
            catch(Exception e)
            {
                data.message = e.Message;
                data.error = e;
                data.success = false;
            }
            return data;
        }

        [HttpPost("insertDiscipline")]
        public DataRespond insertDescipline(DisciplineRequest disrq)
        {
            DataRespond data = new DataRespond();
            try
            {
                Discipline dis = new Discipline();
                dis.fileid = disrq.fileid;
                dis.noidung = disrq.noidung;
                dis.donvi = disrq.donvi;
                DateTime timediscipline = DateTime.ParseExact(disrq.daycreate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dis.daycreate = timediscipline;
                dis.ghichu = disrq.ghichu;
                dis.updateday = DateTime.Now;
                dis.active = true;
                dis.approved = true;

                data.success = true;
                m_adDisciplineResponsitory.insertDiscipline(dis);
                data.message = "insert success";
            }
            catch(Exception e)
            {
                data.success = false;
                data.message = e.Message;
                data.error = e;
            }
            return data;
        }

        [HttpGet("getDisciplineById")]
        public DataRespond getDisciplineById(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data= m_adDisciplineResponsitory.findDisciplineById(id);
                data.message = "success";
            }
            catch(Exception e)
            {
                data.message = e.Message;
                data.error = e;
                data.success = false;
            }
            return data;
        }

        [HttpPost("updateDiscipline")]
        public DataRespond updateDiscipline(DisciplineRequest disrq)
        {
            DataRespond data = new DataRespond();
            try
            {
                Discipline dis = m_adDisciplineResponsitory.findDisciplineById(disrq.dsid);
                dis.fileid = disrq.fileid;
                dis.noidung = disrq.noidung;
                dis.donvi = disrq.donvi;
                DateTime timediscipline = DateTime.ParseExact(disrq.daycreate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dis.daycreate = timediscipline;
                dis.ghichu = disrq.ghichu;
                data.success = true;
                m_adDisciplineResponsitory.updateDisciplines(dis);
                data.message = "update success";
            }
            catch(Exception e)
            {
                data.error = e;
                data.message = e.Message;
                data.success = false;
            }
            return data;
        }
    }
}