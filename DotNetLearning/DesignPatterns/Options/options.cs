/*
 * 
{
    "Options": {
        "ConnectionString": "Server=localhost; Database=test;",               
    "TimeoutSeconds": 30,
    "EnableLogging": true
    }
}


var configuration = builder.Configuration.GetSection(nameof(Options));

builder.Services.Configure<Options>(configuration);


*/