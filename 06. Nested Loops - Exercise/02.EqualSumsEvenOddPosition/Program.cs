﻿//Input
int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());

//Calculations
for (int currentNum = startNum; currentNum <= endNum; currentNum++)
{
    string currentNumAsString = currentNum.ToString();
    int evenNumsSum = 0;
    int oddNumsSum = 0;

    for (int digitPosition = 0; digitPosition < currentNumAsString.Length; digitPosition++)
    {
        int currentDigit = int.Parse(currentNumAsString[digitPosition].ToString());

        if (digitPosition % 2 == 0)
        {
            evenNumsSum += currentDigit;
        }
        else
        {
            oddNumsSum += currentDigit;
        }
    }

    //Output
    if (evenNumsSum == oddNumsSum)
    {
        Console.Write(currentNum + " ");
    }
}