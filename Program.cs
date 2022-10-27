using DesafioPOO.Models;

Console.Clear();
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("-- Nokia --");
Smartphone nokia = new Nokia(numero: "111-111", modelo: "x1", imei: "01010101", memoria: 120);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("-- Iphone --");
Smartphone iphone = new Iphone(numero: "222-222", modelo: "x2", imei: "0202020", memoria: 360);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");