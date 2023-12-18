using EFKSystemETradeAPI.Application.Abstraction.Services;
using EFKSystemETradeAPI.Application.Repositories;
using EFKSystemETradeAPI.Domain.Entities.Identity;
using EFKSystemETradeAPI.Persistence.Configuration;
using EFKSystemETradeAPI.Persistence.Contexts;
using EFKSystemETradeAPI.Persistence.Repositories;
using EFKSystemETradeAPI.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemETradeAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(Configurations.ConnectionString));

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IAddressReadRepository,AddressReadRepository>();
            services.AddScoped<IAddressWriteRepository, AddressWriteRepository>();

            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            services.AddScoped<ICollectionReadRepository, CollectionReadRepository>();
            services.AddScoped<ICollectionWriteRepository, CollectionWriteRepository>();

            services.AddScoped<IColorReadRepository, ColorReadRepository>();
            services.AddScoped<IColorWriteRepository, ColorWriteRepository>();

            services.AddScoped<ICommentReadRepository, CommentReadRepository>();
            services.AddScoped<ICommentWriteRepository, CommentWriteRepository>();

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

            services.AddScoped<IProductGroupReadRepository, ProductGroupReadRepository>();
            services.AddScoped<IProductGroupWriteRepository, ProductGroupWriteRepository>();

            services.AddScoped<IProductImageReadRepository, ProductImageReadRepository>();
            services.AddScoped<IProductImageWriteRepository, ProductImageWriteRepository>();

            services.AddScoped<ISizeReadRepository, SizeReadRepository>();
            services.AddScoped<ISizeWriteRepository, SizeWriteRepository>();

            services.AddScoped<ISubCategoryReadRepository, SubCategoryReadRepository>();
            services.AddScoped<ISubCategoryWriteRepository, SubCategoryWriteRepository>();

            services.AddScoped<ISeasonReadRepoistory, SeasonReadRepository>();
            services.AddScoped<ISeasonWriteRepository, SeasonWriteRepository>();

            services.AddScoped<IProvinceWriteRepository, ProvinceWriteRepository>();
            
            services.AddScoped<IUserService, UserService>();

        }
    }
}
