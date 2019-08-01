using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.model;

namespace WebApi.serrvice.admin.interfaces
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdBonusController : Controller
    {
        private IAdBonusResponsitory m_adBonusResponsitory;
        public AdBonusController(IAdBonusResponsitory adBonusResponsitory)
        {
            m_adBonusResponsitory = adBonusResponsitory;
        }

        [HttpGet("getBonus")]
        public DataRespond getBonus(int fileid)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_adBonusResponsitory.getAllBonus(fileid);
                data.message = "success!";
            }
            catch(Exception e)
            {
                data.success = true;
                data.error = e;
                data.message = e.Message;
            }
            return data;
        }

       // public DataRespond insertBonus(Bonus)
    }
}