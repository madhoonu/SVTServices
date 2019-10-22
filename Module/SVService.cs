using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SVTService.Module
{
    public class SVService 
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public DateTime ServiceDate { get; set; }
        public decimal ServicePrice { get; set; }
        public string Description { get; set; }        

    }
}
