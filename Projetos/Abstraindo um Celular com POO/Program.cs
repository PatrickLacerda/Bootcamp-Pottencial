using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
//Smartphone nokia  = new Nokia();
Nokia nokia  = new Nokia(numero: "123456", modelo: "Modelo1", iMEI: "11111111111",memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("WhatApp");
Console.WriteLine("\n");
///Nokia nokia2 = new Nokia();
Console.WriteLine("Smartphone Iphone");
//Smartphone iphone = new Iphone();
Smartphone iphone  = new Iphone(numero: "4987", modelo: "Modelo2", iMEI: "33333333",memoria: 256);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
