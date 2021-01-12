using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BGlobal.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }
        public string Patent { get; set; }
        public string Owner { get; set; }
        public string Doors { get; set; }
        public string Model { get; set; }

        [ForeignKey("BrandId")]
        public Brand Brands { get; set; }
        public Guid BrandId { get; set; }
    }
}
