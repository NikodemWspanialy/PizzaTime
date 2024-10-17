using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Topping
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;

        public Topping()
        {
            Id = Guid.NewGuid().ToString(); 
        }
    }
}
