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
    public class AdUserController : Controller
    {
        private IAdUserResponsitory m_userResponsitory; 
        public AdUserController(IAdUserResponsitory userResponsitory)
        {
            m_userResponsitory = userResponsitory;
        }
        [HttpGet("getAllUser")]
       public DataRespond getAllUser()
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_userResponsitory.getAllUser(0, 2);
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