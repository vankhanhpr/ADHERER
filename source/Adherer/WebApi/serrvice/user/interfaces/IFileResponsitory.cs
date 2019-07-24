﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.interfaces.responsitory;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.user.interfaces
{
    public interface IFileResponsitory: IResponsitory<Files>
    {
        Files getFileByUserId(int usid);
        void insertFile(Files files);
        void updateFile(Files files);
        Files findFileById(int id);
    }
}