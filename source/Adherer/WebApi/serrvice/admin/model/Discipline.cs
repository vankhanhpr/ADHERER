﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.serrvice.admin.model
{
    public class Discipline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int dsid { get; set; }
        public int fileid { get; set; }
        public string noidung { get; set; }
        public string ghichu { get; set; }
        public DateTime updateday { get; set; }
    }
}