﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class ResponseAccount
    {
        [DataMember]
        public Account Account { get; set; }
    }
}
