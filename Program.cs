using Microsoft.Extensions.Options;
using OptionsValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOptions<ExampleOptions>()
    .Bind(builder.Configuration.GetSection(ExampleOptions.SectionName));

var app = builder.Build();


app.MapGet("/", (IOptions<ExampleOptions> options) => options.Value);

app.Run();
