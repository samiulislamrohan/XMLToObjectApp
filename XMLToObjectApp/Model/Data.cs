using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToObjectApp.Model
{
    [XmlRoot("itemInfo")]
    public class ItemInfo
    {
        [XmlElement("document")]
        public Document document { get; set; }

        [XmlElement("item")]
        public Item item;

        [XmlArray("projects")]
        [XmlArrayItem("project")]
        public List<Project> projects { get; set; }



    }
    public class Document
    {
        [XmlAttribute("id")]
        public string id { get; set; }

        [XmlAttribute("name")]
        public string name { get; set; }

        [XmlAttribute("revision")]
        public string revision { get; set; }

        [XmlAttribute("type")]
        public string type { get; set; }

        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> properties { get; set; }
    }
    public class Item
    {
        [XmlAttribute("id")]
        public string id { get; set; }

        [XmlAttribute("name")]
        public string name { get; set; }

        [XmlAttribute("revision")]
        public string revision { get; set; }

        [XmlAttribute("type")]
        public string type { get; set; }

        [XmlAttribute("type3DX")]
        public string type3DX { get; set; }

        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> properties { get; set; }
    }
    public class Project
    {
        [XmlAttribute("id")]
        public string id { get; set; }

        [XmlAttribute("name")]
        public string name { get; set; }

        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> properties { get; set; }
    }

    public class Property
    {
        [XmlAttribute("key")]
        public string key { get; set; }

        [XmlAttribute("value")]
        public string value { get; set; }

    }
}
