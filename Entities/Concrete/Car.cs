﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        //public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        //public string Descriptions { get; set; }
        public string Model { get; set; }
        //public string Gear { get; set; }
        //public string Gas { get; set; }
        //public int Capacity { get; set; }
    }
}
