using Confluent.Kafka;

var config =new ProducerConfig
{
    BootstrapServers = "localhost:9092", // Replace with your Kafka broker address
    ClientId = "KafkaExampleProducer",
};
using var producer = new ProducerBuilder<Null, string>(config).Build();
string topic = "my-topic"; // Replace with your topic name
string message = "Hello, Kafka!";
var deliveryReport = producer.ProduceAsync(topic, new Message<Null, string> { Value = message }).Result;
Console.WriteLine($"Produced message to {deliveryReport.Topic} partition {deliveryReport.Partition} @ offset {deliveryReport.Offset}");
Console.ReadLine();