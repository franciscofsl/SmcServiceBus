// See https://aka.ms/new-console-template for more information

using Azure.Messaging.ServiceBus;
using SmcServiceBus.Consumers;

Console.WriteLine("Sending Grreetings");

await SendQueueGreeting();
// await SendTopicGreeting();

Console.ReadLine();

async Task SendQueueGreeting()
{
    var client = new ServiceBusClient(Common.ConnectionString);
    var sender = client.CreateSender(Common.QueueName);
    var message = new ServiceBusMessage("Hello, Fran!");
    await sender.SendMessageAsync(message);
}

async Task SendTopicGreeting()
{
    var client = new ServiceBusClient(Common.ConnectionString);
    var sender = client.CreateSender(Common.TopicName);
    var message = new ServiceBusMessage("Hello, World!");
    await sender.SendMessageAsync(message);
}