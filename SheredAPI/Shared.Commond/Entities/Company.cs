using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Common.Entities
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Address { get; set; } = null!;

        [MaxLength(50)]
        public string City { get; set; } = null!;

        [Required]
        public string Phone { get; set; } = null!;

        public string Fax { get; set; } = null!;
    }
}