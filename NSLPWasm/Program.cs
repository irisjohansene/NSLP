using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Http;
using NSLPWasm;
using NSLPWasm.Constant;
using NSLPWasm.Helpers;
using NSLPWasm.Services.APIService;
using NSLPWasm.Services.IngredientService.IngredientService;
using NSLPWasm.Services.IngredientTypeService;
using NSLPWasm.Services.MeasurementService;
using NSLPWasm.Services.MenuService;
using NSLPWasm.Services.MenuToIngredientService;
using NSLPWasm.Services.MenuTypeService;
using NSLPWasm.Services.OrderDetailService;
using NSLPWasm.Services.OrderService;
using NSLPWasm.Services.ProductCategoryService;
using NSLPWasm.Services.RecipeService;
using NSLPWasm.Services.RecipeToIngredientService;
using NSLPWasm.Services.SettingService;
using NSLPWasm.Services.UtilityService;
using NSLPWasm.Services.VendorService;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(Constants.API_SERVER) });
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddRadzenComponents();

builder.Services.AddTransient<AuthorizationMessageHandler>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorizationCore();

//Services
builder.Services.AddScoped<IAPIService, APIService>();
builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<IIngredientTypeService, IngredientTypeService>();
builder.Services.AddScoped<IMeasurementService, MeasurementService>();
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IMenuToIngredientOrRecipeService, MenuToIngredientOrRecipeService>();
builder.Services.AddScoped<IMenuTypeService, MenuTypeService>();
builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IRecipeToIngredientService, RecipeToIngredientService>();
builder.Services.AddScoped<ISettingService, SettingService>();
builder.Services.AddScoped<IVendorService, VendorService>();
builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();
builder.Services.AddScoped<IUtilityService, UtilityService>();
builder.Services.AddScoped<ILocalStorageManager, LocalStorageManager>();

await builder.Build().RunAsync();
