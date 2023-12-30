﻿using System;
using System.Collections.Generic;

namespace TranQuocTrung1.Entities
{
    public partial class Departure
    {
        public int Id { get; set; }
        public int? ShipId { get; set; }
        public int? BerthId { get; set; }
        public DateTime? DepartureDate { get; set; }
        public TimeSpan? DepartureTime { get; set; }

        public virtual Berth? Berth { get; set; }
        public virtual Ship? Ship { get; set; }
    }
}
