using System;
using Rangkakata.Model.Core;

namespace Rangkakata.Model
{
    public class Location : BaseModel
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Address { get; set; }
    }
}
