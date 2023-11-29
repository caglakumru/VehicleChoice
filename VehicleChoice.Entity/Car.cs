using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace VehicleChoice.Entity
{
    public class Car :Vehicle
    {
        [MaxLength(100)]
        public string? Wheel { get; set; }
        public bool Headlight { get; set; }

    }
}

