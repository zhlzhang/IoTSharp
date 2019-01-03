﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IoTSharp.Hub.Data
{

    public class TelemetryLatest : AttributeData
    {
        [Required]
        public Device Device { get; set; }
 
    }
}