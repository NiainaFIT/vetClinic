using System;
using System.Collections.Generic;
using System.Text;

namespace vetClinic.Model
{
    public partial class ServiceMeasure
    {
        public int ServiceMeasureId { get; set; }
        public string MeasureName { get; set; }
        public bool IsActive { get; set; }
    }
}
