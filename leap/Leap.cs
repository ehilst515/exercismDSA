using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool div4 = year % 4 == 0;
        bool notDiv100 = year % 100 != 0;
        bool div400 = year % 400 == 0;

        if (div4)
        {
           if (notDiv100)
                return true;

            if (div400)
                return true;
        } 

        return false;
    }
}