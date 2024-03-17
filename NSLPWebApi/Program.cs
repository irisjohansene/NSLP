using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NSLPWebApi;
using NSLPWebApi.Data;
using NSLPWebApi.EFConfigurations;
using NSLPWebApi.Repositories;

using NSLPWebApi.Services.IngredientService;
using NSLPWebApi.Services.MeasurementService;
using NSLPWebApi.Services.MenuTypeService;
using NSLPWebApi.Services.IngredientTypeService;
using NSLPWebApi.Services.ProductCategoryService;
using NSLPWebApi.Services.VendorService;
using NSLPWebApi.Services.MenuService;
using NSLPWebApi.Services.MenuToIngredientService;
using NSLPWebApi.Services.RecipeToIngredientService;
using NSLPWebApi.Services.RecipeService;
using NSLPWebApi.Services.OrderService;
using NSLPWebApi.Services.OrderDetailService;
using NSLPWebApi.Services.DocumentService;
using NSLPWebApi.Services.UtilityService;

var builder = WebApplication.CreateBuilder(args);
var AllowedOrigins = "_allowedOrigins";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));

//CORS
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: AllowedOrigins,
//        builder =>
//        {
//            builder.WithOrigins(
//                   "https://localhost:7037",
//                   "https://localhost:7234/"
//                )
//                .AllowAnyHeader()
//                .AllowAnyMethod()
//                .AllowCredentials();

//            // TODO: Review the allowed options. Relax for development. Strict for prod.
//        });
//});
builder.Services.AddCors(policy =>
{
    policy.AddPolicy("AllowedOrigins", opt => opt
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

//Repository
builder.Services.AddScoped<IngredientRepository>();
builder.Services.AddScoped<MeasurementRepository>();
builder.Services.AddScoped<IngredientTypeRepository>();
builder.Services.AddScoped<MenuRepository>();
builder.Services.AddScoped<MenuTypeRepository>();
builder.Services.AddScoped<MenuToIngredientOrRecipeRepository>();
builder.Services.AddScoped<RecipeToIngredientRepository>();
builder.Services.AddScoped<RecipeRepository>();
builder.Services.AddScoped<OrderDetailRepository>();
builder.Services.AddScoped<OrderRepository>();
builder.Services.AddScoped<VendorRepository>();
builder.Services.AddScoped<SettingRepository>();
builder.Services.AddScoped<DocumentRepository>();
builder.Services.AddScoped<ProductCategoryRepository>();

//Add Mapper Configuration
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperConfig());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//Add SeriLogger Configuration
builder.Services.AddSingleton(typeof(SeriLogger));

// Add services to the container.
builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<IMeasurementService, MeasurementService>();
builder.Services.AddScoped<IMenuTypeService, MenuTypeService>();
builder.Services.AddScoped<IIngredientTypeService, IngredientTypeService>();
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IMenuToIngredientOrRecipeService, MenuToIngredientOrRecipeService>();
builder.Services.AddScoped<IRecipeToIngredientService, RecipeToIngredientService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();
builder.Services.AddScoped<IVendorService, VendorService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
builder.Services.AddScoped<IDocumentService, DocumentService>();
builder.Services.AddScoped<IUtilityService, UtilityService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(AllowedOrigins);
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
