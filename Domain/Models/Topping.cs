using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    /// <summary>
    /// base class for topping
    /// </summary>
    public class Topping
    {
        /// <summary>
        /// Unique ID creating as Guid
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Property that is seen by customer. Is Required
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Price for topping
        /// </summary>
        public double Price { get; set; } = 0.0;
        /// <summary>
        /// if topping is avaiable for customer - default is not
        /// </summary>
        public bool IsAvailable { get; set; } = false;

        /// <summary>
        /// normalize name is name uppercase and no white space 
        /// </summary>
        public string NormalizeName { get; set; }

        /// <summary>
        /// 0 args c-tor for creating new topping with unique ID
        /// </summary>
        public Topping()
        {
            Id = Guid.NewGuid().ToString(); 
        }
        /// <summary>
        /// function that normalize Name and assign it to NormalizeName property
        /// </summary>
        /// <returns>result of the action</returns>
        public bool Normalize()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return false;
            }
            NormalizeName = Name.ToUpper().Replace(' ', '-');
            return true;
        }
    }
}
