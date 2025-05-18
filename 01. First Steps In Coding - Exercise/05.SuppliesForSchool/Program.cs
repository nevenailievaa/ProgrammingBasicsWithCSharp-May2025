//Prices
double penPacketPrice = 5.80;
double markersPacketPrice = 7.20;
double cleanerLiterPrice = 1.20;

//Input
int penPacketsCount = int.Parse(Console.ReadLine());
int markerPacketsCount = int.Parse(Console.ReadLine());
int cleanerLitersCount = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

//Calculations
double bill = (penPacketsCount * penPacketPrice) +
              (markerPacketsCount * markersPacketPrice) +
              (cleanerLitersCount * cleanerLiterPrice);

double discount = bill * percentDiscount / 100;

//Output
Console.WriteLine(bill - discount);