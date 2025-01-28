using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRankSolutions
{
    class TimeConversion
    {
        public static string TimeConversionMethod(string s)
        {
            string separatorString = ":";
            string[] timeParts = s.Split(separatorString);
            string militaryTime = "";

            string hours = timeParts[0];
            string mins = timeParts[1];
            string seconds = timeParts[2].Substring(0, 2);
            string morningOrNoon = timeParts[2].Substring(2, 2);

            if (morningOrNoon == "AM")
            {
                if (hours == "12")
                {
                    hours = "00";
                }
                militaryTime = hours + separatorString + mins + separatorString + seconds;
            }
            else if (morningOrNoon == "PM")
            {
                int newHours = 0;
                if (hours != "12")
                {
                    newHours = Convert.ToInt32(hours) + 12;
                    hours = newHours.ToString();
                }
                militaryTime = hours + separatorString + mins + separatorString + seconds;
            }

            return militaryTime;
        }

        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = TimeConversionMethod(s);

            Console.WriteLine(result);
        }
    }

}


/*
 
Given a time in -hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

Example

s = '12:01:00PM'

Return '12:01:00'.

s = '12:01:00AM'

Return '00:01:00'.

Function Description

Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

timeConversion has the following parameter(s):

string s: a time in  hour format
Returns

string: the time in  hour format
Input Format

A single string s that represents a time in 12-hour clock format (i.e.: hh:mm:ssAM or hh:mm:ssPM).

Constraints

All input times are valid
Sample Input

07:05:45PM
Sample Output

19:05:45 

 */