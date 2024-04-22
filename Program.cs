using DesafioPOO.Models;

Console.WriteLine("_________________________________________");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "5044", modelo: "Modelo X", iMEI: "587", memoria: 50);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("_________________________________________");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "4787", modelo: "Iphone 13", iMEI: "407", memoria: 120);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("_________________________________________");

