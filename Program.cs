using Microsoft.OpenApi.Models;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using FluentValidation.AspNetCore;
using System.Reflection;
using MySql.Data.MySqlClient;
using sebo_cultural.Domínio;

var builder = WebApplication.CreateBuilder(args);
/*builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});*/

// Add services to the container.
builder.Services.AddControllers()
    .AddFluentValidation(options =>
    {
        // Validate child properties and root collection elements
        options.ImplicitlyValidateChildProperties = true;
        options.ImplicitlyValidateRootCollectionElements = true;

        // Automatic registration of validators in assembly
        options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Sebo Cultural",
        Description = "API da plataforma Sebo Cultural."
    });
});*/

builder.Services.AddFluentValidationRulesToSwagger();
builder.Services.AddScoped<IRepositorioDeAutorMySql, RepositorioDeAutorMySql>();
builder.Services.AddScoped<IRepositorioDeEditoraMySql, RepositorioDeEditoraMySql>();
builder.Services.AddScoped<IRepositorioDeProdutoMySql, RepositorioDeProdutoMySql>();
builder.Services.AddScoped<IRepositorioDeCategoriaMySql, RepositorioDeCategoriaMySql>();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Staging"))
{
    // TODO: Remover o Swagger no ambiente de produção (apenas descomentar esse IF).
    app.UseSwagger();
    app.UseSwaggerUI();

    //app.UseDeveloperExceptionPage();
}

// Configure the HTTP request pipeline.
/*if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}*/

app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.Run();
