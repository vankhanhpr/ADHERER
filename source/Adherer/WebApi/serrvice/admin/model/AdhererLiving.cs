using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.serrvice.admin.model
{
    public class AdhererLiving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int livid { get; set; }
        public string title { get; set; }
        public DateTime dayevent { get; set; }
        public string note { get; set; }
        public string namefiel { get; set; }
        public DateTime createday { get; set; }
    }
}
