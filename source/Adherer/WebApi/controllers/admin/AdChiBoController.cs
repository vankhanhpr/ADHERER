using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.model;
using WebApi.serrvice.admin.interfaces;
using WebApi.serrvice.admin.model;

namespace WebApi.controllers.admin
{
    public class AdChiBoController : Controller
    {
        private IChiBoResponsitory m_chiBoResponsitory;
        public AdChiBoController(IChiBoResponsitory chiBoResponsitory)
        {
            m_chiBoResponsitory = chiBoResponsitory;
        }
        [HttpGet("getAllChiBo")]
       public DataRespond getAllChiBo()
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_chiBoResponsitory.getAllChiBo();
            }
            catch(Exception e)
            {
                data.error = e;
                data.success = false;
                data.message = e.Message;
            }
            return data;
        }

        [HttpPost("insertChiBo")]
        public DataRespond insertChiBo(ChiBo cb)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                m_chiBoResponsitory.insertChoBo(cb);
                data.message = "Insert success!";
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
                data.message = e.Message;
            }
            return data;
        }

        [HttpPost("updateChiBo")]
        public DataRespond updateChiBo(ChiBo cb)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                m_chiBoResponsitory.updateChiBo(cb);
                
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
                data.message = e.Message;
            }
            return data;
        }
    }
}