using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class InputLog
    {
        public InputLog()
        {
            Values = new List<AttributeValueM>();
            Date = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public IList<AttributeValueM> Values { get; set; }
        public ResultM Result { get; set; }
    }
}
