using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BGlobal.Models
{
    [Table("Brands")]
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
