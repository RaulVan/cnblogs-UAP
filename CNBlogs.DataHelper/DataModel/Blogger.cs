﻿using CNBlogs.DataHelper.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CNBlogs.DataHelper.DataModel
{
    /// <summary>
    /// this model is used to get blogger list
    /// </summary>
    [XmlRoot("entry")]
    public class Blogger:DataModelBase
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("title")]
        public string Name { get; set; }

        [XmlElement("updated")]
        public string UpdateTimeString { get; set; }

        [XmlElement("link", typeof(Link))]
        public Link Link { get; set; }

        [XmlElement("blogapp")]
        public string BlogApp { get; set; }


        private string _avatar = string.Empty;

        [XmlElement("avatar")]
        public string Avatar {
            get { return _avatar; }
            set {
                _avatar = value;
                this.OnPropertyChanged();
            }
        }

        [XmlElement("postcount")]
        public string PostCount { get; set; }

        [XmlIgnore]
        public DateTime UpdateTime
        {
            get { return Functions.ParseDateTime(this.UpdateTimeString); }
        }


    }

}
