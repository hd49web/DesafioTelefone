using DesafioTelefone.Modelos;

Console.WriteLine("\n");

Console.WriteLine("-------SMARTPHONE NOKIA-------");
Smartphone nokia = new Nokia(numero:"55/11-97500-9566", Modelo: " NOK0102", imei: "01020300405036070809", memoria: "64-Bits");
nokia.Ligar();
nokia.InstalarAplicativo("whatsApp");

Console.WriteLine("\n");

Console.WriteLine("-------SMARTPHONE IPHONE-------");
Smartphone iphone = new Iphone(numero: "55/11-97500-9566", Modelo:"IPH0202", imei: "323232323233121212111", memoria:"128-Bits");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");

Console.WriteLine("\n");