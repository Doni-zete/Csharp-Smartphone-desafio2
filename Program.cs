using desafio2.models;

Console.WriteLine("Hey Iphone");
Smartphone iphone = new Iphone(numero: "(16)99999-9999", modelo: "Intergalatico V200", imei: "00000000001", memoria: 228);
iphone.ExibirDadosAparelho();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.LigacaoConcluida();


Console.WriteLine("\n");

Console.WriteLine("Hey Nokia");
Smartphone nokia = new Nokia(numero: "(17 92592-2657)", modelo: "Modelo Dalek", imei: "9364782", memoria: 654);
nokia.ExibirDadosAparelho();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Signal");
nokia.LigacaoConcluida();

