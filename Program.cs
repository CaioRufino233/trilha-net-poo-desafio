using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone  
System.Console.WriteLine("Smartphone nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

nokia.ReceberLigacao();

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone iphone: ");
Smartphone iphone = new Iphone (numero: "326536", modelo: "Modelo 2", imei: "3333333333", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

System.Console.WriteLine("\n");

iphone.ReceberLigacao();
