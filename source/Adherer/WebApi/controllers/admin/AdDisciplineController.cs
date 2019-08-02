using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.model;
using WebApi.serrvice.admin.interfaces;

namespace WebApi.controllers.admin
{
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
    }
}