namespace Dateculator;

public class Dateculator : Calculator.Calculator
{
    private DateTime _date;
    private int days;
    
    public void GetData()
     {
         var finished = false;
         while ( finished == false )
         {
             Console.WriteLine( $"{ decorationsSmall }  enter date (dd/mm/yyyy): " );
             Console.Write( $"{ decorationsSmall }" );
             var dateInput = Console.ReadLine();
             
             if (!CheckDateIsValid( dateInput ))
             {
                 ShowMessage( errors[0] );
                 Console.WriteLine( "****  Did you use a date ?" );
                 break;
             }
             
             _date = DateTime.ParseExact( dateInput, "dd/MM/yyyy",null);
             
             Console.WriteLine( $"{ decorationsSmall }  how many days to add ?: " );
             Console.Write( $"{ decorationsSmall }" );
             var daysInput = Console.ReadLine();
             if (!CheckDaysAreValid( daysInput ))
             {
                 ShowMessage( errors[0] );
                 Console.WriteLine( "****  Did you use an integer ?" );
                 break;
             }

             days = int.Parse(daysInput);
             
             finished = true;
         }
     }

    private static bool CheckDateIsValid(string input)
    {
        return DateTime.TryParse(input, out var value2);
    }

    
    private static bool CheckDaysAreValid( string input )
    {
        return int.TryParse(input, out var value2);
    }
    
    
    private DateTime addDays()
    {
        var newDate = _date.AddDays(days);
        return newDate.Date;
    }

    public void ShowDate()
    {
        Console.WriteLine( $"{ decorationsSmall } { addDays() }" );
    }
}