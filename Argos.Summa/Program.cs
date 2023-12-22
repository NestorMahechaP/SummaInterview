using Argos.Summa.Service.Interface;
using Argos.Summa.Service.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddKeyedSingleton<IAgent, AgentA>("A");
builder.Services.AddKeyedSingleton<IAgent, AgentB>("B");
builder.Services.AddKeyedSingleton<IAgent, AgentC>("C");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
