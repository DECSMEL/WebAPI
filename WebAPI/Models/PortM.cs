using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class PortM
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal GeoLat { get; set; }
        public decimal GeoLng { get; set; }

    }
}
