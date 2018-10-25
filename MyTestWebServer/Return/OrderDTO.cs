using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MyTestWebServer.Return
{
    public class OrderDTO
    {
        [XmlElement()]
        public int Id { get; set; }

        [XmlElement()]
        public string Name { get; set; }
    }
}