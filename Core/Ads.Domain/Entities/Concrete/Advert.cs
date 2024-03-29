﻿using Ads.Domain.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ads.Domain.Entities.Concrete
{
    public class Advert : BaseEntity
    {

        [DisplayName("Title")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [StringLength(200, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(1, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string? Title { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [StringLength(500, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(1, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string? Description { get; set; }

        [DisplayName("Is Business?")]
        public bool Type { get; set; }

        [DisplayName("Is Business?")]
        public string TypeString => Type ? "Personal" : "Business";

        [DisplayName("Is it on sale?")]
        public bool OnSale { get; set; }

        [DisplayName("Is it on sale?")]
        public string OnSaleString => OnSale ? "On Sale" : "Archived";

        public int? Price { get; set; }

        public int? ClickCount { get; set; }

        public virtual AppUser? User { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }

        public virtual ICollection<CategoryAdvert>? CategoryAdverts { get; set; }

        public virtual ICollection<SubCategoryAdvert>? SubCategoryAdverts { get; set; }

        public virtual ICollection<AdvertComment>? AdvertComments { get; set; }

        public virtual ICollection<AdvertImage>? AdvertImages { get; set; }

        public virtual ICollection<AdvertRating>? AdvertRatings { get; set; }
    }
}