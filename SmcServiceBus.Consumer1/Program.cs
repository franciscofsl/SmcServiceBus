using SmcServiceBus.Consumer1;
using SmcServiceBus.Consumers;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<QueueListener>();

var host = builder.Build();
host.Run();