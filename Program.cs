using HC.CustomerNumberScalar;
using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .BindRuntimeType<CustomerNumber, CustomerNumberType>()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
