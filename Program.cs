using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("92 994727321", "16 Pro Max", "1291281887AA", 256);
Nokia nokia = new Nokia("92 9293919172", "Modelo Tijolao", "128aba81727", 64);

nokia.InstalarAplicativo("jogo da cobrinha");
iphone.InstalarAplicativo("telegrama");

Console.WriteLine(nokia);
Console.WriteLine(iphone);
