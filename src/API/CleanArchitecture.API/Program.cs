// using Ardalis.ListStartupServices;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CleanArchitecture.Api.Middleware;
using CleanArchitecture.API;
using CleanArchitecture.API.Middleware;
using CleanArchitecture.Application;
//using CleanArchitecture.Identity;
using CleanArchitecture.Persistence;
using CleanArchitecture.Resources;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

//string letsRideConnectionString = builder.Configuration.GetConnectionString("LetsRideConnectionString");//builder.Configuration.GetConnectionString("SqliteConnection");  Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddLetsRideDbContext(letsRideConnectionString); 

//string identityConnectionString = builder.Configuration.GetConnectionString("IdentityConnectionString");
//builder.Services.AddLetsRideDbContext(identityConnectionString);

// Add services to the container.
builder.Services.AddSwaggerGen(c =>
{
    //c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    //{
    //    Description = @"JWT Authorization header using the Bearer scheme. 
    //                  Enter 'Bearer' [space] and then your token in the text input below.
    //                  Example: 'Bearer 12345abcdef'",
    //    Name = "Authorization",
    //    In = ParameterLocation.Header,
    //    Type = SecuritySchemeType.ApiKey,
    //    Scheme = "Bearer"
    //});

    //c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    //              {
    //                {
    //                  new OpenApiSecurityScheme
    //                  {
    //                    Reference = new OpenApiReference
    //                      {
    //                        Type = ReferenceType.SecurityScheme,
    //                        Id = "Bearer"
    //                      },
    //                      Scheme = "oauth2",
    //                      Name = "Bearer",
    //                      In = ParameterLocation.Header,

    //                    },
    //                    new List<string>()
    //                  }
    //                });

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Api",

    });
    c.EnableAnnotations();
});

//LOCALIZATION
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddLocalization(options => options.ResourcesPath = "");
builder.Services.ConfigureResourceServices();
builder.Services.ConfigureApplicationServices();

//builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
//{
//    containerBuilder.RegisterModule(new DefaultCoreModule());
//    containerBuilder.RegisterModule(new DefaultInfrastructureModule(builder.Environment.EnvironmentName == "Development"));
//});


builder.Services.ConfigureInfrastructureServices(builder.Configuration);
builder.Services.ConfigurePersistenceServices(builder.Configuration);
//builder.Services.ConfigureIdentityServices(builder.Configuration);
//builder.Services.ConfigureJWTServices(builder.Configuration);


builder.Services.AddControllers();

builder.Services.AddCors(o =>
{
    o.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});



// builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CleanArchitecture.Api v1"));
//}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
  //  app.UseShowAllServicesMiddleware();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseMiddleware<ExceptionMiddleware>();

app.UseAuthentication();



app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

//app.UseHttpsRedirection();

//app.UseAuthorization();
// custom jwt auth middleware
// app.UseMiddleware<JwtMiddleware>();
app.MapControllers();


// Seed Database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        //                    context.Database.Migrate();
        context.Database.EnsureCreated();
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}

app.Run();



