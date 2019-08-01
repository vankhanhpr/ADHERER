using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.model;
using WebApi.model.request;
using WebApi.serrvice.admin.interfaces;
using WebApi.serrvice.admin.model;

namespace WebApi.controllers.admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdFamilyController : Controller
    {
        private IAdFamilyResponsitory m_adFamilyResponsitory;

        public AdFamilyController(IAdFamilyResponsitory adFamilyResponsitory)
        {
            m_adFamilyResponsitory = adFamilyResponsitory;
        }

        [HttpGet("getFamilies")]
        public DataRespond getFamilies(int fileid)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.message = "success";
                data.data = m_adFamilyResponsitory.getAllFamily(fileid);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
                data.message = e.Message;
            }
            return data;
        }

        [HttpPost("insertFamily")]
        public DataRespond insertFamily([FromBody]FamilyRequest fmlrq)
        {
            DataRespond data = new DataRespond();
            try
            {
                Family fml = new Family();
                fml.name = fmlrq.name;
                fml.fileid = fmlrq.fileid;
                fml.quanhe = fmlrq.quanhe;
                fml.lichsuchinhtri = fmlrq.lichsuchinhtri;
                fml.hoancanhkinhte = fmlrq.hoancanhkinhte;
                fml.nghenghiep = fmlrq.nghenghiep;
                DateTime bd = DateTime.ParseExact(fmlrq.birthday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                fml.birthday = bd;
                fml.updateday = DateTime.Now;
                m_adFamilyResponsitory.insertFamily(fml);
                data.success = true;
                data.message = "success";
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