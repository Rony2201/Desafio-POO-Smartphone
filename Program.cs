using System;
using DesafioCelularCsharp.Models;


System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarApp("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarApp("Telegram");