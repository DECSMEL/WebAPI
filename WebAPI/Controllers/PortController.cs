using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PortController : ApiController
    {
        private IPortDAO _portDAO;

        public PortController(IPortDAO portDAO)
        {
            _portDAO = portDAO;
        }
            
        [HttpGet]
        public IList<PortM> GetPortsList()
        {
            IList<PortM> ports = _portDAO.getAllPorts();
            return ports;
        }

        [HttpGet]
        public IList<AttributeDefinitionM> GetPortsAttributes(int id)
        {
            IList<AttributeDefinitionM> attrDefList = _portDAO.getPortAttributes(id);
            return attrDefList;
        }

        [HttpPost]
        public ResultM AddInput(List<AttributeValueM> inputAttributeValue)
        {
            ResultM result = new ResultM();
//                calculator.Calculate(inputAttributeValue);
            InputLog log = new InputLog()
            {
                Values = inputAttributeValue,
                Result = result
            };
            _portDAO.SaveInputLog(log);
            return result;
        }
    }
       
}