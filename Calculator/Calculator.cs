namespace Calculator;

public class Calculator
{
    public string opperator ;
    public string[] numbers;
    public string ResultMessage = " ";
    public int IntResult;
    public decimal DecimalResult;
     public void ShowMessage( string message ) 
    {
        Console.WriteLine( message );
    }
    
     public void GetOperator()
     {
        while ( opperator == null)
        {
            Console.WriteLine( "Choose operation (+,-,*,/): " );
            var input = Console.ReadLine();
            opperator = CheckOperatorIsValid( input ) ? input : null;   
        }
    }
     
     public void GetNumbers()
     {
         var finished = false;
         while ( finished == false)
         {
             Console.WriteLine( "enter numbers (seperated with space): " );
             var input = Console.ReadLine();
             var InputNumbers = input.Split(" ");

             foreach (var number in InputNumbers)
             {
                 if (!CheckInputIsValid(number))
                 {
                     Console.WriteLine( "Not all numbers are valid. Did you use space ? " );
                     break;
                 }
                 numbers = InputNumbers;
                 finished = true;
             }
         }
    }
     
     static bool CheckOperatorIsValid( string input )
     {
         Console.WriteLine( "did you enter a valid operator ? " );
         return input is "+" or "-" or "*" or "/";
     } 

    static bool CheckInputIsValid( string input )
    {
        return int.TryParse(input, out var value1) || decimal.TryParse(input, out var value2);
    }

    public string PrepareResultMessage()
    {
        string numberString = " ";
        foreach (var number in numbers)
        {
            numberString += " " + number + " " + opperator;
        }

        return numberString;
    }

    public void DoOpperation()
    {
        switch ( opperator )
        {
            case "+":
               Addition( numbers );
                break;
            case "-":
                Subtraction( numbers);
                break;
            case "*":
                Multiplication( numbers );
                break;
            case "/":
                Division(numbers);
                break;
        }
    } 

    public void ShowResult()
    {
        Console.WriteLine( PrepareResultMessage() );
        Console.WriteLine( "= " + IntResult );
    }

    public void Addition( string[] numbers )
    {
        
        // return numbers.Sum();
    }
    public void Subtraction( string[] numbers )
    {
        
    }
    public void Multiplication( string[] numbers )
    {
        
    }
    public void Division( string[] numbers )
    {
        Console.WriteLine("");
    }
}