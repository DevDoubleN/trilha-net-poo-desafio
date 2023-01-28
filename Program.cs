using DesafioPOO.Models;

// Resolvido!!!
Console.WriteLine("Smartphone Nokie");
Smartphone nokia = new Nokia(numero: "73149", modelo: "Modelo 1", "1525354555", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "91367", modelo: "Modelo 2", "1020304050", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");