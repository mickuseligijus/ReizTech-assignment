using ReizTech.Models;
using ReizTech.Services;
using System.Net.NetworkInformation;

//*************** 1 task **************************************************************************************
Console.WriteLine("Enter hours: ");
var inputHours = Console.ReadLine();
Console.WriteLine("Enter minutes: ");
var inputMinutes = Console.ReadLine();

try
{
    var hours = Convert.ToInt32(inputHours);
    var minutes = Convert.ToInt32(inputMinutes);

    if (hours > 12 && hours != 0)
    {
        Console.WriteLine("Hours must be a whole number less than or equal to 12");
    }
    if (minutes > 60 && minutes != 0)
    {
        Console.WriteLine("Minutes must be a whole number less than or equal to 60");
    }
    Console.WriteLine("Angle between hours arrow and minutes arrow is: {0}", Tools.CalculateAngle(hours, minutes));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
//*************************************************************************************************************

//*************** 2 task **************************************************************************************

var v11 = new Branch();

var v10 = new Branch();

var v9 = new Branch()
{
    Branches = new List<Branch>() { v11 }
};

var v8 = new Branch();

var v7 = new Branch();

var v6 = new Branch()
{
    Branches = new List<Branch>() { v9, v10 }
};

var v5 = new Branch()
{
    Branches = new List<Branch>() { v8 }
};

var v4 = new Branch();

var v3 = new Branch()
{
    Branches = new List<Branch>() { v5, v6, v7 }
};

var v2 = new Branch()
{
    Branches = new List<Branch>() { v4 }
};

var v1 = new Branch()
{
    Branches = new List<Branch>() { v2, v3 }
};

Console.WriteLine("Graph depth is {0}", Tools.SearchDepth(v1));

