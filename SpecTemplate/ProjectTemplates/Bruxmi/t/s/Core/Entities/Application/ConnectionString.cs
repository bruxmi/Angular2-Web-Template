﻿using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Application
{
    [Table("ConnectionString")]
    public class ConnectionString : IEntity
    {
        [Required]
        public string Value { get; set; }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public string ProviderName { get; set; }
    }
}
