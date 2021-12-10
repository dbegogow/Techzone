﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static TechZoneAPI.Data.DataConstants.Common;
using static TechZoneAPI.Data.DataConstants.Feature;

namespace TechZoneAPI.Data.Models
{
    public class Feature
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ValueMaxLength)]
        public string Value { get; set; }

        public ICollection<Product> Products { get; init; } = new HashSet<Product>();
    }
}
