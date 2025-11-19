using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi;


var builder = WebApplication.CreateBuilder(args);


//builder.Services.InitConfigurationErrorLoggin(s => Serilog.Log.Warning(s));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        c.RoutePrefix = string.Empty; //Доступ по адресу /swagger
    });
}

app.UseStaticFiles();

app.UseRouting();
app.UseStaticFiles();
//app.UseAuthorization();

app.MapControllers();
app.Run();
