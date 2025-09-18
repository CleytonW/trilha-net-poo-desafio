using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 1100", imei: "151887975", memoria: 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Iphone 11", imei: "159753456", memoria: 1024);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
