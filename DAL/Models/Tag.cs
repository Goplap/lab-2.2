﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BulletinBoard.DAL.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        // Навігаційні властивості
        public virtual ICollection<Ad> Ads { get; set; } = new List<Ad>();
    }
}