using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GamesNews
{
    [XmlRoot(ElementName = "channel")]
    public class Channel
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "link")]
        public List<string> Link { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "language")]
        public string Language { get; set; }
        [XmlElement(ElementName = "lastBuildDate")]
        public string LastBuildDate { get; set; }
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }
}
