using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdhererClassLib.area.main;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.model;
using WebApi.model.roles;
using WebApi.serrvice.admin.interfaces;

namespace WebApi.controllers.admin
{
    //[Authorize(Roles = Roles.Admin)]
    [Route("api/[controller]")]
    [ApiController]
    public class AdFinanceController : Controller
    {
        private IFinanceResponsitory m_financeResponsitory;
        public AdFinanceController(IFinanceResponsitory financeResponsitory)
        {
            m_financeResponsitory = financeResponsitory;
        }
        [HttpGet("getFinanceByStatus")]
        public DataRespond getFinanceByStatus(int status)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.message = "succss";
                data.data = m_financeResponsitory.getFinanceByStatus(status);
            }
            catch(Exception e)
            {
                data.message = e.Message;
                data.success = false;
                data.error = e;
            }
            return data;
        }

        [HttpPost("insertFinance")]
        public DataRespond insertFinance(Finance finance)
        {
            DataRespond data = new DataRespond();
            try
            {
                finance.createday = DateTime.Now;
                data.success = true;
                data.message = "insert succeses";
                m_financeResponsitory.insertFinance(finance);
            }
            catch(Exception e)
            {
                data.message = e.Message;
                data.error = e;
                data.success = false;
            }

            return data;
        }

        [HttpPost("updateFinance")]
        public DataRespond updateFinance(Finance finance)
        {
            DataRespond data = new DataRespond();
            try
            {
                Finance fi = m_financeResponsitory.getFinanceById(finance.financeid);
                fi.status = finance.status;
                fi.name = finance.name;
                fi.moneys = finance.moneys;

                m_financeResponsitory.updateFinance(fi);
                data.success = true;
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
        [HttpGet("deleteFinance")]
        public DataRespond deleteFinance(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                m_financeResponsitory.deleteFinance(id);
                data.message = "delete success";
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