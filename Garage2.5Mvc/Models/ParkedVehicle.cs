﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._5Mvc.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public string RegNum { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels{ get; set; }
    }
}