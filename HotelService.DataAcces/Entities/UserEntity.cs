using HotelService.Core.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAcces.Entities
{
    public class UserEntity
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [Required]
        [MinLength(10)]
        [MaxLength(255)]
        public string password { get; set; } = string.Empty;
        public Roles Role { get; set; }
    }
}
