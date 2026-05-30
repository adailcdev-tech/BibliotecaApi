using BibliotecaApi.Repositories;
using BibliotecaApi.Services;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// MongoDB
var mongoConnectionString = builder.Configuration["MongoDBSettings:ConnectionString"];
builder.Services.AddSingleton<IMongoClient>(new MongoClient(mongoConnectionString));

// Repositories
builder.Services.AddScoped<ILivroRepositorios, LivroRepository>();
builder.Services.AddScoped<IEmprestimoRepositorios, EmprestimoRepository>();

// Services
builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<IEmprestimoService, EmprestimoService>();

// Controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseAuthorization();
app.MapControllers();

app.Run();
