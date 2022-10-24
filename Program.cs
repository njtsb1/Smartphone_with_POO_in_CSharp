using ChallengePOOSCellularSystem.Models;

Console.WriteLine("Telephone Samsung");
Smartphone samsung = new Samsung(number: "997435764", model: "13", iMEI: "171", memory: 256);
samsung.Turnon();
samsung.InstallApp("TikTok");

Console.WriteLine("\nTelephone Iphone");
Smartphone iphone = new Iphone(number: "991583124", model: "plus", iMEI: "666", memory: 512);
iphone.Turnon();
iphone.InstallApp("WhatsApp");