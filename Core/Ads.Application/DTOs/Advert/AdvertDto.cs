﻿using Ads.Application.DTOs.AdvertComment;
using Ads.Application.DTOs.AdvertImage;
using Ads.Application.DTOs.AdvertRating;
using Ads.Application.DTOs.CategoryAdvert;
using Ads.Application.DTOs.SubCategoryAdvert;
using Ads.Application.DTOs.User;

namespace Ads.Application.DTOs.Advert
{
    public class AdvertDto
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public bool Type { get; set; }
		public bool OnSale { get; set; }
		public int? Price { get; set; }
		public int? ClickCount { get; set; }
		public ICollection<CategoryAdvertDto>? CategoryAdverts { get; set; }
		public ICollection<SubCategoryAdvertDto>? SubCategoryAdverts { get; set; }
		public ICollection<AdvertImageDto>? AdvertImages { get; set; }
		public ICollection<AdvertCommentDto>? AdvertComments { get; set; }
		public ICollection<AdvertRatingDto>? AdvertRatings { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public UserDto? User { get; set; }
		public int? UserId { get; set; }
        public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
	}
}