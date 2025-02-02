﻿namespace CaseOnline.Azure.WebJobs.Extensions.Mqtt.Listeners;

public interface IMqttConnection : IDisposable
{
    ConnectionState ConnectionState { get; }

    Task StartAsync(IProcesMqttMessage messageHandler);

    Task PublishAsync(MqttApplicationMessage message);

    Task StopAsync();

    Task SubscribeAsync(MqttTopicFilter[] topics);

    Task UnsubscribeAsync(string[] topics);
}
