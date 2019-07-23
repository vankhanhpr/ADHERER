using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.model;
using WebApi.serrvice.admin.interfaces;
using WebApi.serrvice.admin.model;

namespace WebApi.controllers.admin
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdDangBoController : Controller
    {
        private IDangBoResponsitory m_dangBoResponsitory;
        public AdDangBoController(IDangBoResponsitory dangBoResponsitory)
        {
            m_dangBoResponsitory = dangBoResponsitory;
        }
        [HttpGet("getAllDangBo")]
        public DataRespond getAllDangBo()
        {
            DataRespond data = new DataRespond();
            try
            {
                data.data = m_dangBoResponsitory.getAllDangBo();
            }catch(Exception e)
            {
                data.error = e;
                data.success = false;
                data.message = e.Message;
            }
            return data;
        }

        [HttpPost("insertDangBo")]
        public DataRespond insertDangBo(DangBo db)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                m_dangBoResponsitory.insertDangBo(db);
            }
            catch(Exception e)
            {
                data.success = false;
                data.data = e;
                data.message = e.Message;
            }
            return data;
        }
        [HttpPost("updateDangBo")]
        public DataRespond updateDangBo(DangBo db)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                m_dangBoResponsitory.updateDangBo(db);
            }
            catch (Exception e)
            {
                data.success = false;
                data.data = e;
                data.message = e.Message;
            }
            return data;
        }
    }
}