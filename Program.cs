using InventoryManagement.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using InventoryManagement.Extensions;
using InventoryManagement.CustomStores;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IRepository<Admin>, AdminRepository>();
builder.Services.AddTransient<IUserRepository<Customer>, CustomerRepository>();
builder.Services.AddTransient<IRepository<Product>, ProductRepository>();
builder.Services.AddTransient<IRepository<Category>,CategoryRepository>();
builder.Services.AddTransient<IRepository<Inventory>, InventoryRepository>();
builder.Services.AddTransient<IRepository<Order>,OrderRepository>();
builder.Services.AddTransient<IRepository<Purchase>,PurchaseRepository>();
builder.Services.AddTransient<IRepository<Role>,RoleRepository>(); 
builder.Services.AddTransient<IRepository<ProductItem>, ProductItemRepository>();
builder.Services.AddTransient<IUserStore<Customer>, CustomUserStore>();
builder.Services.AddTransient<UserManager<Customer>>();
builder.Services.AddTransient<IPasswordHasher<Customer>, PasswordHasher<Customer>>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1",
        Description = "Inventory Management web core api",
        Contact = new OpenApiContact
        {
            Name = "Dorian Mayamba",
            Email = "dorian.mayamba@gmail.com"
        }
    });
});

//Add Authentication
builder.Services.AddAuthentication()
    .AddBearerToken(IdentityConstants.BearerScheme);
//Add authorization
builder.Services.AddAuthorization();

// configure sql connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

//Add Identity Core
builder.Services
    .AddIdentityCore<User>()
    .AddEntityFrameworkStores<ApplicationDBContext>()
    .AddApiEndpoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.CustomMapIdentityApi<Customer>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllers();

app.Run();
