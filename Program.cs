using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Modelo 2", imei: "2222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
