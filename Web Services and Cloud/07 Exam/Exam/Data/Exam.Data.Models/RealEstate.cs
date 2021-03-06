﻿namespace Exam.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class RealEstate
    {
        private ICollection<Comment> comments;

        public RealEstate()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(RealEstateConstants.TitleMinLength)]
        [MaxLength(RealEstateConstants.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(RealEstateConstants.DescriptionMinLength)]
        [MaxLength(RealEstateConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Contact { get; set; }

        public int ConstructionYear { get; set; }

        public RealEstateType RealEstateType { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
