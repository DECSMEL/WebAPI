using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI
{
    public interface IPortDAO
    {
        IList<PortM> getAllPorts();
        IList<AttributeDefinitionM> getPortAttributes(int id);
        bool SaveInputLog(InputLog log);
    }
}
