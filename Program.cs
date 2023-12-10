using DesafioPOO.Models;

Console.WriteLine("Telefone Iphone:");

Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Telefone Nokia:");

Smartphone nokia = new Nokia(numero: "23456", modelo: "Modelo 2", imei: "222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");