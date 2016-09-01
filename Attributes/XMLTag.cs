﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Org.Reddragonit.BpmEngine.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class XMLTag : Attribute
    {
        private string _name;
        public string Name { get { return _name; } }

        private string _prefix;
        public string Prefix { get { return _prefix; } }

        public XMLTag(string name)
            : this(null, name)
        { }

        public XMLTag(string prefix,string name)
        {
            _name = name;
            _prefix = prefix;
        }

        public override string ToString()
        {
            return (_prefix==null ? _name : string.Format("{0}:{1}",_prefix,_name));
        }
    }
}
