﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubble.Models
{
    public class HubbleVideo
    {
        [JsonProperty("file_url")]
        public string Url { get; set; }
    }
}
