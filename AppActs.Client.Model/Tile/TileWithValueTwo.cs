﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppActs.Client.Model;
using MongoDB.Bson;

namespace AppActs.Client.Model
{
    public class TileWithValueTwo : TileWithValueOne
    {
        public object ValueTwo { get; set; }
    }
}
