namespace MSFSInstructor;

using Azure.Identity;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;
using System.Threading.Tasks;
using System.Text.Json;

internal class EventHub
{
    EventHubProducerClient _producerClient;

    public EventHub()
    {
        _producerClient = new EventHubProducerClient(
            "crgar-eventhub.servicebus.windows.net",
            "msfs",
            new AzureCliCredential());
    }

    public async Task SendEventAsync(SimConnectClientData eventBody)
    {
        using EventDataBatch eventBatch = await _producerClient.CreateBatchAsync();

        // Serialize the event body to JSON
        string jsonBody = JsonSerializer.Serialize(eventBody);
        EventData eventData = new EventData(jsonBody)
        {
            ContentType = "application/json",
        };
        eventBatch.TryAdd(eventData);

        // Use the producer client to send the batch of events to the event hub
        await _producerClient.SendAsync(eventBatch);
    }
}
