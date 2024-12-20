﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public ICollection<UserScoreData> ScoreData { get; set; } = new List<UserScoreData>();

        [Required]
        [StringLength(255)]
        public string? UserLogin { get; set; }

        [Required]
        [StringLength(255)]
        public string? UserPassword { get; set; }

        [Required]
        public DateTime AccountDate { get; set; }
    }
}
