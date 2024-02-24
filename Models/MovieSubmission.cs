﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Ross.Models
{
    public class MovieSubmission
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        //public int CategoryName { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year is required")]
        [Range(1888,2024, ErrorMessage = "Year is invalid")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Director name is required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
