using SmcServiceBus.Consumer1;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<QueueListener>();

var host = builder.Build();
host.Run();