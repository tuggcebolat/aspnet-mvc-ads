﻿using Ads.Application.DTOs.SubCategoryAdvert;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Application.FluentValidation
{
	public class SubCategoryAdvertDtoValidator : AbstractValidator<SubCategoryAdvertDto>
	{
		public SubCategoryAdvertDtoValidator()
		{
			RuleFor(dto => dto.SubCategoryId)
				.NotEmpty().WithMessage("SubCategory ID is required.")
				.GreaterThan(0).WithMessage("SubCategory ID must be greater than zero.");

			RuleFor(dto => dto.AdvertId)
				.NotEmpty().WithMessage("Advert ID is required.")
				.GreaterThan(0).WithMessage("Advert ID must be greater than zero.");

		}
	}
}
