using DesafioPOO.Models;

Iphone iphone = new Iphone("4199999", "XS", "111111", 11);

Nokia nokia = new Nokia("4188888", "TIJOLAO", "4148464681", 12);

iphone.InstalarAplicativo("Pokemon GO");
nokia.InstalarAplicativo("Strava");


iphone.Ligar();

nokia.ReceberLigacao();



