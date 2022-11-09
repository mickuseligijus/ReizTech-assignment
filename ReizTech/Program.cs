using ReizTech.Services;

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

/* Implemented in Tools.class => Tools.SearchDepth(Branch branch);, Output is tested with unit tests*/


