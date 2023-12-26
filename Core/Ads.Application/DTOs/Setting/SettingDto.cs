﻿using Ads.Application.DTOs.Page;
using Ads.Application.DTOs.User;

namespace Ads.Application.DTOs.Setting
{
    public class SettingDto
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public int? UserId { get; set; }
        public UserDto User { get; set; }
        public int? PageId { get; set; }
        public PageDto Page { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}

