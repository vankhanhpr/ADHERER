using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.serrvice.admin.model
{
    public class Files
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fileid { get; set; }
        public int usid { get; set; }
        public int donvi { get; set; }
        public DateTime ngaythangnamsinh { get; set; }
        public string hotendangdung { get; set; }
        public string hotenkhaisinh { get; set; }
        public int gioitinh { get; set; }
        public int dantoc { get; set; }
        public int tongiao { get; set; }
        public string nghenghiep { get; set; }
        public DateTime ngayvaodangdb { get; set; }
        public DateTime ngayvaodangct { get; set; }
        public DateTime ngayvaodoan { get; set; }
        public string trinhdovanhoa { get; set; }
        public string chuyenmon { get; set; }
        public string quequan { get; set; }
        public string noicutru { get; set; }
        public string matp { get; set; }
        public string maqh { get; set; }
        public string xaid { get; set; }
        public string solilich { get; set; }
        public DateTime createday { get; set; }
        public DateTime updateday { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }

    }
}
