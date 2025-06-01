//Input
string month = Console.ReadLine();
int daysStay = int.Parse(Console.ReadLine());

//Calculations
double studioPrice = 0;
double apartamentPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = 50.00;
    apartamentPrice = 65.00;

    if (daysStay > 7 && daysStay <= 14)
    {
        studioPrice = studioPrice * 0.95; // 5% Discount
    }
    else if (daysStay > 14)
    {
        studioPrice = studioPrice * 0.70; // 30% Discount
    }
}
else if (month == "June" || month == "September")
{
    studioPrice = 75.20;
    apartamentPrice = 68.70;

    if (daysStay > 14)
    { 
        studioPrice = studioPrice * 0.80; // 20% Discount
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = 76.00;
    apartamentPrice = 77.00;
}

if (daysStay > 14)
{
    apartamentPrice = apartamentPrice * 0.9; // 10% Discount
}

double studioBill = daysStay * studioPrice;
double apartmentBill = daysStay * apartamentPrice;

//Output
Console.WriteLine($"Apartment: {apartmentBill:f2} lv.");
Console.WriteLine($"Studio: {studioBill:f2} lv.");