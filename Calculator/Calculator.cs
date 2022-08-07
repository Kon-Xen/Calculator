namespace Calculator;

public class Calculator
{
    
    private string opperator ;
    private string[] numbers;
    private decimal result;
    
    
     public void ShowMessage( string message ) 
    {
        Console.WriteLine( message );
    }
    
     
     public void GetOperator()
     {
        while ( opperator == null)
        {
            Console.WriteLine( "****  Choose operator (+,-,*,/)   ***** " );
            Console.Write( "****        " );
            var input = Console.ReadLine();
          
            opperator = CheckOperatorIsValid( input ) ? input : null;   
        }
    }

     public void reset()
     {
         opperator = null;
     }


     public void GetNumbers()
     {
         var finished = false;
         while ( finished == false)
         {
             Console.WriteLine( "****  enter numbers                ****" );
             Console.WriteLine( "****  seperated with space         ****" );
             Console.Write( "**** ");
             var input = Console.ReadLine();
             var InputNumbers = input.Split(" ");

             foreach (var number in InputNumbers)
             {
                 if (!CheckNumberInputIsValid( number ))
                 {
                     Console.WriteLine( "****  Did you use space ?          ****" );
                     break;
                 }
                 numbers = InputNumbers;
                 finished = true;
             }
         }
    }
     
     
     private static bool CheckOperatorIsValid( string input )
     {
         return input is "+" or "-" or "*" or "/";
     } 

     
    private static bool CheckNumberInputIsValid( string input )
    {
        if (input is not "0")
        {
            return decimal.TryParse(input, out var value2);
        }

        return false;

    }

    
    private string PrepareResultMessage()
    {
        string numberString = " ";
        foreach (var number in numbers)
        {
            numberString += opperator + " " + number + " " ;
        }

        return numberString;
    }

    
    public void DoOpperation()
    { 
        switch ( opperator )
        {
            case "+":
                result = Addition( numbers );
                break;
            case "-":
                result = Subtraction( numbers);
                break;
            case "*":
                result = Multiplication( numbers );
                break;
            case "/":
                result = Division( numbers );
                break;
        }
    } 

    
    public void ShowResult()
    {
        Console.WriteLine( "****" + PrepareResultMessage() + " = " + result + " ****" );
    }

    
    private decimal Addition( string[] numbers )
    {
        decimal sum = 0 ;
        foreach (var number in numbers)
        {
           sum += Convert.ToDecimal( number );
        }
        return sum;
    }
    
    
    private decimal Subtraction( string[] numbers )
    {
        decimal difference =  Convert.ToDecimal(numbers[0]) ;
        for (int x = 1; x < numbers.Length; x++)
        {
            difference = difference - Convert.ToDecimal(numbers[x]);
        }
        return difference;
    }
    
    private decimal Multiplication( string[] numbers )
    {
        decimal product = 1 ;
        foreach (var number in numbers)
        {
            product =  product * Convert.ToDecimal(number);
        }
        return product;
    }
    
    
    private decimal Division( string[] numbers )
    {
        decimal fraction =  Convert.ToDecimal(numbers[0]) ;
        for (int y = 1; y < numbers.Length; y++)
        {
            fraction = fraction / Convert.ToDecimal(numbers[y]);
        }
        return fraction;
    }
}