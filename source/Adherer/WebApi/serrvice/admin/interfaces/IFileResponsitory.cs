﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.interfaces.responsitory;
using WebApi.serrvice.admin.model;

namespace WebApi.serrvice.admin.interfaces
{
    public interface IFileResponsitory:IResponsitory<Files>
    {
        Files getFileByUsid(int id);
        void insertFile(Files file);
        void updateFile(Files file);

    }
}
