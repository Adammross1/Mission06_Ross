﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Ross.Models
{
    public class MovieSubmission
    {
        [Required]
        public string Category { get; set; }
        [Key]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [Range(0,25)]
        public string Notes { get; set; }
    }
}
