using VVSA_backend.Service;
using VVSA_backend.Repository;
using VVSA_backend.DatabaseModel;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddDbContext<Whiyes5oContext> ();
var app = builder.Build();
app.MapControllers();
app.Run();