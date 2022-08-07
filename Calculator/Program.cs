// See https://aka.ms/new-console-template for more information
// CLI Calculator by KX

using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Calculator;
using Microsoft.VisualBasic.CompilerServices;


var stop = false;
var calc = new Calculator.Calculator();
var dateCalc = new Dateculator.Dateculator();

while ( !stop ) 
{
    calc.ShowMessage( "***************************************" );
    calc.ShowMessage( "****         - Calculator -        ****" );
    calc.ShowMessage( "****   Accepts numbers and dates   ****" );
    calc.ShowMessage( "**** (1) for numbers (2) for dates ****" );
    calc.ShowMessage( "***************************************" );
    
    var option = Console.ReadLine();
    
    if( option == "1" )
    { 
       
        calc.GetOperator();
        calc.GetNumbers();
        calc.DoOpperation();
        calc.ShowResult();
        calc.ShowMessage( "***************************************" );
        calc.ShowMessage( "****           exit ? y/n          ****" );
    } 
    else if (option == "2")
    {
        dateCalc.GetData();
        dateCalc.ShowDate();
        dateCalc.ShowMessage( "***************************************" );
        dateCalc.ShowMessage( "****           exit ? y/n          ****" );
    }
    else
    {
        break;
    }
    
    var check = Console.ReadLine();

    if (check == "y")
    {
        stop = true;
    }
    calc.Reset();
}


