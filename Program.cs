using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "86052080", modelo: "Modelo 1", imei: "15213511", memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Tinder");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "8184621", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Baidu");