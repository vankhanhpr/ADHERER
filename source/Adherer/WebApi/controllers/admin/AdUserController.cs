﻿using System;
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
    public class AdUserController : Controller
    {
        private IAdUserResponsitory m_userResponsitory; 
        public AdUserController(IAdUserResponsitory userResponsitory)
        {
            m_userResponsitory = userResponsitory;
        }
        [HttpGet("getAllUser")]
       public DataRespond getAllUser(int page,int pagesize)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_userResponsitory.getAllUser(page, pagesize);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
                data.message = e.Message;
            }
            return data;
        }

        [HttpPost("insertUser")]
        public DataRespond insertUser([FromBody]UserRequest usrq)
        {
            DataRespond data = new DataRespond();
            try
            {
                var uscheck = m_userResponsitory.getUserByMaDv(usrq.madv);
                if (uscheck != null)
                {
                    data.success = false;
                    data.message = "Mã Đảng viên đã được đăng kí tài khoản trước đó!";
                    return data;
                }

                Users user = new Users();

                user.madv = usrq.madv;
                user.cbid = usrq.cbid;
                user.titleid = usrq.titleid;
                user.roleid = usrq.roleid;
                user.active = usrq.active == 0 ? true : false;
                user.createday = DateTime.Now;
                DateTime udday = DateTime.ParseExact(usrq.ngaydenchibo, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                user.ngaydenchibo = udday;
                user.password = usrq.password;
                m_userResponsitory.insertUser(user);

                data.success = true;
                data.message = "insert success";
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
                data.message = e.Message;
            }
            return data;
        }

        [HttpGet("getDetalUser")]
        public DataRespond getDetailUser(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_userResponsitory.getUserById(id);
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

        [HttpPost("updateUser")]
        public DataRespond updateUser([FromBody]UserRequest usrq)
        {
            DataRespond data = new DataRespond();
            try
            {
                Users user = m_userResponsitory.getUserById(usrq.usid);

                user.usid = usrq.usid;
                user.madv = usrq.madv;
                user.cbid = usrq.cbid;
                user.titleid = usrq.titleid;
                user.roleid = usrq.roleid;
                user.active = usrq.active == 0 ? true : false;
                DateTime udday = DateTime.ParseExact(usrq.ngaydenchibo, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                user.ngaydenchibo = udday;
                if (usrq.password != "")
                {
                    user.password = usrq.password;
                }

                data.success = true;
                m_userResponsitory.updateUser(user);
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

        [HttpGet("blockUser")]
        public DataRespond blockUser(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                m_userResponsitory.blockUser(id);
                data.success = true;
                data.message = "block success";
            }
            catch(Exception e)
            {
                data.error = e;
                data.message = e.Message;
                data.success = false;
            }
            return data;
        }

        [HttpGet("getUserByRole")]
        public DataRespond getUserByRole(int role)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_userResponsitory.getUserByRole(role);
                data.message = "success";
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
                data.message = e.Message;
            }
            return data;
        }

        [HttpGet("getUserByActive")]
        public DataRespond getUserByActive(int active)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_userResponsitory.getUserByActive(active);
                data.message = "success";
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
                data.message = e.Message;
            }
            return data;
        }

        [HttpPost("filterUserByBox")]
        public DataRespond filterByBox([FromBody]Filter filter)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_userResponsitory.getUserByBox(filter.filter);
                data.message = "success";
            }
            catch(Exception e)
            {
                data.error = e;
                data.success = false;
                data.message = e.Message;
            }
            return data;
        }
    }
}