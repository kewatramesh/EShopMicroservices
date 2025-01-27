var builder = WebApplication.CreateBuilder(args);

//Add Services to the container
//carter
//mediator

var app = builder.Build();

//configure http request pipeline

app.Run();
