using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TimeEvent
/// </summary>
public class TimeEvent
{


    static int minute = 10, sec = 0;

   public static string time_count()
    {
        if (sec == 0)
        {
            sec = 60;
            minute = minute - 1;
        }
        sec = sec - 1;

    return( minute+":" +sec);
    }
	
}
