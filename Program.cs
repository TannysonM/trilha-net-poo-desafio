using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando o Nokia");
Nokia n = new Nokia(numero: "(61)993280258", modelo: "N95", imei: "1234", memoria: 32);
n.Ligar();
n.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Console.WriteLine("Testando o Iphone");
Iphone i = new Iphone(numero: "(61)993409715", modelo: "12-Plus", imei: "5678", memoria: 128);
n.ReceberLigacao();
n.InstalarAplicativo("Icloud");
