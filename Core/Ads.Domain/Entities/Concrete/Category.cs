﻿using Ads.Domain.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ads.Domain.Entities.Concrete
{
    public class Category : BaseEntity
    {
        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [StringLength(100, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(1, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [StringLength(200, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string Description { get; set; }

        [DisplayName("Icon")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [StringLength(50, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
        [MinLength(1, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public string CategoryIcon { get; set; }

        public virtual ICollection<CategoryAdvert> CategoryAdverts { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
   

    }
}