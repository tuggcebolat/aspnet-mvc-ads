﻿using Ads.Domain.Entities.Concrete;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Ads.Persistence.Contexts
{
    public static class DbSeeder
    {
    //    public static void SeedData(AppDbContext context)
    //    {

    //        context.Database.Migrate();

    //        if (!context.Roles.Any())
    //        {
    //            SeedRoles(context);
    //        }

    //        if (!context.Settings.Any())
    //        {
    //            SeedSettings(context);
    //        }

    //        if (!context.Users.Any())
    //        {
    //            SeedUsers(context);
    //        }

    //        if (!context.Categories.Any())
    //        {
    //            SeedCategories(context);
    //        }

    //        if (!context.Adverts.Any())
    //        {
    //            SeedAdverts(context);
    //        }

    //        if (!context.AdvertComments.Any())
    //        {
    //            SeedAdvertComments(context);
    //        }

    //        if (!context.AdvertImages.Any())
    //        {
    //            SeedAdvertImages(context);
    //        }

    //        if (!context.CategoryAdverts.Any())
    //        {
    //            SeedCategoryAdverts(context);
    //        }

    //        if (!context.Pages.Any())
    //        {
    //            SeedPages(context);
    //        }

    //        if (!context.SubCategories.Any())
    //        {
    //            SeedSubCategories(context);

    //        }

    //        if (!context.SubCategoryAdverts.Any())
    //        {
    //            SeedSubCategoryAdverts(context);
    //        }

    //        if (!context.AdvertRatings.Any())
    //        {
    //            SeedAdvertRatings(context);
    //        }
    //    }

    //    private static void SeedRoles(AppDbContext context)
    //    {

    //        var roleNames = new List<string>
    //        {
    //            "Admin",
    //            "Moderator",
    //            "User"
    //        };

    //        var roles = roleNames.Select(roleName => new Role
    //        {
    //            Name = roleName
    //        }).ToList();

    //        context.Roles.AddRange(roles);
    //        context.SaveChanges();
    //    }

    //    private static void SeedSettings(AppDbContext context)
    //    {
    //        var settingFaker = new Faker<Setting>()
    //            .RuleFor(s => s.Theme, f => f.Lorem.Word()) // Rastgele bir tema adı
    //            .RuleFor(s => s.Value, f => f.Lorem.Sentence()); // Rastgele bir değer cümlesi

    //        var settings = settingFaker.Generate(2); // 2 adet sahte ayar oluştur

    //        context.Settings.AddRange(settings);
    //        context.SaveChanges();
    //    }

    //    private static void SeedUsers(AppDbContext context)
    //    {

    //        var roleIds = context.Roles.Select(r => r.Id).ToList();
    //        var settingIds = context.Settings.Select(s => s.Id).ToList();

    //        var userFaker = new Faker<User>()
    //.RuleFor(u => u.Id, f => Guid.NewGuid()) // Guid tipinde rastgele bir Id atama
    //.RuleFor(u => u.Email, (f, u) => f.Internet.Email())
    //.RuleFor(u => u.Password, (f, u) => f.Internet.Password())
    //.RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
    //.RuleFor(u => u.LastName, (f, u) => f.Name.LastName())
    //.RuleFor(u => u.Username, (f, u) => f.Internet.UserName())
    //.RuleFor(u => u.Address, (f, u) => f.Address.FullAddress())
    //.RuleFor(u => u.Phone, (f, u) => f.Phone.PhoneNumber())
    //.RuleFor(u => u.IsActive, f => f.Random.Bool())
    //.RuleFor(u => u.CreatedDate, f => f.Date.Past(1))
    //.RuleFor(u => u.ImagePath, f => f.Image.People())
    //.RuleFor(u => u.RoleId, f => f.PickRandom(roleIds))
    //.RuleFor(u => u.SettingId, f => f.PickRandom(settingIds));

    //        var users = userFaker.Generate(10);
    //        context.Users.AddRange(users);
    //        context.SaveChanges();
    //    }


    //    private static void SeedCategories(AppDbContext context)
    //    {
    //        var mainCategories = new List<Category>
    //        {
    //            new Category { Name = "Electronics", Description = "Electronic devices and gadgets", IconPath = "fa fa-laptop icon-bg-1" },
    //            new Category { Name = "Food", Description = "Food and beverages", IconPath = "fa fa-apple icon-bg-2" },
    //            new Category { Name = "Fashion", Description = "Clothing, footwear, and accessories", IconPath = "fa fa-tshirt icon-bg-4" },
    //            new Category { Name = "Home & Garden", Description = "Home improvement, decor, and gardening products", IconPath = "fa fa-home icon-bg-3" },
    //            new Category { Name = "Sports & Outdoors", Description = "Sports equipment and outdoor gear", IconPath = "fa fa-ball icon-bg-5" },
    //            new Category { Name = "Beauty & Health", Description = "Beauty products and health care", IconPath = "fa fa-health icon-bg-8" },
    //            new Category { Name = "Toys & Hobbies", Description = "Toys, games, and hobby essentials", IconPath = "fa fa-toy icon-bg-7" },
    //            new Category { Name = "Automotive", Description = "Automotive parts and accessories", IconPath = "fa fa-car icon-bg-6" }
    //        };

    //        context.Categories.AddRange(mainCategories);
    //        context.SaveChanges();
    //    }


    //    private static void SeedSubCategories(AppDbContext context)
    //    {
    //        var categoryIds = context.Categories.ToDictionary(c => c.Name, c => c.Id);

    //        var subCategoryNames = new Dictionary<string, string[]>
    //        {
    //            {"Electronics", new[] {"Phones", "Computers", "TVs", "Tablets", "Audio Devices", "Gaming Consoles"}},
    //            {"Food", new[] {"Fruits", "Vegetables", "Drinks", "Snacks", "Dairy Products", "Meat and Poultry"}},
    //            {"Fashion", new[] {"Clothing", "Shoes", "Accessories", "Jewelry", "Watches", "Bags"}},
    //            {"Home & Garden", new[] {"Furniture", "Decor", "Gardening Tools", "Kitchenware", "Bedding", "Lighting"}},
    //            {"Sports & Outdoors", new[] {"Fitness Equipment", "Outdoor Gear", "Sportswear", "Footwear", "Camping Equipment", "Bicycles"}},
    //            {"Beauty & Health", new[] {"Skincare", "Haircare", "Makeup", "Fragrances", "Wellness", "Personal Care"}},
    //            {"Toys & Hobbies", new[] {"Board Games", "Puzzles", "Model Kits", "Crafts", "Collectibles", "Outdoor Toys"}},
    //            {"Automotive", new[] {"Car Accessories", "Motorcycle Accessories", "Tools & Equipment", "Car Electronics", "Tires & Wheels", "Parts"}}
    //        };

    //        var subCategories = new List<SubCategory>();

    //        foreach (var category in subCategoryNames)
    //        {
    //            int categoryId = categoryIds[category.Key];
    //            foreach (var subCategoryName in category.Value)
    //            {
    //                subCategories.Add(new SubCategory { Name = subCategoryName, CategoryId = categoryId });
    //            }
    //        }

    //        context.SubCategories.AddRange(subCategories);
    //        context.SaveChanges();
    //    }


    //    private static void SeedAdverts(AppDbContext context)
    //    {
    //        var advertFaker = new Faker<Advert>()
    //            .RuleFor(a => a.Title, f => f.Commerce.ProductName())
    //            .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
    //            .RuleFor(a => a.Type, f => f.Random.Bool())
    //            .RuleFor(a => a.OnSale, f => f.Random.Bool())
    //            .RuleFor(a => a.Price, f => f.Random.Int(0, 1000000))
    //            .RuleFor(a => a.ClickCount, f => f.Random.Int(0, 200))
    //            .RuleFor(a => a.CreatedDate, f => f.Date.Past(1))
    //            .RuleFor(a => a.UserId, f => f.Random.Int(1, 10)); // Varsayım: 1 ile 10 arasında geçerli UserId'ler var

    //        var adverts = advertFaker.Generate(150);

    //        context.Adverts.AddRange(adverts);
    //        context.SaveChanges();
    //    }

    //    private static void SeedAdvertComments(AppDbContext context)
    //    {
    //        var advertCommentFaker = new Faker<AdvertComment>()
    //            .RuleFor(ac => ac.Comment, f => f.Lorem.Sentence())
    //            .RuleFor(ac => ac.IsActive, f => f.Random.Bool())
    //            .RuleFor(ac => ac.AdvertId, f => f.Random.Int(1, 150)) // Varsayım: 1 ile 150 arasında geçerli AdvertId'ler var
    //            .RuleFor(ac => ac.UserId, f => f.Random.Int(1, 10)) // Varsayım: 1 ile 10 arasında geçerli UserId'ler var
    //            .RuleFor(ac => ac.CreatedDate, f => f.Date.Past(1));

    //        var advertComments = advertCommentFaker.Generate(200);

    //        context.AdvertComments.AddRange(advertComments);
    //        context.SaveChanges();
    //    }


    //    private static void SeedAdvertImages(AppDbContext context) //Burada belki API ile alakalı resim seçebiliriz !!
    //    {
    //        var advertImageFaker = new Faker<AdvertImage>()
    //            .RuleFor(ai => ai.AdvertId, f => f.Random.Int(1, 150)) // Varsayım: 1 ile 150 arasında geçerli AdvertId'ler var
    //            .RuleFor(ai => ai.ImagePath, f => f.Image.PicsumUrl()); // Rastgele bir resim URL'si

    //        var advertImages = advertImageFaker.Generate(250);

    //        context.AdvertImages.AddRange(advertImages);
    //        context.SaveChanges();
    //    }

    //    private static void SeedCategoryAdverts(AppDbContext context)
    //    {
    //        var categoryAdvertFaker = new Faker<CategoryAdvert>()
    //            .RuleFor(ca => ca.CategoryId, f => f.Random.Int(1, 8)) // 1 ile 8 arasında geçerli CategoryId'ler
    //            .RuleFor(ca => ca.AdvertId, f => f.Random.Int(1, 150)); // 1 ile 150 arasında geçerli AdvertId'ler


    //        var categoryAdverts = categoryAdvertFaker.Generate(300);

    //        context.CategoryAdverts.AddRange(categoryAdverts);
    //        context.SaveChanges();
    //    }

    //    private static void SeedSubCategoryAdverts(AppDbContext context)
    //    {
    //        var subCategoryAdvertFaker = new Faker<SubCategoryAdvert>()
    //            .RuleFor(sca => sca.SubCategoryId, f => f.Random.Int(1, 48)) // 1 ile 48 arasında geçerli SubCategoryId'ler
    //            .RuleFor(sca => sca.AdvertId, f => f.Random.Int(1, 150)); // 1 ile 150 arasında geçerli AdvertId'ler

    //        var subCategoryAdverts = subCategoryAdvertFaker.Generate(300);

    //        context.SubCategoryAdverts.AddRange(subCategoryAdverts);
    //        context.SaveChanges();
    //    }

    //    private static void SeedPages(AppDbContext context)
    //    {
    //        var pages = new List<Page>
    //{
    //    new Page
    //    {
    //        Title = "Blog Page",
    //        Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed eiusmod tempor incididunt labore et dolore magna aliqua...",
    //        ImagePath = "https://example.com/images/blog.jpg",
    //        IsActive = true,
    //    },
    //    new Page
    //    {
    //        Title = "About Us",
    //        Content = "Introduction\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit...",
    //        ImagePath = "https://example.com/images/about.jpg",
    //        IsActive = true,
    //    },
    //    new Page
    //    {
    //        Title = "Contact Us",
    //        Content = "Hello, what's on your mind?\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit...",
    //        ImagePath = "https://example.com/images/contact.jpg",
    //        IsActive = true,
    //    },
    //    new Page
    //    {
    //        Title = "Terms & Conditions",
    //        Content = "Classimax Terms & Condition\r\nPlease read the following carefully to understand how we will collect...",
    //        ImagePath = "https://example.com/images/terms.jpg",
    //        IsActive = true,
    //    },
    //};

    //        context.Pages.AddRange(pages);
    //        context.SaveChanges();
    //    }

    //    private static void SeedAdvertRatings(AppDbContext context)
    //    {
    //        List<Dictionary<string, object>> advertRatings = new List<Dictionary<string, object>>();
    //        Random random = new Random();

    //        for (int userId = Guid.NewGuid(); userId <= 10; userId++)
    //        {
    //            for (int advertId = Guid.NewGuid(); advertId <= 150; advertId++)
    //            {
    //                Dictionary<string, object> advertRating = new Dictionary<string, object>
    //                {
    //                    ["UserId"] = userId,
    //                    ["AdvertId"] = advertId,
    //                    ["Rating"] = random.Next(1, 6),
    //                    ["CreatedDate"] = DateTime.Now.AddDays(-random.Next(1, 365))
    //                };

    //                advertRatings.Add(advertRating);
    //            }
    //        }

    //        foreach (var rating in advertRatings)
    //        {
    //            var advertRating = new AdvertRating
    //            {
    //                UserId = (int)rating["UserId"],
    //                AdvertId = (int)rating["AdvertId"],
    //                Rating = (int)rating["Rating"],
    //                CreatedDate = (DateTime)rating["CreatedDate"]
    //            };

    //            context.AdvertRatings.Add(advertRating);
    //        }

    //        context.SaveChanges();
    //    }


    }
}