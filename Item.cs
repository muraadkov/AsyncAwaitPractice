using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GamesNews
{
    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "link")]
        public string Link2 { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "pubDate")]
        public string PubDate { get; set; }
        [XmlElement(ElementName = "guid")]
        public Guid Guid { get; set; }
        [XmlElement(ElementName = "creator", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Creator { get; set; }
        [XmlElement(ElementName = "content", Namespace = "http://search.yahoo.com/mrss/")]
        public string Content { get; set; }
        [XmlElement(ElementName = "category")]
        public string Category { get; set; }
    }
}
