﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.model.request
{
    public class UserRequest
    {
        public string madv { get; set; }
        public string password { get; set; }

        public int cbid { get; set; }
        public string ngaydenchibo { get; set; }
        public string createday { get; set; }
        public int roleid { get; set; }
        public int titleid { get; set; }
        public int active { get; set; }
    }
}
