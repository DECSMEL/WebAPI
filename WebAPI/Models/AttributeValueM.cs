using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AttributeValueM
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public AttributeDefinitionM Attribute { get; set; }
    }
}
