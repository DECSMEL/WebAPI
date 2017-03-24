using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ResultM
    {
        public int Id { get; set; }
        public decimal HarborDues { get; set; }
        public decimal QuayDuties { get; set; }
        public decimal Utilities { get; set; }
    }
}
