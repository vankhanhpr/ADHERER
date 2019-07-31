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
    public class AdFileController : Controller
    {
        private IAdFileResponsitory m_adFileResponsitory;
        public AdFileController(IAdFileResponsitory adFileResponsitory)
        {
            m_adFileResponsitory = adFileResponsitory;
        }

        [HttpGet("getFileByUsId")]
        public DataRespond getFileByUsId(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_adFileResponsitory.getFileByUsid(id);
                data.message = "success";
            }
            catch(Exception e)
            {
                data.success = false;
                data.message = e.Message;
                data.error = e;
            }
            return data;
        }

    }
}