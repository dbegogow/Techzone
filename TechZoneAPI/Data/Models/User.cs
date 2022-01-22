﻿using System;
using System.ComponentModel.DataAnnotations;

using static TechZoneAPI.Data.DataConstants.User;
using static TechZoneAPI.Data.DataConstants.Common;

namespace TechZoneAPI.Data.Models
{
    public class User
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [MaxLength(NameMaxLength)]
        public string FirstName { get; set; }

        [MaxLength(NameMaxLength)]
        public string LastName { get; set; }

        public string AddressId { get; set; }

        public Address Address { get; set; }
    }
}
