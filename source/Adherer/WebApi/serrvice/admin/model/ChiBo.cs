﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.serrvice.admin.model
{
    public class ChiBo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string cbid { get; set; }
        public string tencb { get; set; }
        public int dbid { get; set; }
        public int active { get; set; }
    }
}
