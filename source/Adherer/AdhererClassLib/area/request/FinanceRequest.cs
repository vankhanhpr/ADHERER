using System;
using System.Collections.Generic;
using System.Text;

namespace AdhererClassLib.area.request
{
    public class FinanceRequest
    {
        public int financeid { get; set; }
        public string name { get; set; }
        public DateTime createday { get; set; }
        public long moneys { get; set; }
        public int status { get; set; }
    }
}
